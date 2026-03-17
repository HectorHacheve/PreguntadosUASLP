CREATE DATABASE preguntados_uaslp;

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
/*
Ejemplo de insertar
INSERT INTO preguntas VALUES
(201,3,'¿Quién dirigió Titanic?','texto'/'audio'/'imagen');
*/
SELECT * FROM preguntas;

CREATE TABLE respuestas (
    id_respuesta INT PRIMARY KEY,
    id_pregunta INT NOT NULL,
    respuesta VARCHAR(255) NOT NULL,
    es_correcta BOOLEAN NOT NULL,

    FOREIGN KEY (id_pregunta)
    REFERENCES preguntas(id_pregunta)
);

/*
Ejemplo de insertar
en caso del tipo de respuesta se le pone el texto o la ruta,
ya dependiendo de lo que sea el tipo se leera desde el campo tipo de pregunta 
en la tabla de pregunta.
INSERT INTO respuestas VALUES
(2011,201,'James Cameron',TRUE),
(2012,201,'Steven Spielberg',FALSE),
(2013,201,'Christopher Nolan',FALSE),
(2014,201,'Ridley Scott',FALSE);
*/
SELECT * FROM respuestas;

CREATE TABLE partidas (
    id_partida INT AUTO_INCREMENT PRIMARY KEY,
    fecha DATETIME NOT NULL,
    id_categoria INT NOT NULL,
    preguntas_correctas INT,
    preguntas_incorrectas INT,

    FOREIGN KEY (id_categoria)
    REFERENCES categorias(id_categoria)
);

/*
Ejemplo
INSERT INTO partidas (fecha, id_categoria, preguntas_correctas, preguntas_incorrectas)
VALUES (NOW(), 3, 7, 3);
*/

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


/*
Ejemplo de como seria el into
INSERT INTO respuestas_partida (id_partida, id_pregunta, correcta)
VALUES (3, 201, TRUE/FALSE);
*/