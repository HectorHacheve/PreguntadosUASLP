[33mcommit b6fe19d8c152ad4247062083b83b48b1dd790101[m[33m ([m[1;31morigin/ira-avances[m[33m)[m
Author: gali-galii <nietogalilea22@gmail.com>
Date:   Mon Mar 23 09:11:49 2026 -0600

    se agregaron las preguntas de la categoria UASLP

[1mdiff --git a/preguntas_catUaslp.sql b/preguntas_catUaslp.sql[m
[1mnew file mode 100644[m
[1mindex 0000000..2291bfd[m
[1m--- /dev/null[m
[1m+++ b/preguntas_catUaslp.sql[m
[36m@@ -0,0 +1,76 @@[m
[32m+[m[32mUSE preguntados_uaslp;[m
[32m+[m
[32m+[m[32mINSERT INTO preguntas VALUES[m
[32m+[m[32m(101,1,'¿Cuándo se fundó la UASLP?','texto'),[m
[32m+[m[32m(102,1,'¿Quién es el rector actual de la UASLP?','texto'),[m
[32m+[m[32m(103,1,'¿Cuál es el campus principal de la UASLP?','texto'),[m
[32m+[m[32m(104,1,'¿Cuántas facultades hay en la Zona Universitaria de la UASLP?','texto'),[m
[32m+[m[32m(105,1,'¿Cuál es el Edificio Central de la UASLP?','imagen'),[m
[32m+[m[32m(106,1,'¿Cuál es el escudo oficial de la UASLP?','imagen'),[m
[32m+[m[32m(107,1,'¿Cuál es la mascota de la UASLP?','imagen'),[m
[32m+[m[32m(108,1,'¿Quién fue el primer doctor en Ciencias de la Computación egresado de la UASLP?','imagen'),[m
[32m+[m[32m(109,1,'¿Cuál de estos es el himno de la UASLP?','audio'),[m
[32m+[m[32m(110,1,'¿Qué canción suena en el video "Lo que somos" del canal de YouTube de la UASLP?','audio'),[m
[32m+[m[32m(111,1,'¿Cuál de los siguientes audios corresponde al video de Ingeniería en Computación?','audio'),[m
[32m+[m[32m(112,1,'¿Qué sonido hace la mascota de la UASLP?','audio');[m
[32m+[m
[32m+[m[32mINSERT INTO respuestas VALUES[m
[32m+[m[32m(1011,101,'1922',FALSE),[m
[32m+[m[32m(1012,101,'1925',FALSE),[m
[32m+[m[32m(1013,101,'1923',TRUE),[m
[32m+[m[32m(1014,101,'1933',FALSE),[m
[32m+[m
[32m+[m[32m(1021,102,'Alejandro Zermeño Guerra',TRUE),[m
[32m+[m[32m(1022,102,'Juan H. Sánchez',FALSE),[m
[32m+[m[32m(1023,102,'Jesús García Lozano',FALSE),[m
[32m+[m[32m(1024,102,'Manuel Fermín Vilar Rubio',FALSE),[m
[32m+[m
[32m+[m[32m(1031,103,'Zona Centro',FALSE),[m
[32m+[m[32m(1032,103,'Zona Oriente',FALSE),[m
[32m+[m[32m(1033,103,'Zona Huasteca',FALSE),[m
[32m+[m[32m(1034,103,'Zona Universitaria',TRUE),[m
[32m+[m
[32m+[m[32m(1041,104,'8',FALSE),[m
[32m+[m[32m(1042,104,'4',FALSE),[m
[32m+[m[32m(1043,104,'7',FALSE),[m
[32m+[m[32m(1044,104,'6',TRUE),[m
[32m+[m
[32m+[m[32m(1051,105,'imagenes/fac_ing.jpg',FALSE),[m
[32m+[m[32m(1052,105,'imagenes/fac_der.jpg',FALSE),[m
[32m+[m[32m(1053,105,'imagenes/edificio_central.jpg',TRUE),[m
[32m+[m[32m(1054,105,'imagenes/bicentenario.jpg',FALSE),[m
[32m+[m
[32m+[m[32m(1061,106,'imagenes/logo_unam.jpg',FALSE),[m
[32m+[m[32m(1062,106,'imagenes/logo_uaslp.jpg',TRUE),[m
[32m+[m[32m(1063,106,'imagenes/logo_nayarit.jpg',FALSE),[m
[32m+[m[32m(1064,106,'imagenes/logo_nuevoleon.jpg',FALSE),[m
[32m+[m
[32m+[m[32m(1071,107,'imagenes/aguila.jpg',TRUE),[m
[32m+[m[32m(1072,107,'imagenes/jaguar.jpg',FALSE),[m
[32m+[m[32m(1073,107,'imagenes/lobo.jpg',FALSE),[m
[32m+[m[32m(1074,107,'imagenes/cat.jpg',FALSE),[m
[32m+[m
[32m+[m[32m(1081,108,'imagenes/el_mejor_profe.jpg',TRUE),[m
[32m+[m[32m(1082,108,'imagenes/equipo.png',FALSE),[m
[32m+[m[32m(1083,108,'imagenes/prof_hector.jpg',FALSE),[m
[32m+[m[32m(1084,108,'imagenes/prof.jpg',FALSE),[m
[32m+[m
[32m+[m[32m(1091,109,'audios/himno_unam.wav',FALSE),[m
[32m+[m[32m(1092,109,'audios/himno_nacional.wav',FALSE),[m
[32m+[m[32m(1093,109,'audios/himno_uaslp.wav',TRUE),[m
[32m+[m[32m(1094,109,'audios/himno_uaz.wav',FALSE),[m
[32m+[m
[32m+[m[32m(1101,110,'audios/loquesomos.wav',TRUE),[m
[32m+[m[32m(1102,110,'audios/opcionb.wav',FALSE),[m
[32m+[m[32m(1103,110,'audios/opcionc.wav',FALSE),[m
[32m+[m[32m(1104,110,'audios/opciond.wav',FALSE),[m
[32m+[m
[32m+[m[32m(1111,111,'audios/geologia.wav',FALSE),[m
[32m+[m[32m(1112,111,'audios/computacion.wav',TRUE),[m
[32m+[m[32m(1113,111,'audios/mecanica.wav',FALSE),[m
[32m+[m[32m(1114,111,'audios/sistemas.wav',FALSE),[m
[32m+[m
[32m+[m[32m(1121,112,'audios/jaguar.wav',FALSE),[m
[32m+[m[32m(1122,112,'audios/leon.wav',FALSE),[m
[32m+[m[32m(1123,112,'audios/aguila.wav',TRUE),[m
[32m+[m[32m(1124,112,'audios/gato.wav',FALSE);[m
