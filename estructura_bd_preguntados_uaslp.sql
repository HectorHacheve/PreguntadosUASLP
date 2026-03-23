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

-- CINE 

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

-- Preguntas Cine audio
INSERT INTO preguntas VALUES
(308,3,'¿Cuál de estas melodías pertenece a la película Harry Potter?','audio'),
(309,3,'¿Cuál de estas canciones es la principal del musical El Mago de Oz (1939)?','audio'),
(310,3,'¿Cuál de estas frases fue dicha por el personaje de Darth Vader en Star Wars?','audio');

INSERT INTO respuestas VALUES
-- Harry Potter
(3081,308,'audios/star_wars_theme.wav',FALSE),
(3082,308,'audios/lord_of_rings_theme.wav',FALSE),
(3083,308,'audios/hedwig_theme.wav',TRUE),
(3084,308,'audios/pirates_caribbean.wav',FALSE),
-- El Mago de Oz
(3091,309,'audios/over_the_rainbow.wav',TRUE),
(3092,309,'audios/be_our_guest.wav',FALSE),
(3093,309,'audios/whistle_while_you_work.wav',FALSE),
(3094,309,'audios/spoonful_of_sugar.wav',FALSE),
-- Darth Vader
(3101,310,'audios/may_force_be_with_you.wav',FALSE),
(3102,310,'audios/i_am_your_father.wav',TRUE),
(3103,310,'audios/ill_be_back.wav',FALSE),
(3104,310,'audios/my_precious.wav',FALSE);

-- TECNOLOGIA 

-- Preguntas Tecnologia texto
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

-- Preguntas Tecnologia imagenes
INSERT INTO preguntas VALUES
(405,4,'¿Cuál de estos es el logotipo de Linux?','imagen'),
(406,4,'¿Cuál de estos robots es ASIMO, el robot humanoide desarrollado por Honda que fue presentado en el año 2000?','imagen'),
(407,4,'¿Cuál de estos dispositivos de almacenamiento fue el primero en popularizarse para uso doméstico en los años 80 y tenía una capacidad típica de 1.44 MB?','imagen');

INSERT INTO respuestas VALUES
-- Linux
(4051,405,'imagenes/Windows.jpg',FALSE),
(4052,405,'imagenes/Android.jpg',FALSE),
(4053,405,'imagenes/Tux.jpg',TRUE),
(4054,405,'imagenes/Apple.jpg',FALSE),
-- ASIMO
(4061,406,'imagenes/ASIMO.jpg',TRUE),
(4062,406,'imagenes/Spot.jpg',FALSE),
(4063,406,'imagenes/Atlas.jpg',FALSE),
(4064,406,'imagenes/Pepper.jpg',FALSE),
-- Disquete
(4071,407,'imagenes/Disquete_3.5.jpg',TRUE),
(4072,407,'imagenes/Cassette.jpg',FALSE),
(4073,407,'imagenes/CD-ROM.jpg',FALSE),
(4074,407,'imagenes/USB.jpg',FALSE);

-- Preguntas Tecnologia audio
INSERT INTO preguntas VALUES
(408,4,'¿Cuál de estos audios es el famoso "sonido de error crítico" de Windows XP?','audio'),
(409,4,'¿Cuál de estos sonidos es el de inicio de Windows 95?','audio'),
(410,4,'¿Cuál es el sonido de inicio de Nokia?','audio');

INSERT INTO respuestas VALUES
-- Windows XP error
(4081,408,'audios/glitch_error.wav',FALSE),
(4082,408,'audios/windows_xp_error.wav',TRUE),
(4083,408,'audios/mac_error.wav',FALSE),
(4084,408,'audios/windows_shutdown.wav',FALSE),
-- Windows 95 inicio
(4091,409,'audios/mac_startup.wav',FALSE),
(4092,409,'audios/windows_95_startup.wav',TRUE),
(4093,409,'audios/linux_startup.wav',FALSE),
(4094,409,'audios/windows_shutdown.wav',FALSE),
-- Nokia inicio
(4101,410,'audios/siri_activation.wav',FALSE),
(4102,410,'audios/intel_logo.wav',FALSE),
(4103,410,'audios/nokia_startup.wav',TRUE),
(4104,410,'audios/lg_logo.wav',FALSE);


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