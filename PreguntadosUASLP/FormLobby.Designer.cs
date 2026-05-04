namespace PreguntadosUASLP
{
    partial class FormLobby
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_nombre = new TextBox();
            btn_unirse = new Button();
            list_jugadores = new ListBox();
            lbl_estado = new Label();
            btn_listo = new Button();
            pictureBox_titulo = new PictureBox();
            pictureBoxLogo = new PictureBox();
            pictureBoxTrophy = new PictureBox();
            pictureBoxCelebrate = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox_titulo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTrophy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCelebrate).BeginInit();
            SuspendLayout();
            // 
            // txt_nombre
            // 
            txt_nombre.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_nombre.Location = new Point(350, 216);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(344, 27);
            txt_nombre.TabIndex = 1;
            txt_nombre.TextChanged += txt_nombre_TextChanged;
            // 
            // btn_unirse
            // 
            btn_unirse.BackColor = Color.SlateBlue;
            btn_unirse.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_unirse.ForeColor = Color.White;
            btn_unirse.Location = new Point(700, 212);
            btn_unirse.Name = "btn_unirse";
            btn_unirse.Size = new Size(150, 33);
            btn_unirse.TabIndex = 2;
            btn_unirse.Text = "UNIRSE";
            btn_unirse.UseVisualStyleBackColor = false;
            btn_unirse.Click += btn_unirse_Click;
            // 
            // list_jugadores
            // 
            list_jugadores.BorderStyle = BorderStyle.None;
            list_jugadores.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            list_jugadores.ForeColor = Color.Indigo;
            list_jugadores.FormattingEnabled = true;
            list_jugadores.Location = new Point(350, 264);
            list_jugadores.Name = "list_jugadores";
            list_jugadores.Size = new Size(500, 322);
            list_jugadores.TabIndex = 3;
            list_jugadores.SelectedIndexChanged += list_jugadores_SelectedIndexChanged;
            // 
            // lbl_estado
            // 
            lbl_estado.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_estado.ForeColor = Color.White;
            lbl_estado.Location = new Point(350, 168);
            lbl_estado.Name = "lbl_estado";
            lbl_estado.Size = new Size(500, 30);
            lbl_estado.TabIndex = 4;
            lbl_estado.Text = "Ingresa tu nombre y dale click a UNIRSE";
            lbl_estado.TextAlign = ContentAlignment.MiddleCenter;
            lbl_estado.UseMnemonic = false;
            lbl_estado.Click += lbl_estado_Click;
            // 
            // btn_listo
            // 
            btn_listo.BackColor = Color.SlateBlue;
            btn_listo.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_listo.ForeColor = Color.White;
            btn_listo.Location = new Point(350, 618);
            btn_listo.Name = "btn_listo";
            btn_listo.Size = new Size(500, 70);
            btn_listo.TabIndex = 5;
            btn_listo.Text = "INICIAR JUEGO";
            btn_listo.UseVisualStyleBackColor = false;
            btn_listo.Click += btn_listo_Click;
            // 
            // pictureBox_titulo
            // 
            pictureBox_titulo.BackColor = Color.Transparent;
            pictureBox_titulo.Image = Properties.Resources.titulo;
            pictureBox_titulo.Location = new Point(303, 92);
            pictureBox_titulo.Name = "pictureBox_titulo";
            pictureBox_titulo.Size = new Size(629, 63);
            pictureBox_titulo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_titulo.TabIndex = 6;
            pictureBox_titulo.TabStop = false;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackColor = Color.Transparent;
            pictureBoxLogo.BackgroundImage = Properties.Resources.logo;
            pictureBoxLogo.Location = new Point(12, 61);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(267, 246);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 7;
            pictureBoxLogo.TabStop = false;
            pictureBoxLogo.Click += pictureBoxLogo_Click;
            // 
            // pictureBoxTrophy
            // 
            pictureBoxTrophy.BackColor = Color.Transparent;
            pictureBoxTrophy.BackgroundImage = Properties.Resources.trophy;
            pictureBoxTrophy.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxTrophy.Location = new Point(783, 398);
            pictureBoxTrophy.Name = "pictureBoxTrophy";
            pictureBoxTrophy.Size = new Size(467, 326);
            pictureBoxTrophy.TabIndex = 8;
            pictureBoxTrophy.TabStop = false;
            pictureBoxTrophy.Click += pictureBoxTrophy_Click;
            // 
            // pictureBoxCelebrate
            // 
            pictureBoxCelebrate.BackColor = Color.Transparent;
            pictureBoxCelebrate.BackgroundImage = Properties.Resources.celebrate;
            pictureBoxCelebrate.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxCelebrate.Location = new Point(-2, 398);
            pictureBoxCelebrate.Name = "pictureBoxCelebrate";
            pictureBoxCelebrate.Size = new Size(315, 347);
            pictureBoxCelebrate.TabIndex = 9;
            pictureBoxCelebrate.TabStop = false;
            pictureBoxCelebrate.Click += pictureBoxCelebrate_Click;
            // 
            // FormLobby
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            BackgroundImage = Properties.Resources.fondoMorado;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1179, 775);
            Controls.Add(pictureBoxLogo);
            Controls.Add(pictureBox_titulo);
            Controls.Add(btn_listo);
            Controls.Add(lbl_estado);
            Controls.Add(list_jugadores);
            Controls.Add(btn_unirse);
            Controls.Add(txt_nombre);
            Controls.Add(pictureBoxTrophy);
            Controls.Add(pictureBoxCelebrate);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Name = "FormLobby";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Preguntados UASLP";
            Load += FormLobby_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox_titulo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTrophy).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCelebrate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_nombre;
        private Button btn_unirse;
        private ListBox list_jugadores;
        private Label lbl_estado;
        private Button btn_listo;
        private PictureBox pictureBox_titulo;
        private PictureBox pictureBoxLogo;
        private PictureBox pictureBoxTrophy;
        private PictureBox pictureBoxCelebrate;
    }
}