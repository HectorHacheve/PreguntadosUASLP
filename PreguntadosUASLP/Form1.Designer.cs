namespace PreguntadosUASLP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            UASLP = new PictureBox();
            Cine = new PictureBox();
            Videojuegos = new PictureBox();
            Futbol = new PictureBox();
            Tecnologia = new PictureBox();
            Redes_Sociales = new PictureBox();
            Cultura_pop = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)UASLP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Cine).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Videojuegos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Futbol).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Tecnologia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Redes_Sociales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Cultura_pop).BeginInit();
            SuspendLayout();
            // 
            // UASLP
            // 
            UASLP.BackColor = Color.Transparent;
            UASLP.BackgroundImage = Properties.Resources.opciones;
            UASLP.BackgroundImageLayout = ImageLayout.Stretch;
            UASLP.Location = new Point(137, 321);
            UASLP.Margin = new Padding(3, 4, 3, 4);
            UASLP.Name = "UASLP";
            UASLP.Size = new Size(464, 92);
            UASLP.TabIndex = 0;
            UASLP.TabStop = false;
            UASLP.Tag = "UASLP";
            UASLP.Paint += Cultura_pop_Paint;
            // 
            // Cine
            // 
            Cine.BackColor = Color.Transparent;
            Cine.BackgroundImage = Properties.Resources.opciones;
            Cine.BackgroundImageLayout = ImageLayout.Stretch;
            Cine.Location = new Point(137, 421);
            Cine.Margin = new Padding(3, 4, 3, 4);
            Cine.Name = "Cine";
            Cine.Size = new Size(464, 92);
            Cine.TabIndex = 1;
            Cine.TabStop = false;
            Cine.Tag = "Cine";
            Cine.Paint += Cultura_pop_Paint;
            // 
            // Videojuegos
            // 
            Videojuegos.BackColor = Color.Transparent;
            Videojuegos.BackgroundImage = Properties.Resources.opciones;
            Videojuegos.BackgroundImageLayout = ImageLayout.Stretch;
            Videojuegos.Location = new Point(137, 521);
            Videojuegos.Margin = new Padding(3, 4, 3, 4);
            Videojuegos.Name = "Videojuegos";
            Videojuegos.Size = new Size(464, 92);
            Videojuegos.TabIndex = 2;
            Videojuegos.TabStop = false;
            Videojuegos.Tag = "Videojuegos";
            Videojuegos.Paint += Cultura_pop_Paint;
            // 
            // Futbol
            // 
            Futbol.BackColor = Color.Transparent;
            Futbol.BackgroundImage = Properties.Resources.opciones;
            Futbol.BackgroundImageLayout = ImageLayout.Stretch;
            Futbol.Location = new Point(608, 521);
            Futbol.Margin = new Padding(3, 4, 3, 4);
            Futbol.Name = "Futbol";
            Futbol.Size = new Size(464, 92);
            Futbol.TabIndex = 5;
            Futbol.TabStop = false;
            Futbol.Tag = "Futbol";
            Futbol.Click += Futbol_Click;
            Futbol.Paint += Cultura_pop_Paint;
            // 
            // Tecnologia
            // 
            Tecnologia.BackColor = Color.Transparent;
            Tecnologia.BackgroundImage = Properties.Resources.opciones;
            Tecnologia.BackgroundImageLayout = ImageLayout.Stretch;
            Tecnologia.Location = new Point(608, 421);
            Tecnologia.Margin = new Padding(3, 4, 3, 4);
            Tecnologia.Name = "Tecnologia";
            Tecnologia.Size = new Size(464, 92);
            Tecnologia.TabIndex = 4;
            Tecnologia.TabStop = false;
            Tecnologia.Tag = "Tecnología";
            Tecnologia.Paint += Cultura_pop_Paint;
            // 
            // Redes_Sociales
            // 
            Redes_Sociales.BackColor = Color.Transparent;
            Redes_Sociales.BackgroundImage = Properties.Resources.opciones;
            Redes_Sociales.BackgroundImageLayout = ImageLayout.Stretch;
            Redes_Sociales.Location = new Point(608, 317);
            Redes_Sociales.Margin = new Padding(3, 4, 3, 4);
            Redes_Sociales.Name = "Redes_Sociales";
            Redes_Sociales.Size = new Size(464, 92);
            Redes_Sociales.TabIndex = 3;
            Redes_Sociales.TabStop = false;
            Redes_Sociales.Tag = "Redes sociales";
            Redes_Sociales.Paint += Cultura_pop_Paint;
            // 
            // Cultura_pop
            // 
            Cultura_pop.BackColor = Color.Transparent;
            Cultura_pop.BackgroundImage = Properties.Resources.opciones;
            Cultura_pop.BackgroundImageLayout = ImageLayout.Stretch;
            Cultura_pop.Location = new Point(375, 621);
            Cultura_pop.Margin = new Padding(3, 4, 3, 4);
            Cultura_pop.Name = "Cultura_pop";
            Cultura_pop.Size = new Size(464, 92);
            Cultura_pop.TabIndex = 6;
            Cultura_pop.TabStop = false;
            Cultura_pop.Tag = "Cultura pop";
            Cultura_pop.Paint += Cultura_pop_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            BackgroundImage = Properties.Resources.preguntados_uaslp;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1179, 775);
            Controls.Add(Cultura_pop);
            Controls.Add(Futbol);
            Controls.Add(Tecnologia);
            Controls.Add(Redes_Sociales);
            Controls.Add(Videojuegos);
            Controls.Add(Cine);
            Controls.Add(UASLP);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Preguntados - UASLP´s Version";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)UASLP).EndInit();
            ((System.ComponentModel.ISupportInitialize)Cine).EndInit();
            ((System.ComponentModel.ISupportInitialize)Videojuegos).EndInit();
            ((System.ComponentModel.ISupportInitialize)Futbol).EndInit();
            ((System.ComponentModel.ISupportInitialize)Tecnologia).EndInit();
            ((System.ComponentModel.ISupportInitialize)Redes_Sociales).EndInit();
            ((System.ComponentModel.ISupportInitialize)Cultura_pop).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox UASLP;
        private PictureBox Cine;
        private PictureBox Videojuegos;
        private PictureBox Futbol;
        private PictureBox Tecnologia;
        private PictureBox Redes_Sociales;
        private PictureBox Cultura_pop;
    }
}
