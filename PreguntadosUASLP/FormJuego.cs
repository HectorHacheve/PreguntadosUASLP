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
        string connStr = "Server=127.0.0.1;Database=preguntados_uaslp;User ID=root;Password=irazema05;";
        int categoriaId;
        string categoria;
        int idPreguntaActual;
        int respuestaCorrectaId;
        string respuestaCorrectaTexto;
        int puntuacion = 0;
        int puntajeMinimoAprobar = 7;
        int preguntasRespondidas = 0;
        int preguntasFalladas = 0;
        int totalPreguntas = 12;
        List<int> preguntasUsadas = new List<int>();
        string respuestaSeleccionadaTemp = "";
        ////Variable para controlar la reproducción de audio y poder detenerlo
        System.Media.SoundPlayer reproductorActual = null;
        Image imgBoton = Properties.Resources.newBtn;
        PictureBox pb_seleccionado = null;

        public FormJuego(int categoriaRecibida)
        {
            InitializeComponent();
            categoriaId = categoriaRecibida;

            btn_audio1.Click += btn_audio_Click;
            btn_audio2.Click += btn_audio_Click;
            btn_audio3.Click += btn_audio_Click;
            btn_audio4.Click += btn_audio_Click;

            this.KeyPreview = true;
            this.KeyDown += FormJuego_KeyDown;
        }

        private void FormJuego_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(respuestaSeleccionadaTemp))
            {
                DetenerAudio();
                VerificarRespuestaSeleccionada(respuestaSeleccionadaTemp);
                respuestaSeleccionadaTemp = "";
            }
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
            string rutaBtn = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "newBtn.png");
            if (File.Exists(rutaBtn))
                imgBoton = Image.FromFile(rutaBtn);
            label_placeholder1.Tag = ObtenerNombreCategoria();
            label_placeholder1.Invalidate();
            pb_placeholder3.Invalidate();
            ActualizarNumeroPregunta();
            ImagenCategoria();
            CargarSiguientePregunta();
        }

        private void ActualizarNumeroPregunta()
        {
            label_placeholder2.Tag = "Pregunta " + (preguntasRespondidas + 1) + "/" + totalPreguntas;
            label_placeholder2.Invalidate();
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
                    string nombreDisplay = categoria.Replace("_", " ");
                    return nombreDisplay;
                }
                catch (Exception)
                {
                    return "Error";
                }
            }
        }

        private void pb_opcion_Paint(object sender, PaintEventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            if (imgBoton != null)
                g.DrawImage(imgBoton, pb.ClientRectangle);
            else
                g.FillRectangle(Brushes.Lavender, pb.ClientRectangle);

            if (pb == pb_seleccionado)
            {
                using (SolidBrush tinte = new SolidBrush(Color.FromArgb(120, Color.LightGreen)))
                    g.FillRectangle(tinte, pb.ClientRectangle);
                using (Pen borde = new Pen(Color.Green, 3))
                    g.DrawRectangle(borde, 1, 1, pb.Width - 3, pb.Height - 3);
            }

            string texto = pb.Text ?? "";
            Font fuente = new Font("Segoe UI", 14, FontStyle.Bold);
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;

            using (SolidBrush sombra = new SolidBrush(Color.FromArgb(150, Color.Black)))
            {
                RectangleF rectSombra = new RectangleF(1.5f, 1.5f, pb.Width, pb.Height);
                g.DrawString(texto, fuente, sombra, rectSombra, sf);
            }

            g.DrawString(texto, fuente, Brushes.White, pb.ClientRectangle, sf);
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
            else if (categoria == "Cine")
            {
                pictureBox_cat1.Image = Properties.Resources.film;
                pictureBox_cat1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox_cat2.Image = Properties.Resources.cinema;
                pictureBox_cat2.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else if (categoria == "Tecnologia")
            {
                pictureBox_cat1.Image = Properties.Resources.telefono;
                pictureBox_cat1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox_cat2.Image = Properties.Resources.compu;
                pictureBox_cat2.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else if (categoria == "Videojuegos")
            {
                pictureBox_cat1.Image = Properties.Resources.control;
                pictureBox_cat1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox_cat2.Image = Properties.Resources.gameboy;
                pictureBox_cat2.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else if (categoria == "Futbol")
            {
                pictureBox_cat1.Image = Properties.Resources.futbol2;
                pictureBox_cat1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox_cat2.Image = Properties.Resources.futbol;
                pictureBox_cat2.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else if (categoria == "Cultura_pop")
            {
                pictureBox_cat1.Image = Properties.Resources.hashtag;
                pictureBox_cat1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox_cat2.Image = Properties.Resources.pregunta;
                pictureBox_cat2.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
        private void FormJuego_Confirmar(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(respuestaSeleccionadaTemp))
                {
                    DetenerAudio();
                    VerificarRespuestaSeleccionada(respuestaSeleccionadaTemp);
                    respuestaSeleccionadaTemp = "";
                }
                else
                {
                    MessageBox.Show("Selecciona una respuesta primero");
                }
            }
        }
        private void pb_puntaje_Paint(object sender, PaintEventArgs e)
        {
            string texto = "Puntaje:  ✅ " + puntuacion + "  |  " + " ❌ " + preguntasFalladas;
            Font fuente = new Font("Impact", 16, FontStyle.Regular);
            StringFormat formato = new StringFormat();
            formato.Alignment = StringAlignment.Center;
            formato.LineAlignment = StringAlignment.Center;
            e.Graphics.DrawString(texto, fuente, Brushes.DarkSlateBlue,
                ((PictureBox)sender).ClientRectangle, formato);
        }

        private void label_pregunta_Paint(object sender, PaintEventArgs e)
        {
            string texto = label_pregunta.Tag?.ToString() ?? "";
            Font fuente = new Font("Segoe UI", 16F, FontStyle.Bold);
            StringFormat sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            using (SolidBrush sombra = new SolidBrush(Color.FromArgb(100, Color.Black)))
            {
                RectangleF rectSombra = new RectangleF(1.5f, 1.5f, label_pregunta.Width, label_pregunta.Height);
                e.Graphics.DrawString(texto, fuente, sombra, rectSombra, sf);
            }

            e.Graphics.DrawString(texto, fuente, Brushes.White, label_pregunta.ClientRectangle, sf);
        }

        private void label_placeholder1_Paint(object sender, PaintEventArgs e)
        {
            string texto = label_placeholder1.Tag?.ToString() ?? "";
            Font fuente = new Font("Impact", 13.8F, FontStyle.Regular);
            StringFormat sf = new StringFormat
            {
                Alignment = StringAlignment.Near,
                LineAlignment = StringAlignment.Center
            };
            e.Graphics.DrawString(texto, fuente, Brushes.WhiteSmoke,
                ((PictureBox)sender).ClientRectangle, sf);
        }

        private void label_placeholder2_Paint(object sender, PaintEventArgs e)
        {
            string texto = label_placeholder2.Tag?.ToString() ?? "";
            Font fuente = new Font("Impact", 13.8F, FontStyle.Regular);
            StringFormat sf = new StringFormat
            {
                Alignment = StringAlignment.Far,
                LineAlignment = StringAlignment.Center
            };
            e.Graphics.DrawString(texto, fuente, Brushes.WhiteSmoke,
                ((PictureBox)sender).ClientRectangle, sf);
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
                MostrarPantallaFinal();
                return;
            }

            if (preguntasUsadas.Count >= totalBD)
            {
                MessageBox.Show("Fin del juego. Puntaje: " + puntuacion + "/" + preguntasRespondidas);
                this.Close();
                return;
            }

            if (preguntasRespondidas >= totalPreguntas)
            {
                MessageBox.Show("Fin del juego. Puntaje: " + puntuacion + "/" + totalPreguntas);
                this.Close();
                return;
            }

            respuestaSeleccionadaTemp = "";

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

                        label_pregunta.Tag = reader["pregunta"] != null ? reader["pregunta"].ToString() : "";
                        label_pregunta.Invalidate();

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
                        pb_op01.Text = respuestas[0];
                        pb_op02.Text = respuestas[1];
                        pb_op03.Text = respuestas[2];
                        pb_op04.Text = respuestas[3];
                        pb_seleccionado = null;
                        pb_op01.Invalidate(); pb_op02.Invalidate();
                        pb_op03.Invalidate(); pb_op04.Invalidate();
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

                        // Limpiar selección anterior
                        pb_seleccionado = null;
                        btn_audio1.Invalidate();
                        btn_audio2.Invalidate();
                        btn_audio3.Invalidate();
                        btn_audio4.Invalidate();
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
                    Path.Combine(@"C:\Users\ira58\Git_Hub\Interfaces_Juego\PreguntadosUASLP\imagenes", Path.GetFileName(rutaImagen))
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
                    //pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
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
            pictureBox_op1.BackColor = System.Drawing.Color.Transparent;
            pictureBox_op2.BackColor = System.Drawing.Color.Transparent;
            pictureBox_op3.BackColor = System.Drawing.Color.Transparent;
            pictureBox_op4.BackColor = System.Drawing.Color.Transparent;
            btn_audio1.BackColor = System.Drawing.Color.Transparent;
            btn_audio2.BackColor = System.Drawing.Color.Transparent;
            btn_audio3.BackColor = System.Drawing.Color.Transparent;
            btn_audio4.BackColor = System.Drawing.Color.Transparent;

            pb_op01.Visible = false; 
            pb_op02.Visible = false;
            pb_op03.Visible = false; 
            pb_op04.Visible = false;
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
                pb_op01.Visible = true;
                pb_op02.Visible = true;
                pb_op03.Visible = true;
                pb_op04.Visible = true;
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

        private void MostrarPantallaFinal()
        {
            FormFinal pantallaFinal = new FormFinal(puntuacion, totalPreguntas, preguntasFalladas, puntajeMinimoAprobar);
            DialogResult resultado = pantallaFinal.ShowDialog();

            if (resultado == DialogResult.Yes)
            {
                // Reiniciar juego
                puntuacion = 0;
                preguntasRespondidas = 0;
                preguntasFalladas = 0;
                preguntasUsadas.Clear();
                respuestaSeleccionadaTemp = "";
                pb_placeholder3.Invalidate();
                CargarSiguientePregunta();
            }
            else
            {
                this.Close();
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
                preguntasFalladas++;
                MessageBox.Show("Incorrecto!");
            }

            preguntasRespondidas++;
            pb_placeholder3.Invalidate();
            CargarSiguientePregunta();
        }
        private void pb_op1_Click(object sender, EventArgs e)
        {
            respuestaSeleccionadaTemp = pb_op01.Text;
            pb_seleccionado = pb_op01;
            pb_op01.Invalidate(); pb_op02.Invalidate();
            pb_op03.Invalidate(); pb_op04.Invalidate();
            this.ActiveControl = null;
        }
        private void pb_op02_Click(object sender, EventArgs e)
        {
            respuestaSeleccionadaTemp = pb_op02.Text;
            pb_seleccionado = pb_op02;
            pb_op01.Invalidate(); pb_op02.Invalidate();
            pb_op03.Invalidate(); pb_op04.Invalidate();
            this.ActiveControl = null;
        }

        private void pb_op3_Click(object sender, EventArgs e)
        {
            respuestaSeleccionadaTemp = pb_op03.Text;
            pb_seleccionado = pb_op03;
            pb_op01.Invalidate(); pb_op02.Invalidate();
            pb_op03.Invalidate(); pb_op04.Invalidate();
            this.ActiveControl = null;
        }

        private void pb_op4_Click(object sender, EventArgs e)
        {
            respuestaSeleccionadaTemp = pb_op04.Text;
            pb_seleccionado = pb_op04;
            pb_op01.Invalidate(); pb_op02.Invalidate();
            pb_op03.Invalidate(); pb_op04.Invalidate();
            this.ActiveControl = null;
        }
        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            if (pictureBox != null && pictureBox.Tag != null)
            {
                respuestaSeleccionadaTemp = pictureBox.Tag.ToString();
                pictureBox_op1.BackColor = System.Drawing.Color.Transparent;
                pictureBox_op2.BackColor = System.Drawing.Color.Transparent;
                pictureBox_op3.BackColor = System.Drawing.Color.Transparent;
                pictureBox_op4.BackColor = System.Drawing.Color.Transparent;
                pictureBox.BackColor = System.Drawing.Color.LightGreen;
            }
            this.ActiveControl = null; // para evitar que se active al presionar Enter
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
                    Path.Combine(@"C:\Users\ira58\Git_Hub\Interfaces_Juego\PreguntadosUASLP\audios", Path.GetFileName(rutaAudio))
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
            PictureBox pb = sender as PictureBox;
            if (pb != null && pb.Tag != null)
            {
                ReproducirAudio(pb.Tag.ToString());
                respuestaSeleccionadaTemp = pb.Tag.ToString();

                // Quitar selección de todos
                btn_audio1.Text = "Audio 1";
                btn_audio2.Text = "Audio 2";
                btn_audio3.Text = "Audio 3";
                btn_audio4.Text = "Audio 4";

                // Marcar el seleccionado reutilizando pb_seleccionado
                pb_seleccionado = pb;
                btn_audio1.Invalidate();
                btn_audio2.Invalidate();
                btn_audio3.Invalidate();
                btn_audio4.Invalidate();
            }
            this.ActiveControl = null; // quitar focus para evitar que se active al presionar Enter
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