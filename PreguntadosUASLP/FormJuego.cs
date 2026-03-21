using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PreguntadosUASLP
{
    public partial class FormJuego : Form
    {
        public string categoria;
        public FormJuego(string categoriaRecibida) // es para recibir cat. selec. en el Form1
        {
            InitializeComponent();
            categoria = categoriaRecibida;
        }

        private void FormJuego_Load(object sender, EventArgs e)
        {

        }

        private void label_pregunta_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
