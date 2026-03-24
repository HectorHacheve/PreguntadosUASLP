--  Preguntas Videojuegos Texto

INSERT INTO preguntas (id_pregunta, id_categoria, pregunta, tipo) VALUES
(501, 5, '¿Qué compañia desarrollo el videojugo Fortnite?', 'texto'),
(502, 5, '¿Qué consola de videojuegos es la mas vendida?', 'texto'),
(503, 5, '¿De que compañia pertenece la saga de HALO?', 'texto'),
(504, 5, '¿Cúal de los siguientes es un videojuego es un exclusivo de PlayStation?', 'texto');

-- Respuestas Futbol Texto 

INSERT INTO respuestas (id_respuesta, id_pregunta, respuesta, es_correcta) VALUES
(5011, 501, 'Epic Games', TRUE),
(5012, 501, 'Activision', FALSE),
(5013, 501, 'Ubisoft', FALSE),
(5014, 501, 'Electronic Arts', FALSE);

INSERT INTO respuestas (id_respuesta, id_pregunta, respuesta, es_correcta) VALUES
(5021, 502, 'PlayStation 2', TRUE),
(5022, 502, 'Xbox 360', FALSE),
(5023, 502, 'Xbox One', FALSE),
(5024, 502, 'PlayStation 5', FALSE);

INSERT INTO respuestas (id_respuesta, id_pregunta, respuesta, es_correcta) VALUES
(5031, 503, 'PlayStation', FALSE),
(5032, 503, 'Nintendo', FALSE),
(5033, 503, 'Epic Games', FALSE),
(5034, 503, 'Xbox', TRUE);

INSERT INTO respuestas (id_respuesta, id_pregunta, respuesta, es_correcta) VALUES
(5041, 504, 'Uncharted', TRUE),
(5042, 504, 'Forza Horizon', FALSE),
(5043, 504, 'Fortnite', FALSE),
(5044, 504, 'HALO', FALSE);

-- Preguntas Videojeugos Imagen 

INSERT INTO preguntas (id_pregunta, id_categoria, pregunta, tipo) VALUES
(505, 5, '¿Cuál es el logo de Nintendo?', 'imagen'),
(506, 5, '¿Cuál es el protagonista del videojuego Red Dead Redemption 2?', 'imagen'),
(507, 5, '¿Cuál de las siguientes imagenes es el logo de xbox?', 'imagen'),
(508, 5, '¿Cúal de las siguientes consolas es de PlayStation?', 'imagen');


INSERT INTO respuestas (id_respuesta, id_pregunta, respuesta, es_correcta) VALUES
(5051, 505, 'imagenes/logonintendo.jpg', TRUE),
(5052, 505, 'imagenes/logoxbox.jpg', FALSE),
(5053, 505, 'imagenes/logoplaystation.jpg', FALSE),
(5054, 505, 'imagenes/logosteam.jpg', FALSE);

INSERT INTO respuestas (id_respuesta, id_pregunta, respuesta, es_correcta) VALUES
(5061, 506, 'imagenes/arthurmorgan.jpg', TRUE),
(5062, 506, 'imagenes/jefemaestro.jpg', FALSE),
(5063, 506, 'imagenes/johnmarston.jpg', FALSE),
(5064, 506, 'imagenes/mario.jpg', FALSE);

INSERT INTO respuestas (id_respuesta, id_pregunta, respuesta, es_correcta) VALUES
(5071, 507, 'imagenes/logoxbox.jpg', TRUE),
(5072, 507, 'imagenes/logonintendo.jpg', FALSE),
(5073, 507, 'imagenes/logoplaystation.jpg', FALSE),
(5074, 507, 'imagenes/logosteam.jpg', FALSE);

INSERT INTO respuestas (id_respuesta, id_pregunta, respuesta, es_correcta) VALUES
(5081, 508, 'imagenes/consolaplay.jpg', TRUE),
(5082, 508, 'imagenes/consolaxbox.jpg', FALSE),
(5083, 508, 'imagenes/consolanintendo.jpg', FALSE),
(5084, 508, 'imagenes/consolapc.jpg', FALSE);

-- Preguntas videojuegos audio

INSERT INTO preguntas (id_pregunta, id_categoria, pregunta, tipo) VALUES
(509, 5, '¿Cuál es el audio del juego Mario Bros?', 'audio'),
(510, 5, '¿Cuál es el audio del Videojuego HALO?', 'audio'),
(511, 5, '¿Cúal es el audio del Videojuego Red Dead Redemption?', 'audio'),
(512, 5, '¿Cúal es el audio del Videojuego Stardew Valley?', 'audio');


-- Respuestas futbol audio
INSERT INTO respuestas (id_respuesta, id_pregunta, respuesta, es_correcta) VALUES
(5091, 509, 'audios/audiomariobros.wav', TRUE),
(5092, 509, 'audios/audiohalo.wav', FALSE),
(5093, 509, 'audios/audioRedDeadRedemption.wav', FALSE),
(5094, 509, 'audios/audioStardewValley.wav', FALSE);


INSERT INTO respuestas (id_respuesta, id_pregunta, respuesta, es_correcta) VALUES
(5101, 510, 'audios/audiohalo.wav', TRUE),
(5102, 510, 'audios/audiomariobros.wav', FALSE),
(5103, 510, 'audios/audioRedDeadRedemption.wav', FALSE),
(5104, 510, 'audios/audioStardewValley.wav', FALSE);


INSERT INTO respuestas (id_respuesta, id_pregunta, respuesta, es_correcta) VALUES
(5111, 511, 'audios/audioRedDeadRedemption.wav', TRUE),
(5112, 511, 'audios/audiohalo.wav', FALSE),
(5113, 511, 'audios/audiomariobros.wav', FALSE),
(5114, 511, 'audios/audioStardewValley.wav', FALSE);

INSERT INTO respuestas (id_respuesta, id_pregunta, respuesta, es_correcta) VALUES
(5121, 512, 'audios/audioStardewValley.wav', TRUE),
(5122, 512, 'audios/audioRedDeadRedemption.wav', FALSE),
(5123, 512, 'audios/audiohalo.wav', FALSE),
(5124, 512, 'audios/audiomariobros.wav', FALSE);





