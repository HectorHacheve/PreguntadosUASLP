import mysql.connector
from mysql.connector import Error
from typing import Optional, List, Dict, Any

class DatabaseManager:
    def __init__(self, host: str, user: str, password: str, database: str):
        self.host = host
        self.user = user
        self.password = password
        self.database = database
        self.connection = None
    
    def connect(self):
        """Conectar a la base de datos"""
        try:
            self.connection = mysql.connector.connect(
                host=self.host,
                user=self.user,
                password=self.password,
                database=self.database
            )
            print("✅ Conexión a MySQL exitosa")
        except Error as e:
            print(f"❌ Error al conectar: {e}")
            raise
    
    def disconnect(self):
        """Desconectar de la base de datos"""
        if self.connection and self.connection.is_connected():
            self.connection.close()
            print("Conexión cerrada")
    
    def execute_query(self, query: str, params: tuple = None) -> List[Dict]:
        """Ejecutar SELECT"""
        try:
            cursor = self.connection.cursor(dictionary=True)
            if params:
                cursor.execute(query, params)
            else:
                cursor.execute(query)
            result = cursor.fetchall()
            cursor.close()
            return result
        except Error as e:
            print(f"Error en query: {e}")
            return []
    
    def execute_update(self, query: str, params: tuple = None) -> int:
        """Ejecutar INSERT, UPDATE, DELETE"""
        try:
            cursor = self.connection.cursor()
            if params:
                cursor.execute(query, params)
            else:
                cursor.execute(query)
            self.connection.commit()
            result = cursor.lastrowid
            cursor.close()
            return result
        except Error as e:
            print(f"Error en update: {e}")
            self.connection.rollback()
            return 0
