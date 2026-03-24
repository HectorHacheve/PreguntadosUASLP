using System;
using System.Drawing;
using System.Windows.Forms;

namespace PreguntadosUASLP
{
    public partial class FormFinal : Form
    {
        public FormFinal(int puntuacion, int totalPreguntas, int preguntasFalladas, int puntajeMinimo)
        {
            InitializeComponent();
            ConfigurarFormulario(puntuacion, totalPreguntas, preguntasFalladas, puntajeMinimo);

            this.KeyPreview = true;
            this.KeyDown += FormFinal_KeyDown;

            // Si tienes pictureBox1 que debe cerrar al hacer clic
            if (pictureBox1 != null)
            {
                pictureBox1.Click += (s, e) => { this.DialogResult = DialogResult.No; this.Close(); };
            }
        }

        private void ConfigurarFormulario(int puntuacion, int totalPreguntas, int preguntasFalladas, int puntajeMinimo)
        {
            bool ganaste = puntuacion >= puntajeMinimo;

            label1.Text = ganaste ? "¡GANASTE!" : "¡PERDISTE!";
            label1.ForeColor = ganaste ? Color.Gold : Color.OrangeRed;

            label2.Text = $"📊 PUNTUACIÓN: {puntuacion} / {totalPreguntas}";

            label3.Text = $"✅ Correctas: {puntuacion}";

            label4.Text = $"❌ Incorrectas: {preguntasFalladas}";

            if (!ganaste)
            {
                label5.Text = $"Necesitabas {puntajeMinimo} aciertos para ganar";
            }
        }

        private void FormFinal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                this.DialogResult = DialogResult.No;
                this.Close();
            }
        }

        private void FormFinal_Load(object sender, EventArgs e)
        {
            label1.Left = (this.ClientSize.Width - label1.Width) / 2;
            label2.Left = (this.ClientSize.Width - label2.Width) / 2;
            label3.Left = (this.ClientSize.Width - 500) / 2;
            label4.Left = (this.ClientSize.Width - 500) / 2 + 250;
            label5.Left = (this.ClientSize.Width - label5.Width) / 2;
            pictureBox1.Left = (this.ClientSize.Width - pictureBox1.Width) / 2;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}