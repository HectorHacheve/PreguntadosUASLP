--  Preguntas Futbol Texto

INSERT INTO preguntas (id_pregunta, id_categoria, pregunta, tipo) VALUES
(601, 6, '¿Qué selección ha ganado más Copas del Mundo?', 'texto'),
(602, 6, '¿Quién es el máximo goleador histórico de la UEFA Champions League?', 'texto'),
(603, 6, '¿Qué selección gano el mundial 2022?', 'texto'),
(604, 6, '¿Cuál es el equipo de la liga MX mas beneficiado?', 'texto');

-- Respuestas Futbol Texto 

INSERT INTO respuestas (id_respuesta, id_pregunta, respuesta, es_correcta) VALUES
(6011, 601, 'Brasil', TRUE),
(6012, 601, 'Alemania', FALSE),
(6013, 601, 'Italia', FALSE),
(6014, 601, 'Argentina', FALSE);

INSERT INTO respuestas (id_respuesta, id_pregunta, respuesta, es_correcta) VALUES
(6021, 602, 'Cristiano Ronaldo', TRUE),
(6022, 602, 'Lionel Messi', FALSE),
(6023, 602, 'Robert Lewandowski', FALSE),
(6024, 602, 'Karim Benzema', FALSE);

INSERT INTO respuestas (id_respuesta, id_pregunta, respuesta, es_correcta) VALUES
(6031, 603, 'Uruguay', FALSE),
(6032, 603, 'Brasil', FALSE),
(6033, 603, 'Francia', FALSE),
(6034, 603, 'Argentina', TRUE);

INSERT INTO respuestas (id_respuesta, id_pregunta, respuesta, es_correcta) VALUES
(6041, 604, 'Club América', TRUE),
(6042, 604, 'Chivas de Guadalajara', FALSE),
(6043, 604, 'Cruz Azul', FALSE),
(6044, 604, 'Toluca', FALSE);

-- Preguntas Futbol Imagen 

INSERT INTO preguntas (id_pregunta, id_categoria, pregunta, tipo) VALUES
(605, 6, '¿Cuál es el escudo del FC Barcelona?', 'imagen'),
(606, 6, '¿Cuál es el escudo de la selección mexicana?', 'imagen'),
(607, 6, '¿Qué imagen corresponde al trofeo de la Champions League?', 'imagen'),
(608, 6, '¿Cúal de los siguientes fue un jugador mexicano?', 'imagen');


INSERT INTO respuestas (id_respuesta, id_pregunta, respuesta, es_correcta) VALUES
(6051, 605, 'imagenes/barca.jpg', TRUE),
(6052, 605, 'imagenes/madrid.jpg', FALSE),
(6053, 605, 'imagenes/atletico.jpg', FALSE),
(6054, 605, 'imagenes/manchester.jpg', FALSE);

INSERT INTO respuestas (id_respuesta, id_pregunta, respuesta, es_correcta) VALUES
(6061, 606, 'imagenes/mexico.jpg', TRUE),
(6062, 606, 'imagenes/brasil.jpg', FALSE),
(6063, 606, 'imagenes/italia.jpg', FALSE),
(6064, 606, 'imagenes/francia.jpg', FALSE);

INSERT INTO respuestas (id_respuesta, id_pregunta, respuesta, es_correcta) VALUES
(6071, 607, 'imagenes/champions.jpg', TRUE),
(6072, 607, 'imagenes/mundial.jpg', FALSE),
(6073, 607, 'imagenes/premier.jpg', FALSE),
(6074, 607, 'imagenes/liga.jpg', FALSE);

INSERT INTO respuestas (id_respuesta, id_pregunta, respuesta, es_correcta) VALUES
(6081, 608, 'imagenes/rafamarquez.jpg', TRUE),
(6082, 608, 'imagenes/dimaria.jpg', FALSE),
(6083, 608, 'imagenes/ronaldo.jpg', FALSE),
(6084, 608, 'imagenes/messi.jpg', FALSE);

-- Preguntas futbol audio

INSERT INTO preguntas (id_pregunta, id_categoria, pregunta, tipo) VALUES
(609, 6, '¿Cuál es el himno de la seleccion mexicana?', 'audio'),
(610, 6, '¿Cuál es el himno del Real Madrd?', 'audio'),
(611, 6, '¿Cuál es el himno del FC Barcelona?', 'audio'),
(612, 6, '¿Cuál es el himno del Manchester United?', 'audio');


-- Respuestas futbol audio
INSERT INTO respuestas (id_respuesta, id_pregunta, respuesta, es_correcta) VALUES
(6091, 609, 'audios/himnomexico.wav', TRUE),
(6092, 609, 'audios/himnoargentina.wav', FALSE),
(6093, 609, 'audios/himnobrasil.wav', FALSE),
(6094, 609, 'audios/himnoportugal.wav', FALSE);


INSERT INTO respuestas (id_respuesta, id_pregunta, respuesta, es_correcta) VALUES
(6101, 610, 'audios/himnorealmadrid.wav', TRUE),
(6102, 610, 'audios/himnobarca.wav', FALSE),
(6103, 610, 'audios/himnounited.wav', FALSE),
(6104, 610, 'audios/himnoatletico.wav', FALSE);


INSERT INTO respuestas (id_respuesta, id_pregunta, respuesta, es_correcta) VALUES
(6111, 611, 'audios/himnobarca.wav', TRUE),
(6112, 611, 'audios/himnorealmadrid.wav', FALSE),
(6113, 611, 'audios/himnounited.wav', FALSE),
(6114, 611, 'audios/himnoatletico.wav', FALSE);

INSERT INTO respuestas (id_respuesta, id_pregunta, respuesta, es_correcta) VALUES
(6121, 612, 'audios/himnounited.wav', TRUE),
(6122, 612, 'audios/himnorealmadrid.wav', FALSE),
(6123, 612, 'audios/himnobarca.wav', FALSE),
(6124, 612, 'audios/himnoatletico.wav', FALSE);


 


