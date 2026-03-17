using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PreguntadosUASLP
{
    public partial class FormFutbol : Form
    {
        string connStr = "Server=127.0.0.1;Database=preguntados_uaslp;User ID=root;Password=tu_contraseña;";
        int idPreguntaActual;
        int respuestaCorrectaIndex;
        public FormFutbol()
        {
            
            InitializeComponent();
            CargarPregunta();
            
        }

        void CargarPregunta()
        {
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();

                string query = "SELECT * FROM preguntas WHERE id_categoria = 6 ORDER BY RAND() LIMIT 1";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    idPreguntaActual = Convert.ToInt32(reader["id_pregunta"]);
                    labelpregFutbol.Text = reader["pregunta"].ToString();
                }

                reader.Close();
                conn.Close();

                CargarRespuestas();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        void CargarRespuestas()
        {
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();

                string query = "SELECT * FROM respuestas WHERE id_pregunta = @id";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", idPreguntaActual);

                MySqlDataReader reader = cmd.ExecuteReader();

                List<string> opciones = new List<string>();
                int index = 0;

                while (reader.Read())
                {
                    opciones.Add(reader["respuesta"].ToString());

                    if (Convert.ToBoolean(reader["es_correcta"]))
                    {
                        respuestaCorrectaIndex = index;
                    }

                    index++;
                }

                reader.Close();
                conn.Close();

                botonOp1.Text = opciones[0];
                button2.Text = opciones[1];
                botonOp3.Text = opciones[2];
                botonOp4.Text = opciones[3];
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VerificarRespuesta(1);

        }

        private void labelpregFutbol_Click(object sender, EventArgs e)
        {

        }

        private void botonOp1_Click(object sender, EventArgs e)
        {
            VerificarRespuesta(0);

        }

        private void botonOp3_Click(object sender, EventArgs e)
        {
            VerificarRespuesta(2);

        }

        private void botonOp4_Click(object sender, EventArgs e)
        {
            VerificarRespuesta(3);

        }

        void VerificarRespuesta(int seleccion)
        {
            if (seleccion == respuestaCorrectaIndex)
            {
                MessageBox.Show("Correcto");
            }
            else
            {
                MessageBox.Show("Incorrecto");
            }
            CargarPregunta();
        }
    }
}
