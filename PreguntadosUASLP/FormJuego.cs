using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PreguntadosUASLP
{
    public partial class FormJuego : Form
    {
        string connStr = "Server=127.0.0.1;Database=preguntados_uaslp;User ID=root;Password=Tu_Contraseña;";
        int categoriaId;
        string? categoria;
        int idPreguntaActual;
        int respuestaCorrectaId;
        string? respuestaCorrectaTexto;
        int puntuacion = 0;
        int preguntasRespondidas = 0;
        int totalPreguntas = 5;

        public FormJuego(int categoriaRecibida)
        {
            InitializeComponent();
            categoriaId = categoriaRecibida;

            label01.Click += label01_Click;
            label02.Click += label02_Click;
            label03.Click += label03_Click;
            label04.Click += label04_Click;

            CargarSiguientePregunta();
        }

        private void FormJuego_Load(object sender, EventArgs e)
        {
            label_placeholder1.Text = ObtenerNombreCategoria();
            label_placeholder3.Text = "Puntaje: 0";
            label_placeholder4.Text = "Pregunta 1/5";
            ImagenCategoria();
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

        private bool HayPreguntasDisponibles()
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM preguntas WHERE id_categoria = @cat";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@cat", categoriaId);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        private void CargarSiguientePregunta()
        {
            if (!HayPreguntasDisponibles())
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

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT id_pregunta, pregunta, tipo FROM preguntas WHERE id_categoria = @cat ORDER BY RAND() LIMIT 1";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@cat", categoriaId);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        idPreguntaActual = Convert.ToInt32(reader["id_pregunta"]);
                        label_pregunta.Text = reader["pregunta"].ToString();
                        string tipoPregunta = reader["tipo"] != null ? reader["tipo"].ToString() : "texto";

                        reader.Close();

                        CargarRespuestas(conn);
                        MostrarTipoPregunta(tipoPregunta);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error BD: " + ex.Message);
                }
            }
        }

        private void CargarRespuestas(MySqlConnection conn)
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
                    label01.Text = respuestas[0];
                    label02.Text = respuestas[1];
                    label03.Text = respuestas[2];
                    label04.Text = respuestas[3];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error respuestas: " + ex.Message);
            }
        }

        private void MostrarTipoPregunta(string tipo)
        {
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
                MessageBox.Show("Incorrecto. Era: " + (respuestaCorrectaTexto ?? ""));
            }

            preguntasRespondidas++;
            label_placeholder3.Text = "Puntaje: " + puntuacion;
            CargarSiguientePregunta();
        }

        private void label01_Click(object? sender, EventArgs e)
        {
            VerificarRespuestaSeleccionada(label01.Text);
        }

        private void label02_Click(object? sender, EventArgs e)
        {
            VerificarRespuestaSeleccionada(label02.Text);
        }

        private void label03_Click(object? sender, EventArgs e)
        {
            VerificarRespuestaSeleccionada(label03.Text);
        }

        private void label04_Click(object? sender, EventArgs e)
        {
            VerificarRespuestaSeleccionada(label04.Text);
        }
    }
}