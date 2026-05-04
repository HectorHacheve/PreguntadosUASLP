using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PreguntadosUASLP
{
    public partial class FormLobby : Form
    {
        private bool yaUnido = false;
        public FormLobby()
        {
            InitializeComponent();
        }

        private void FormLobby_Load(object sender, EventArgs e)
        {
            btn_listo.Enabled = false;
        }

        private async void btn_unirse_Click(object sender, EventArgs e)
        {
            string nombre = txt_nombre.Text.Trim();
            if (string.IsNullOrEmpty(nombre)) // nombres vacíos
            {
                lbl_estado.Text = "Escribe tu nombre primero! >:(";
                lbl_estado.ForeColor = System.Drawing.Color.OrangeRed;
                return;
            }

            if (list_jugadores.Items.Contains("⭐ " + nombre)) // nombres repetidos
            {
                lbl_estado.Text = "Ese nombre ya está en uso";
                lbl_estado.ForeColor = System.Drawing.Color.OrangeRed;
                return;
            }

            list_jugadores.Items.Add("⭐ " + nombre); // agregar a la lista
            
            //LLAMADA DEL API (AGREGAR DESPUESSSSS)!!!
            // await ServidorAPI.UnirseLobby(nombre);

            yaUnido = true;
            btn_unirse.Enabled = false;
            txt_nombre.Enabled = false;
            btn_listo.Enabled = true;
            lbl_estado.Text = "Conectado como \"" + nombre + "\" !!";
            lbl_estado.ForeColor = System.Drawing.Color.LightGreen;
            await Task.Delay(2000);
            lbl_estado.Text = "Presiona INICIAR JUEGO cuando estén todos :D";
            lbl_estado.ForeColor = System.Drawing.Color.White;
        }

        private void btn_listo_Click(object sender, EventArgs e)
        {
            if (!yaUnido) return;

            //ENVIO DEL SOCKET (AGREGAR DESPUESSSSS)!!!
            // await socketCliente.EnviarAsync(new { tipo = "listo" });
            
            Form1 menu = new Form1(txt_nombre.Text.Trim()); //temporal eh
            menu.Show();
            this.Hide();
        }

        private void FormLobby_Load_1(object sender, EventArgs e) {

        }
        private void lbl_estado_Click(object sender, EventArgs e) { 
        
        }
        private void list_jugadores_SelectedIndexChanged(object sender, EventArgs e) { 
        
        }
        private void pictureBoxTrophy_Click(object sender, EventArgs e) {
        
        }
        private void txt_nombre_TextChanged(object sender, EventArgs e) {
        
        }
        private void pictureBoxLogo_Click(object sender, EventArgs e) { 
        
        }
        private void pictureBoxCelebrate_Click(object sender, EventArgs e) { 
        
        }
    }
}