from fastapi import FastAPI, HTTPException
from fastapi.middleware.cors import CORSMiddleware
from pydantic import BaseModel
from typing import List, Optional
from database import DatabaseManager
import random

# Configuración
DB_HOST = "127.0.0.1"
DB_USER = "root"
DB_PASSWORD = "HV2004HE"
DB_NAME = "preguntados_uaslp"

# Inicializar DB
db = DatabaseManager(DB_HOST, DB_USER, DB_PASSWORD, DB_NAME)
db.connect()

# Crear app FastAPI
app = FastAPI(title="PreguntadosUASLP API")

# CORS para que C# pueda conectarse
app.add_middleware(
    CORSMiddleware,
    allow_origins=["*"],
    allow_credentials=True,
    allow_methods=["*"],
    allow_headers=["*"],
)

# ==================== MODELOS ====================

class Categoria(BaseModel):
    id_categoria: int
    nombre: str

class Respuesta(BaseModel):
    id_respuesta: int
    respuesta: str
    es_correcta: bool

class Pregunta(BaseModel):
    id_pregunta: int
    pregunta: str
    tipo: str
    respuestas: List[Respuesta]
    respuesta_correcta_id: int

class Partida(BaseModel):
    id_partida: int
    fecha: str
    id_categoria: int
    preguntas_correctas: int
    preguntas_incorrectas: int

class RespuestaPartida(BaseModel):
    id_partida: int
    id_pregunta: int
    correcta: bool

# ==================== ENDPOINTS ====================

@app.get("/api/categorias", response_model=List[Categoria])
def obtener_categorias():
    """Obtener todas las categorías"""
    try:
        query = "SELECT id_categoria, nombre FROM categorias"
        result = db.execute_query(query)
        return [Categoria(**row) for row in result]
    except Exception as e:
        raise HTTPException(status_code=500, detail=str(e))

@app.get("/api/categorias/{id_categoria}")
def obtener_nombre_categoria(id_categoria: int):
    """Obtener nombre de una categoría específica"""
    try:
        query = "SELECT nombre FROM categorias WHERE id_categoria = %s"
        result = db.execute_query(query, (id_categoria,))
        if result:
            return {"nombre": result[0]["nombre"]}
        raise HTTPException(status_code=404, detail="Categoría no encontrada")
    except Exception as e:
        raise HTTPException(status_code=500, detail=str(e))

@app.get("/api/preguntas/{id_categoria}")
def obtener_pregunta(id_categoria: int, excluir: Optional[str] = None):
    """Obtener una pregunta aleatoria de una categoría
    
    Args:
        id_categoria: ID de la categoría
        excluir: IDs de preguntas a excluir (ej: "1,2,3")
    """
    try:
        query = "SELECT id_pregunta, pregunta, tipo FROM preguntas WHERE id_categoria = %s"
        params = [id_categoria]
        
        if excluir:
            ids = excluir.split(",")
            placeholders = ",".join(["%s"] * len(ids))
            query += f" AND id_pregunta NOT IN ({placeholders})"
            params.extend(ids)
        
        query += " ORDER BY RAND() LIMIT 1"
        result = db.execute_query(query, tuple(params))
        
        if not result:
            raise HTTPException(status_code=404, detail="No hay preguntas disponibles")
        
        pregunta = result[0]
        id_pregunta = pregunta["id_pregunta"]
        
        # Obtener respuestas
        query_respuestas = """
            SELECT id_respuesta, respuesta, es_correcta 
            FROM respuestas 
            WHERE id_pregunta = %s
        """
        respuestas_data = db.execute_query(query_respuestas, (id_pregunta,))
        
        respuestas = []
        respuesta_correcta_id = None
        for resp in respuestas_data:
            respuestas.append(Respuesta(**resp))
            if resp["es_correcta"]:
                respuesta_correcta_id = resp["id_respuesta"]
        
        return {
            "id_pregunta": id_pregunta,
            "pregunta": pregunta["pregunta"],
            "tipo": pregunta["tipo"],
            "respuestas": respuestas,
            "respuesta_correcta_id": respuesta_correcta_id
        }
    except HTTPException:
        raise
    except Exception as e:
        raise HTTPException(status_code=500, detail=str(e))

@app.get("/api/total-preguntas/{id_categoria}")
def obtener_total_preguntas(id_categoria: int):
    """Obtener total de preguntas en una categoría"""
    try:
        query = "SELECT COUNT(*) as total FROM preguntas WHERE id_categoria = %s"
        result = db.execute_query(query, (id_categoria,))
        return {"total": result[0]["total"] if result else 0}
    except Exception as e:
        raise HTTPException(status_code=500, detail=str(e))

@app.post("/api/partidas")
def crear_partida(id_categoria: int):
    """Crear una nueva partida"""
    try:
        query = """
            INSERT INTO partidas (fecha, id_categoria, preguntas_correctas, preguntas_incorrectas)
            VALUES (NOW(), %s, 0, 0)
        """
        id_partida = db.execute_update(query, (id_categoria,))
        
        if id_partida:
            return {"id_partida": id_partida}
        raise HTTPException(status_code=500, detail="Error al crear partida")
    except Exception as e:
        raise HTTPException(status_code=500, detail=str(e))

@app.post("/api/respuestas-partida")
def guardar_respuesta(data: RespuestaPartida):
    """Guardar una respuesta de la partida"""
    try:
        query = """
            INSERT INTO respuestas_partida (id_partida, id_pregunta, correcta)
            VALUES (%s, %s, %s)
        """
        db.execute_update(query, (data.id_partida, data.id_pregunta, data.correcta))
        return {"status": "ok"}
    except Exception as e:
        raise HTTPException(status_code=500, detail=str(e))

@app.put("/api/partidas/{id_partida}")
def actualizar_partida_final(id_partida: int, preguntas_correctas: int, preguntas_incorrectas: int):
    """Actualizar partida con resultados finales"""
    try:
        query = """
            UPDATE partidas 
            SET preguntas_correctas = %s, preguntas_incorrectas = %s
            WHERE id_partida = %s
        """
        db.execute_update(query, (preguntas_correctas, preguntas_incorrectas, id_partida))
        return {"status": "ok"}
    except Exception as e:
        raise HTTPException(status_code=500, detail=str(e))

# Health check
@app.get("/health")
def health():
    """Verificar si la API está funcionando"""
    return {"status": "ok", "database": "connected" if db.connection else "disconnected"}

# ==================== SHUTDOWN ====================

@app.on_event("shutdown")
def shutdown():
    """Cerrar conexión al apagar"""
    db.disconnect()

if __name__ == "__main__":
    import uvicorn
    uvicorn.run(app, host="0.0.0.0", port=8000)
