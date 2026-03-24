
USE preguntados_uaslp;


--  Preguntas cultura pop Texto

INSERT INTO preguntas (id_pregunta, id_categoria, pregunta, tipo) VALUES
(701, 7, '¿Qué marca de mayonesa anunció por error Pedrito Sola en un programa en vivo en lugar de Helmans', 'texto'),
(702, 7, '¿Quiénes son las protagonistas del icónico video viral en el que gritan "¡Estamos perdidas, perdidas, perdidas!" en un cerro?', 'texto'),
(703, 7, '¿Qué apodo recibe el fallecido cantante Valentín Elizalde?', 'texto'),
(704, 7, '¿Cómo se les llama popularmente en México a las pequeñas figuras de animales aterciopelados (Sylvanian Families)?', 'texto');

-- Respuestas cultura pop Texto 

INSERT INTO respuestas (id_respuesta, id_pregunta, respuesta, es_correcta) VALUES
(7011, 701, 'La costeña', FALSE),
(7012, 701, 'Heinz', FALSE),
(7013, 701, 'McCormick', TRUE),
(7014, 701, 'Kraft', FALSE);

INSERT INTO respuestas (id_respuesta, id_pregunta, respuesta, es_correcta) VALUES
(7021, 702, 'Las lavanderas', FALSE),
(7022, 702, 'Wendy Guevara y Paola Suarez', TRUE),
(7023, 702, 'Yeri mua y Kenia OS', FALSE),
(7024, 702, 'Las horoscopos de Durango', FALSE);

INSERT INTO respuestas (id_respuesta, id_pregunta, respuesta, es_correcta) VALUES
(7031, 703, 'El gallo de oro', TRUE),
(7032, 703, 'El rey del morbo', FALSE),
(7033, 703, 'El jefe de jefes', FALSE),
(7034, 703, 'El booo', FALSE);

INSERT INTO respuestas (id_respuesta, id_pregunta, respuesta, es_correcta) VALUES
(7041, 704, 'Kasimeritos', FALSE),
(7042, 704, 'Pokemon', FALSE),
(7043, 704, 'Ternurines', TRUE),
(7044, 704, 'Funkos', FALSE);

-- Preguntas cultura pop Imagen 

INSERT INTO preguntas (id_pregunta, id_categoria, pregunta, tipo) VALUES
(705, 7, '¿Cuál de estos personajes virales es el bailarín conocido en internet como "Medio Metro"?', 'imagen'),
(706, 7, '¿Cuál de estos personajes virales es el luchador conocido en internet como "Kemonito"?', 'imagen'),
(707, 7, '¿Cuál de estos perritos se convirtió en una leyenda absoluta de los memes en México bajo el nombre de "unos pedillos"?', 'imagen'),
(708, 7, '¿Quién es el autor de la icónica frase “Te voy a ser sincero baki”?', 'imagen');


INSERT INTO respuestas (id_respuesta, id_pregunta, respuesta, es_correcta) VALUES
(7051, 705, 'imagenes/bailarin1.png', FALSE),
(7052, 705, 'imagenes/bailarin2.png', FALSE),
(7053, 705, 'imagenes/mmetro.jpg', TRUE),
(7054, 705, 'imagenes/chavo.png', FALSE);

INSERT INTO respuestas (id_respuesta, id_pregunta, respuesta, es_correcta) VALUES
(7061, 706, 'imagenes/santo.jpg', FALSE),
(7062, 706, 'imagenes/alushe.jpg', FALSE),
(7063, 706, 'imagenes/kemalito.jpg', FALSE),
(7064, 706, 'imagenes/kemonito.jpg', TRUE);

INSERT INTO respuestas (id_respuesta, id_pregunta, respuesta, es_correcta) VALUES
(7071, 707, 'imagenes/pedillos.jpg', TRUE),
(7072, 707, 'imagenes/amigos.jpg', FALSE),
(7073, 707, 'imagenes/chilaquil.jpg', FALSE),
(7074, 707, 'imagenes/cheems.jpg', FALSE);

INSERT INTO respuestas (id_respuesta, id_pregunta, respuesta, es_correcta) VALUES
(7081, 708, 'imagenes/baki.jpg', FALSE),
(7082, 708, 'imagenes/oliva.jpg', TRUE),
(7083, 708, 'imagenes/hanma.jpg', FALSE),
(7084, 708, 'imagenes/sagat.jpg', FALSE);

-- Preguntas videojuegos audio

INSERT INTO preguntas (id_pregunta, id_categoria, pregunta, tipo) VALUES
(709, 7, '¿Cual es el iconico sonido de el carrito de los camotes?', 'audio'),
(710, 7, '¿Cual es el iconico sonido del camion de la basura?', 'audio'),
(711, 7, '¿Cual es el iconico sonido de los compradores de fierro viejo?', 'audio'),
(712, 7, '¿Cual es el iconico sonido de los panaderos en automoviles?', 'audio');


-- Respuestas futbol audio
INSERT INTO respuestas (id_respuesta, id_pregunta, respuesta, es_correcta) VALUES
(7091, 709, 'audios/camotero.wav', TRUE),
(7092, 709, 'audios/panadero.wav', FALSE),
(7093, 709, 'audios/fierro.wav', FALSE),
(7094, 709, 'audios/basura.wav', FALSE);


INSERT INTO respuestas (id_respuesta, id_pregunta, respuesta, es_correcta) VALUES
(7101, 710, 'audios/camotero.wav', FALSE),
(7102, 710, 'audios/fierro.wav', FALSE),
(7103, 710, 'audios/basura.wav', TRUE),
(7104, 710, 'audios/panadero.wav', FALSE);


INSERT INTO respuestas (id_respuesta, id_pregunta, respuesta, es_correcta) VALUES
(7111, 711, 'audios/fierro.wav', TRUE),
(7112, 711, 'audios/basura.wav', FALSE),
(7113, 711, 'audios/panadero.wav', FALSE),
(7114, 711, 'audios/camotero.wav', FALSE);

INSERT INTO respuestas (id_respuesta, id_pregunta, respuesta, es_correcta) VALUES
(7121, 712, 'audios/basura.wav', FALSE),
(7122, 712, 'audios/panadero.wav', TRUE),
(7123, 712, 'audios/camotero.wav', FALSE),
(7124, 712, 'audios/fierro.wav', FALSE);