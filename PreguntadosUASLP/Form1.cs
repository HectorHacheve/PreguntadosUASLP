using System;
using System.Drawing;
using System.Windows.Forms;

namespace PreguntadosUASLP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Cultura_pop_Paint(object sender, PaintEventArgs e)
        {
            PictureBox botonActual = (PictureBox)sender;
            string textoBoton = "";
            if (botonActual.Tag != null)
            {
                textoBoton = botonActual.Tag.ToString();
            }

            Font miFuente = new Font("Arial", 14, FontStyle.Bold);
            StringFormat formatoCentrado = new StringFormat();
            formatoCentrado.Alignment = StringAlignment.Center;
            formatoCentrado.LineAlignment = StringAlignment.Center;

            e.Graphics.DrawString(textoBoton, miFuente, Brushes.White, botonActual.ClientRectangle, formatoCentrado);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Futbol_Click(object sender, EventArgs e)
        {
            FormJuego juego = new FormJuego(6);
            juego.ShowDialog();
        }

        private void Cultura_pop_Click(object sender, EventArgs e)
        {
            FormJuego juego = new FormJuego(7);
            juego.ShowDialog();
        }

        private void Cine_Click(object sender, EventArgs e)
        {
            FormJuego juego = new FormJuego(3);
            juego.ShowDialog();
        }

        private void Tecnologia_Click(object sender, EventArgs e)
        {
            FormJuego juego = new FormJuego(4);
            juego.ShowDialog();
        }

        private void UASLP_Click(object sender, EventArgs e)
        {
            FormJuego juego = new FormJuego(1);
            juego.ShowDialog();
        }

        private void Redes_Sociales_Click(object sender, EventArgs e)
        {
            FormJuego juego = new FormJuego(2);
            juego.ShowDialog();
        }

        private void Videojuegos_Click(object sender, EventArgs e)
        {
            FormJuego juego = new FormJuego(5);
            juego.ShowDialog();
        }

    }
}