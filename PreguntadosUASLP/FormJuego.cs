#nullable disable
using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PreguntadosUASLP
{
    public partial class FormJuego : Form
    {
        string connStr = "Server=127.0.0.1;Database=preguntados_uaslp;User ID=root;Password=Wilmington2017!;";
        int categoriaId;
        string categoria;
        int idPreguntaActual;
        int respuestaCorrectaId;
        string respuestaCorrectaTexto;
        int puntuacion = 0;
        int preguntasRespondidas = 0;
        int totalPreguntas = 12;
        List<int> preguntasUsadas = new List<int>();
        string respuestaSeleccionadaTemp = "";
        Button botonConfirmar;
        ////Variable para controlar la reproducción de audio y poder detenerlo
        System.Media.SoundPlayer reproductorActual = null;

        public FormJuego(int categoriaRecibida)
        {
            InitializeComponent();
            categoriaId = categoriaRecibida;

            label01.Click += label01_Click;
            label02.Click += label02_Click;
            label03.Click += label03_Click;
            label04.Click += label04_Click;

            btn_audio1.Click += btn_audio_Click;
            btn_audio2.Click += btn_audio_Click;
            btn_audio3.Click += btn_audio_Click;
            btn_audio4.Click += btn_audio_Click;

            label_pregunta.AutoSize = false;
            label_pregunta.Size = new System.Drawing.Size(901, 108);
            label_pregunta.TextAlign = ContentAlignment.MiddleCenter;
            label_pregunta.Location = new System.Drawing.Point(134, 115);

            //Crear boton de confirmar y ajustar posición más abajo
            botonConfirmar = new Button();
            botonConfirmar.Text = "Confirmar respuesta";
            botonConfirmar.Size = new System.Drawing.Size(300, 50);
            botonConfirmar.Location = new System.Drawing.Point(100, 800); // Posición más abajo
            botonConfirmar.BackColor = System.Drawing.Color.Gold;
            botonConfirmar.Font = new System.Drawing.Font("Arial", 12, FontStyle.Bold);
            botonConfirmar.Click += BotonConfirmar_Click;
            botonConfirmar.Enabled = false;
            botonConfirmar.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(botonConfirmar);
            botonConfirmar.BringToFront();
        }

        //Detener audio al cerrar el formulario
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            DetenerAudio();
            base.OnFormClosing(e);
        }

        //Método para detener el audio actual
        private void DetenerAudio()
        {
            if (reproductorActual != null)
            {
                reproductorActual.Stop();
                reproductorActual.Dispose();
                reproductorActual = null;
            }
        }

        private void FormJuego_Load(object sender, EventArgs e)
        {
            label_placeholder1.Text = ObtenerNombreCategoria();
            label_placeholder3.Text = "Puntaje: 0";
            ActualizarNumeroPregunta();
            ImagenCategoria();
            CargarSiguientePregunta();
        }

        private void ActualizarNumeroPregunta()
        {
            label_placeholder2.Text = "Pregunta " + (preguntasRespondidas + 1) + "/" + totalPreguntas;
        }

        private string ObtenerNombreCategoria()
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT nombre FROM categorias WHERE id_categoria = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", categoriaId);
                    object resultado = cmd.ExecuteScalar();
                    categoria = resultado != null ? resultado.ToString() : "Sin categoría";
                    return categoria;
                }
                catch (Exception)
                {
                    return "Error";
                }
            }
        }

        private void ImagenCategoria()
        {
            if (categoria == "UASLP")
            {
                pictureBox_cat1.Image = Properties.Resources.uni;
                pictureBox_cat1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox_cat2.Image = Properties.Resources.certificado;
                pictureBox_cat2.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else if (categoria == "Redes Sociales")
            {
                pictureBox_cat1.Image = Properties.Resources.mensajes;
                pictureBox_cat1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox_cat2.Image = Properties.Resources.celular;
                pictureBox_cat2.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private int ObtenerTotalPreguntasBD()
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM preguntas WHERE id_categoria = @cat";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@cat", categoriaId);
                object resultado = cmd.ExecuteScalar();
                return resultado != null ? Convert.ToInt32(resultado) : 0;
            }
        }

        private void CargarSiguientePregunta()
        {
            //Detener audio al cambiar de pregunta
            DetenerAudio();

            int totalBD = ObtenerTotalPreguntasBD();

            if (totalBD == 0)
            {
                MessageBox.Show("No hay preguntas en esta categoría");
                this.Close();
                return;
            }

            if (preguntasRespondidas >= totalPreguntas)
            {
                MessageBox.Show("Fin del juego. Puntaje: " + puntuacion + "/" + totalPreguntas);
                this.Close();
                return;
            }

            if (preguntasUsadas.Count >= totalBD)
            {
                MessageBox.Show("Fin del juego. Puntaje: " + puntuacion + "/" + preguntasRespondidas);
                this.Close();
                return;
            }

            respuestaSeleccionadaTemp = "";
            botonConfirmar.Enabled = false;
            botonConfirmar.BackColor = System.Drawing.Color.Gray;

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT id_pregunta, pregunta, tipo FROM preguntas WHERE id_categoria = @cat";

                    if (preguntasUsadas.Count > 0)
                    {
                        string idsUsados = string.Join(",", preguntasUsadas);
                        query += " AND id_pregunta NOT IN (" + idsUsados + ")";
                    }

                    query += " ORDER BY RAND() LIMIT 1";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@cat", categoriaId);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        idPreguntaActual = Convert.ToInt32(reader["id_pregunta"]);
                        preguntasUsadas.Add(idPreguntaActual);

                        label_pregunta.Text = reader["pregunta"] != null ? reader["pregunta"].ToString() : "";
                        string tipoPregunta = reader["tipo"] != null ? reader["tipo"].ToString() : "texto";

                        reader.Close();

                        CargarRespuestas(conn, tipoPregunta);
                        MostrarTipoPregunta(tipoPregunta);
                        ActualizarNumeroPregunta();
                    }
                    else
                    {
                        MessageBox.Show("No hay más preguntas disponibles");
                        this.Close();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error BD: " + ex.Message);
                }
            }
        }

        private void CargarRespuestas(MySqlConnection conn, string tipoPregunta)
        {
            try
            {
                string query = "SELECT id_respuesta, respuesta, es_correcta FROM respuestas WHERE id_pregunta = @idPregunta";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idPregunta", idPreguntaActual);

                MySqlDataReader reader = cmd.ExecuteReader();

                List<string> respuestas = new List<string>();

                while (reader.Read())
                {
                    string respuesta = reader["respuesta"] != null ? reader["respuesta"].ToString() : "";
                    respuestas.Add(respuesta);

                    if (Convert.ToBoolean(reader["es_correcta"]))
                    {
                        respuestaCorrectaId = Convert.ToInt32(reader["id_respuesta"]);
                        respuestaCorrectaTexto = respuesta;
                    }
                }

                reader.Close();

                if (respuestas.Count >= 4)
                {
                    if (tipoPregunta == "imagen")
                    {
                        pictureBox_op1.Click -= pictureBox_Click;
                        pictureBox_op2.Click -= pictureBox_Click;
                        pictureBox_op3.Click -= pictureBox_Click;
                        pictureBox_op4.Click -= pictureBox_Click;

                        CargarImagenRespuesta(pictureBox_op1, respuestas[0]);
                        CargarImagenRespuesta(pictureBox_op2, respuestas[1]);
                        CargarImagenRespuesta(pictureBox_op3, respuestas[2]);
                        CargarImagenRespuesta(pictureBox_op4, respuestas[3]);

                        pictureBox_op1.Tag = respuestas[0];
                        pictureBox_op2.Tag = respuestas[1];
                        pictureBox_op3.Tag = respuestas[2];
                        pictureBox_op4.Tag = respuestas[3];

                        pictureBox_op1.Click += pictureBox_Click;
                        pictureBox_op2.Click += pictureBox_Click;
                        pictureBox_op3.Click += pictureBox_Click;
                        pictureBox_op4.Click += pictureBox_Click;
                    }
                    else if (tipoPregunta == "texto")
                    {
                        label01.Text = respuestas[0];
                        label02.Text = respuestas[1];
                        label03.Text = respuestas[2];
                        label04.Text = respuestas[3];

                        label01.AutoSize = false;
                        label01.Size = new System.Drawing.Size(351, 141);
                        label01.TextAlign = ContentAlignment.MiddleCenter;

                        label02.AutoSize = false;
                        label02.Size = new System.Drawing.Size(351, 141);
                        label02.TextAlign = ContentAlignment.MiddleCenter;

                        label03.AutoSize = false;
                        label03.Size = new System.Drawing.Size(351, 141);
                        label03.TextAlign = ContentAlignment.MiddleCenter;

                        label04.AutoSize = false;
                        label04.Size = new System.Drawing.Size(351, 141);
                        label04.TextAlign = ContentAlignment.MiddleCenter;
                    }
                    else if (tipoPregunta == "audio")
                    {
                        btn_audio1.Tag = respuestas[0];
                        btn_audio2.Tag = respuestas[1];
                        btn_audio3.Tag = respuestas[2];
                        btn_audio4.Tag = respuestas[3];

                        btn_audio1.Text = "Audio 1";
                        btn_audio2.Text = "Audio 2";
                        btn_audio3.Text = "Audio 3";
                        btn_audio4.Text = "Audio 4";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error respuestas: " + ex.Message);
            }
        }

        private void CargarImagenRespuesta(PictureBox pictureBox, string rutaImagen)
        {
            try
            {
                string rutaCompleta = "";
                string[] posiblesRutas = {
                    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, rutaImagen),
                    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "imagenes", Path.GetFileName(rutaImagen)),
                    Path.Combine(Directory.GetCurrentDirectory(), rutaImagen),
                    Path.Combine(Directory.GetCurrentDirectory(), "imagenes", Path.GetFileName(rutaImagen)),
                    Path.Combine(@"C:\Users\nieto\PreguntadosUASLP\Imagenes", Path.GetFileName(rutaImagen))
                };

                foreach (string ruta in posiblesRutas)
                {
                    if (File.Exists(ruta))
                    {
                        rutaCompleta = ruta;
                        break;
                    }
                }

                if (File.Exists(rutaCompleta))
                {
                    pictureBox.Image = Image.FromFile(rutaCompleta);
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    pictureBox.Image = null;
                }
            }
            catch
            {
                pictureBox.Image = null;
            }
        }

        private void MostrarTipoPregunta(string tipo)
        {
            label01.BackColor = System.Drawing.Color.Lavender;
            label02.BackColor = System.Drawing.Color.Lavender;
            label03.BackColor = System.Drawing.Color.Lavender;
            label04.BackColor = System.Drawing.Color.Lavender;
            pictureBox_op1.BackColor = System.Drawing.Color.Transparent;
            pictureBox_op2.BackColor = System.Drawing.Color.Transparent;
            pictureBox_op3.BackColor = System.Drawing.Color.Transparent;
            pictureBox_op4.BackColor = System.Drawing.Color.Transparent;
            btn_audio1.BackColor = System.Drawing.SystemColors.Control;
            btn_audio2.BackColor = System.Drawing.SystemColors.Control;
            btn_audio3.BackColor = System.Drawing.SystemColors.Control;
            btn_audio4.BackColor = System.Drawing.SystemColors.Control;

            label01.Visible = false;
            label02.Visible = false;
            label03.Visible = false;
            label04.Visible = false;
            btn_audio1.Visible = false;
            btn_audio2.Visible = false;
            btn_audio3.Visible = false;
            btn_audio4.Visible = false;
            pictureBox_op1.Visible = false;
            pictureBox_op2.Visible = false;
            pictureBox_op3.Visible = false;
            pictureBox_op4.Visible = false;

            if (tipo == "texto")
            {
                label01.Visible = true;
                label02.Visible = true;
                label03.Visible = true;
                label04.Visible = true;
            }
            else if (tipo == "imagen")
            {
                pictureBox_op1.Visible = true;
                pictureBox_op2.Visible = true;
                pictureBox_op3.Visible = true;
                pictureBox_op4.Visible = true;
            }
            else if (tipo == "audio")
            {
                btn_audio1.Visible = true;
                btn_audio2.Visible = true;
                btn_audio3.Visible = true;
                btn_audio4.Visible = true;
            }
        }

        private void VerificarRespuestaSeleccionada(string respuestaSeleccionada)
        {
            if (respuestaSeleccionada == respuestaCorrectaTexto)
            {
                puntuacion++;
                MessageBox.Show("Correcto!");
            }
            else
            {
                MessageBox.Show("Incorrecto!");
            }

            preguntasRespondidas++;
            label_placeholder3.Text = "Puntaje: " + puntuacion;
            CargarSiguientePregunta();
        }

        private void BotonConfirmar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(respuestaSeleccionadaTemp))
            {
                //Detener audio al confirmar respuesta
                DetenerAudio();
                VerificarRespuestaSeleccionada(respuestaSeleccionadaTemp);
                respuestaSeleccionadaTemp = "";
                botonConfirmar.Enabled = false;
                botonConfirmar.BackColor = System.Drawing.Color.Gray;
            }
            else
            {
                MessageBox.Show("Selecciona una respuesta primero");
            }
        }

        private void label01_Click(object sender, EventArgs e)
        {
            respuestaSeleccionadaTemp = label01.Text;
            botonConfirmar.Enabled = true;
            botonConfirmar.BackColor = System.Drawing.Color.Green;
            label01.BackColor = System.Drawing.Color.LightGreen;
            label02.BackColor = System.Drawing.Color.Lavender;
            label03.BackColor = System.Drawing.Color.Lavender;
            label04.BackColor = System.Drawing.Color.Lavender;
        }

        private void label02_Click(object sender, EventArgs e)
        {
            respuestaSeleccionadaTemp = label02.Text;
            botonConfirmar.Enabled = true;
            botonConfirmar.BackColor = System.Drawing.Color.Green;
            label01.BackColor = System.Drawing.Color.Lavender;
            label02.BackColor = System.Drawing.Color.LightGreen;
            label03.BackColor = System.Drawing.Color.Lavender;
            label04.BackColor = System.Drawing.Color.Lavender;
        }

        private void label03_Click(object sender, EventArgs e)
        {
            respuestaSeleccionadaTemp = label03.Text;
            botonConfirmar.Enabled = true;
            botonConfirmar.BackColor = System.Drawing.Color.Green;
            label01.BackColor = System.Drawing.Color.Lavender;
            label02.BackColor = System.Drawing.Color.Lavender;
            label03.BackColor = System.Drawing.Color.LightGreen;
            label04.BackColor = System.Drawing.Color.Lavender;
        }

        private void label04_Click(object sender, EventArgs e)
        {
            respuestaSeleccionadaTemp = label04.Text;
            botonConfirmar.Enabled = true;
            botonConfirmar.BackColor = System.Drawing.Color.Green;
            label01.BackColor = System.Drawing.Color.Lavender;
            label02.BackColor = System.Drawing.Color.Lavender;
            label03.BackColor = System.Drawing.Color.Lavender;
            label04.BackColor = System.Drawing.Color.LightGreen;
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            if (pictureBox != null && pictureBox.Tag != null)
            {
                respuestaSeleccionadaTemp = pictureBox.Tag.ToString();
                botonConfirmar.Enabled = true;
                botonConfirmar.BackColor = System.Drawing.Color.Green;
                pictureBox_op1.BackColor = System.Drawing.Color.Transparent;
                pictureBox_op2.BackColor = System.Drawing.Color.Transparent;
                pictureBox_op3.BackColor = System.Drawing.Color.Transparent;
                pictureBox_op4.BackColor = System.Drawing.Color.Transparent;
                pictureBox.BackColor = System.Drawing.Color.LightGreen;
            }
        }

        //Método para reproducir audio usando SoundPlayer con WAV
        private void ReproducirAudio(string rutaAudio)
        {
            try
            {
                // Detener audio anterior si existe
                DetenerAudio();

                string rutaCompleta = "";
                string[] posiblesRutas = {
                    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, rutaAudio),
                    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "audios", Path.GetFileName(rutaAudio)),
                    Path.Combine(@"C:\Users\nieto\PreguntadosUASLP\Audios", Path.GetFileName(rutaAudio))
                };

                foreach (string ruta in posiblesRutas)
                {
                    if (File.Exists(ruta))
                    {
                        rutaCompleta = ruta;
                        break;
                    }
                }

                if (File.Exists(rutaCompleta))
                {
                    reproductorActual = new System.Media.SoundPlayer(rutaCompleta);
                    reproductorActual.Play();
                }
                else
                {
                    MessageBox.Show("No se encuentra el audio: " + rutaAudio);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al reproducir audio: " + ex.Message);
            }
        }

        private void btn_audio_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null && button.Tag != null)
            {
                ReproducirAudio(button.Tag.ToString());
                respuestaSeleccionadaTemp = button.Tag.ToString();
                botonConfirmar.Enabled = true;
                botonConfirmar.BackColor = System.Drawing.Color.Green;
                btn_audio1.BackColor = System.Drawing.SystemColors.Control;
                btn_audio2.BackColor = System.Drawing.SystemColors.Control;
                btn_audio3.BackColor = System.Drawing.SystemColors.Control;
                btn_audio4.BackColor = System.Drawing.SystemColors.Control;
                button.BackColor = System.Drawing.Color.LightGreen;
            }
        }

        private void label01_Click_1(object sender, EventArgs e)
        {

        }

        private void label_pregunta_Click(object sender, EventArgs e)
        {

        }

        private void label_placeholder3_Click(object sender, EventArgs e)
        {

        }

        private void btn_audio4_Click(object sender, EventArgs e)
        {

        }
    }
}