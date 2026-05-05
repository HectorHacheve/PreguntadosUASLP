using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace PreguntadosUASLP
{
    public partial class FormFinal : Form
    {
        private bool esMultijugador = false;

        private string ganadorNombre;
        private int ganadorPuntuacion;
        private List<(string nombre, int puntuacion, int falladas)> jugadores;
        private string nombreJugadorActual;

        public FormFinal(int puntuacion, int totalPreguntas, int preguntasFalladas, int puntajeMinimo)
        {
            InitializeComponent();

            this.AutoScroll = false;
            this.AutoScrollMinSize = new Size(0, 0);
            this.HorizontalScroll.Enabled = false;
            this.HorizontalScroll.Visible = false;
            this.VerticalScroll.Enabled = false;
            this.VerticalScroll.Visible = false;
            this.SetStyle(ControlStyles.ContainerControl, true);

            esMultijugador = false;
            ConfigurarFormularioIndividual(puntuacion, totalPreguntas, preguntasFalladas, puntajeMinimo);

            this.KeyPreview = true;
            this.KeyDown += FormFinal_KeyDown;

            if (pictureBox1 != null)
            {
                pictureBox1.Click += (s, e) => { this.DialogResult = DialogResult.No; this.Close(); };
            }
        }

        public FormFinal(string nombreGanador, int puntajeGanador, List<(string nombre, int puntuacion, int falladas)> resultadosJugadores, int totalPreguntas, string nombreJugadorActual = null)
        {
            InitializeComponent();

            this.AutoScroll = false;
            this.AutoScrollMinSize = new Size(0, 0);
            this.HorizontalScroll.Enabled = false;
            this.HorizontalScroll.Visible = false;
            this.VerticalScroll.Enabled = false;
            this.VerticalScroll.Visible = false;
            this.SetStyle(ControlStyles.ContainerControl, true);

            esMultijugador = true;
            ganadorNombre = nombreGanador;
            ganadorPuntuacion = puntajeGanador;
            jugadores = resultadosJugadores;
            this.nombreJugadorActual = nombreJugadorActual;

            ConfigurarFormularioMultijugador(totalPreguntas);

            this.KeyPreview = true;
            this.KeyDown += FormFinal_KeyDown;

            if (pictureBox1 != null)
            {
                pictureBox1.Click += (s, e) => { this.DialogResult = DialogResult.No; this.Close(); };
            }
        }

        private void ConfigurarFormularioIndividual(int puntuacion, int totalPreguntas, int preguntasFalladas, int puntajeMinimo)
        {
            bool ganaste = puntuacion >= puntajeMinimo;

            label1.Text = ganaste ? "¡GANASTE!" : "¡PERDISTE!";
            label1.ForeColor = ganaste ? Color.Gold : Color.OrangeRed;

            label2.Text = $"📊 PUNTUACIÓN: {puntuacion} / {totalPreguntas}";
            label3.Text = $"✅ Correctas: {puntuacion}";
            label4.Text = $"❌ Incorrectas: {preguntasFalladas}";

            label6.Visible = false;

            if (!ganaste)
            {
                label5.Text = $"Necesitabas {puntajeMinimo} aciertos para ganar";
                label5.ForeColor = Color.LightCoral;
            }
            else
            {
                label5.Text = "🎉 ¡Felicidades! Has ganado la partida 🎉";
                label5.ForeColor = Color.Gold;
            }
        }

        private void ConfigurarFormularioMultijugador(int totalPreguntas)
        {
            bool soyElGanador = !string.IsNullOrEmpty(nombreJugadorActual) && nombreJugadorActual == ganadorNombre;

            if (soyElGanador)
            {
                label1.Text = "🎉 ¡FELICIDADES! 🎉\n¡HAS GANADO LA PARTIDA!";
                label1.ForeColor = Color.Gold;
                label1.Font = new Font("Arial Rounded MT Bold", 22F, FontStyle.Bold);
                label1.Size = new Size(750, 80);
            }
            else
            {
                label1.Text = "😔 ¡HAS PERDIDO! 😔";
                label1.ForeColor = Color.OrangeRed;
                label1.Font = new Font("Arial Rounded MT Bold", 26F, FontStyle.Bold);
                label1.Size = new Size(750, 72);
            }

            var jugadorActual = jugadores.FirstOrDefault(j => j.nombre == nombreJugadorActual);
            if (!string.IsNullOrEmpty(nombreJugadorActual) && jugadorActual != default)
            {
                label2.Text = $"📊 TU PUNTUACIÓN: {jugadorActual.puntuacion} / {totalPreguntas}";
                label2.ForeColor = soyElGanador ? Color.Gold : Color.White;

                label3.Text = $"✅ Tus correctas: {jugadorActual.puntuacion}";
                label4.Text = $"❌ Tus incorrectas: {jugadorActual.falladas}";
                label3.Visible = true;
                label4.Visible = true;
            }
            else
            {
                label2.Text = $"👑 GANADOR: {ganadorNombre} con {ganadorPuntuacion} / {totalPreguntas} puntos";
                label2.ForeColor = Color.Gold;
                label3.Visible = false;
                label4.Visible = false;
            }

            // Configurar label6 - Muestra quién ganó
            if (!soyElGanador)
            {
                label6.Text = $"🏆 EL GANADOR ES: {ganadorNombre} 🏆\n" +
                             $"Con {ganadorPuntuacion} aciertos de {totalPreguntas} preguntas";
                label6.ForeColor = Color.Gold;
                label6.Font = new Font("Arial", 13F, FontStyle.Bold);
                label6.TextAlign = ContentAlignment.MiddleCenter;
                label6.BackColor = Color.FromArgb(80, 0, 0, 0);
                label6.Visible = true;
                label6.Size = new Size(700, 55);
            }
            else
            {
                label6.Text = "🎉 ¡ERES EL CAMPEÓN! 🎉\n" +
                             $"Ganaste con {ganadorPuntuacion} aciertos";
                label6.ForeColor = Color.Gold;
                label6.Font = new Font("Arial", 14F, FontStyle.Bold);
                label6.TextAlign = ContentAlignment.MiddleCenter;
                label6.Visible = true;
                label6.Size = new Size(700, 55);
            }

            // Tabla de posiciones
            string tablaResultados = "📋 TABLA DE POSICIONES FINAL:\n\n";
            var jugadoresOrdenados = jugadores.OrderByDescending(j => j.puntuacion).ToList();

            int puesto = 1;
            foreach (var jugador in jugadoresOrdenados)
            {
                string medalla = "";
                if (puesto == 1) medalla = "🥇 ";
                else if (puesto == 2) medalla = "🥈 ";
                else if (puesto == 3) medalla = "🥉 ";
                else medalla = "   ";

                string indicadorGanador = jugador.nombre == ganadorNombre ? "👑 " : "   ";
                string marcadorActual = jugador.nombre == nombreJugadorActual ? " → TÚ" : "";

                tablaResultados += $"{medalla}{puesto}. {indicadorGanador}{jugador.nombre}: {jugador.puntuacion}/{totalPreguntas} puntos (❌ {jugador.falladas} fallos){marcadorActual}\n";
                puesto++;
            }

            label5.Text = tablaResultados;
            label5.ForeColor = Color.White;
            label5.Font = new Font("Arial", 10F, FontStyle.Bold);
            label5.TextAlign = ContentAlignment.MiddleLeft;

            label6.Left = (this.ClientSize.Width - label6.Width) / 2;
        }

        private void FormFinal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                this.DialogResult = DialogResult.No;
                this.Close();

                if (!esMultijugador)
                {
                    Form1 menuPrincipal = new Form1();
                    menuPrincipal.Show();
                }
                else
                {
                    FormLobby lobby = new FormLobby();
                    lobby.Show();
                }
            }
            else if (e.KeyCode == Keys.Enter)
            {
                Application.Exit();
            }
        }

        private void FormFinal_Load(object sender, EventArgs e)
        {
            this.AutoScroll = false;

            label1.Left = (this.ClientSize.Width - label1.Width) / 2;
            label2.Left = (this.ClientSize.Width - label2.Width) / 2;

            if (!esMultijugador)
            {
                label3.Left = (this.ClientSize.Width - 500) / 2;
                label4.Left = (this.ClientSize.Width - 500) / 2 + 250;
            }
            else
            {
                label3.Left = (this.ClientSize.Width - 500) / 2;
                label4.Left = (this.ClientSize.Width - 500) / 2 + 250;
                label6.Left = (this.ClientSize.Width - label6.Width) / 2;
                label6.Visible = true;
            }

            label5.Left = (this.ClientSize.Width - label5.Width) / 2;
            pictureBox1.Left = (this.ClientSize.Width - pictureBox1.Width) / 2;
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void lblInstrucciones_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void pictureBoxCelebrate_Click(object sender, EventArgs e) { }
    }
}