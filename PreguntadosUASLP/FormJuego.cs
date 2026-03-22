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
            ImagenCategoria();
        }

        private void FormJuego_Load(object sender, EventArgs e)
        {
            label_placeholder1.Text = categoria;
            MostrarTipoPregunta("audio"); // texto, image o audio (lo que quieres mostrar)
        }

        private void ImagenCategoria() // para mostrar imagen según categoría :D
        {
            switch (categoria)
            {
                case "UASLP":
                    pictureBox_cat1.Image = Properties.Resources.uni; 
                    pictureBox_cat1.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox_cat2.Image = Properties.Resources.certificado;
                    pictureBox_cat2.SizeMode = PictureBoxSizeMode.Zoom;
                    break;

                case "Redes Sociales":
                    pictureBox_cat1.Image = Properties.Resources.mensajes;
                    pictureBox_cat1.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox_cat2.Image = Properties.Resources.celular;
                    pictureBox_cat2.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
            }
        }
        private void MostrarTipoPregunta(string tipo)
        {
            label01.Visible = false; // op. de texto
            label02.Visible = false;
            label03.Visible = false;
            label04.Visible = false;

            btn_audio1.Visible = false; // op. de audio
            btn_audio2.Visible = false;
            btn_audio3.Visible = false;
            btn_audio4.Visible = false;

            pictureBox_op1.Visible = false; // op. de img
            pictureBox_op2.Visible = false;
            pictureBox_op3.Visible = false;
            pictureBox_op4.Visible = false;

            // mostrar según tipo
            switch (tipo)
            {
                case "texto":
                    label01.Visible = true;
                    label02.Visible = true;
                    label03.Visible = true;
                    label04.Visible = true;
                    break;

                case "imagen":
                    pictureBox_op1.Visible = true;
                    pictureBox_op2.Visible = true;
                    pictureBox_op3.Visible = true;
                    pictureBox_op4.Visible = true;
                    break;

                case "audio":
                    btn_audio1.Visible = true;
                    btn_audio2.Visible = true;
                    btn_audio3.Visible = true;
                    btn_audio4.Visible = true;
                    break;
            }
        }

    }
}
