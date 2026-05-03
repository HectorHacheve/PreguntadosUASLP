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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
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
            btn_unirse.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_unirse.ForeColor = Color.White;
            btn_unirse.Location = new Point(700, 212);
            btn_unirse.Name = "btn_unirse";
            btn_unirse.Size = new Size(150, 33);
            btn_unirse.TabIndex = 2;
            btn_unirse.Text = "UNIRSE";
            btn_unirse.UseVisualStyleBackColor = false;
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
            lbl_estado.Click += label1_Click_1;
            // 
            // btn_listo
            // 
            btn_listo.BackColor = Color.SlateBlue;
            btn_listo.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_listo.ForeColor = Color.White;
            btn_listo.Location = new Point(350, 618);
            btn_listo.Name = "btn_listo";
            btn_listo.Size = new Size(500, 70);
            btn_listo.TabIndex = 5;
            btn_listo.Text = "INICIAR JUEGO";
            btn_listo.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.titulo;
            pictureBox1.Location = new Point(303, 92);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(629, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.logo;
            pictureBox2.Location = new Point(12, 61);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(267, 246);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = Properties.Resources.trophy;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(783, 398);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(467, 326);
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImage = Properties.Resources.celebrate;
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(-2, 398);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(315, 347);
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // FormLobby
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            BackgroundImage = Properties.Resources.fondoMorado;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1179, 775);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btn_listo);
            Controls.Add(lbl_estado);
            Controls.Add(list_jugadores);
            Controls.Add(btn_unirse);
            Controls.Add(txt_nombre);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox4);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Name = "FormLobby";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Preguntados UASLP";
            Load += FormLobby_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_nombre;
        private Button btn_unirse;
        private ListBox list_jugadores;
        private Label lbl_estado;
        private Button btn_listo;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}