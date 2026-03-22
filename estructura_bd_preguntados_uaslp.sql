USE preguntados_uaslp;

CREATE TABLE categorias (
    id_categoria INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL
);

INSERT INTO categorias (nombre) VALUES
('Uaslp'),
('Redes_sociales'),
('Cine'),
('Tecnologia'),
('Videojuegos'),
('Futbol'),
('Cultura_pop');

SELECT * FROM categorias;

CREATE TABLE preguntas (
    id_pregunta INT PRIMARY KEY,
    id_categoria INT NOT NULL,
    pregunta TEXT NOT NULL,
    tipo ENUM('texto','imagen','audio') NOT NULL,
    
    FOREIGN KEY (id_categoria)
    REFERENCES categorias(id_categoria)
);

SELECT * FROM preguntas;

CREATE TABLE respuestas (
    id_respuesta INT PRIMARY KEY,
    id_pregunta INT NOT NULL,
    respuesta VARCHAR(255) NOT NULL,
    es_correcta BOOLEAN NOT NULL,

    FOREIGN KEY (id_pregunta)
    REFERENCES preguntas(id_pregunta)
);

SELECT * FROM respuestas;

-- Preguntas Cine texto
INSERT INTO preguntas VALUES
(301,3,'¿Qué actor interpretó a Jack Dawson en Titanic (1997)?','texto'),
(302,3,'¿Cómo se llama el parque de dinosaurios en la película de 1993 de Spielberg?','texto'),
(303,3,'¿Qué director hizo Inception, Interstellar y Tenet?','texto'),
(304,3,'¿Qué estudio creó Toy Story y Up?','texto');

INSERT INTO respuestas VALUES
(3011,301,'Brad Pitt',FALSE),
(3012,301,'Leonardo DiCaprio',TRUE),
(3013,301,'Matt Damon',FALSE),
(3014,301,'Tom Cruise',FALSE),

(3021,302,'Mundo Jurásico',FALSE),
(3022,302,'Parque Cretácico',FALSE),
(3023,302,'Parque Jurásico',TRUE),
(3024,302,'Isla de los Dinosaurios',FALSE),

(3031,303,'Quentin Tarantino',FALSE),
(3032,303,'Steven Spielberg',FALSE),
(3033,303,'Christopher Nolan',TRUE),
(3034,303,'James Cameron',FALSE),

(3041,304,'DreamWorks Animation',FALSE),
(3042,304,'Pixar Animation Studios',TRUE),
(3043,304,'Illumination Entertainment',FALSE),
(3044,304,'Blue Sky Studios',FALSE);

-- Preguntas Cine imagenes
INSERT INTO preguntas VALUES
(305,3,'¿Cuál de estos personajes es de una película de Studio Ghibli?','imagen'),
(306,3,'¿Cuál de estas estatuillas es el Premio Oscar (Academy Award)?','imagen'),
(307,3,'¿Qué personaje pertenece a la película "Fantástico Sr. Fox"?','imagen');

INSERT INTO respuestas VALUES
(3051,305,'imagenes/Gibby.jpg',FALSE),
(3052,305,'imagenes/Shizuku_Tsukishima.jpg',TRUE),
(3053,305,'imagenes/Nyanko-sensei.jpg',FALSE),
(3054,305,'imagenes/Suzu.jpg',FALSE),

(3061,306,'imagenes/Palma_de_Oro.jpg',FALSE),
(3062,306,'imagenes/Globo_de_Oro.jpg',FALSE),
(3063,306,'imagenes/Premio_Oscar.jpg',TRUE),
(3064,306,'imagenes/Oso_de_Oro.jpg',FALSE),

(3071,307,'imagenes/Ash.jpg',TRUE),
(3072,307,'imagenes/Miguel.jpg',FALSE),
(3073,307,'imagenes/Coraline.jpg',FALSE),
(3074,307,'imagenes/Violet.jpg',FALSE);

-- Preguntas Tecnologia
INSERT INTO preguntas VALUES
(401,4,'¿Qué compañía fundaron Bill Gates y Paul Allen en 1975?','texto'),
(402,4,'¿Qué sistema operativo usa un robot verde como logo?','texto'),
(403,4,'¿Qué empresa popularizó el smartphone moderno con pantalla táctil?','texto'),
(404,4,'¿Qué empresa desarrolló Symbian?','texto');

INSERT INTO respuestas VALUES
(4011,401,'Apple',FALSE),
(4012,401,'IBM',FALSE),
(4013,401,'Microsoft',TRUE),
(4014,401,'Google',FALSE),

(4021,402,'iOS',FALSE),
(4022,402,'Android',TRUE),
(4023,402,'Windows Phone',FALSE),
(4024,402,'HarmonyOS',FALSE),

(4031,403,'Samsung',FALSE),
(4032,403,'Nokia',FALSE),
(4033,403,'BlackBerry',FALSE),
(4034,403,'Apple',TRUE),

(4041,404,'Samsung',FALSE),
(4042,404,'Motorola',FALSE),
(4043,404,'Nokia',TRUE),
(4044,404,'Sony Ericsson',FALSE);

CREATE TABLE partidas (
    id_partida INT AUTO_INCREMENT PRIMARY KEY,
    fecha DATETIME NOT NULL,
    id_categoria INT NOT NULL,
    preguntas_correctas INT,
    preguntas_incorrectas INT,

    FOREIGN KEY (id_categoria)
    REFERENCES categorias(id_categoria)
);

SELECT * FROM partidas;

CREATE TABLE respuestas_partida (
    id_registro INT AUTO_INCREMENT PRIMARY KEY,
    id_partida INT NOT NULL,
    id_pregunta INT NOT NULL,
    correcta BOOLEAN NOT NULL,

    FOREIGN KEY (id_partida)
    REFERENCES partidas(id_partida),

    FOREIGN KEY (id_pregunta)
    REFERENCES preguntas(id_pregunta)
);