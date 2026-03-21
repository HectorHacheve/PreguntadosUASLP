namespace PreguntadosUASLP
{
    partial class FormJuego
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
            label_pregunta = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label_pregunta
            // 
            label_pregunta.AutoSize = true;
            label_pregunta.BackColor = Color.Lavender;
            label_pregunta.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_pregunta.Location = new Point(426, 111);
            label_pregunta.Name = "label_pregunta";
            label_pregunta.Size = new Size(284, 32);
            label_pregunta.TabIndex = 0;
            label_pregunta.Text = "(Ingresar pregunta)";
            label_pregunta.Click += label_pregunta_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Lavender;
            pictureBox1.ErrorImage = Properties.Resources.preguntas1;
            pictureBox1.Location = new Point(274, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(609, 108);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Lavender;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(976, 19);
            label1.Name = "label1";
            label1.Size = new Size(191, 23);
            label1.TabIndex = 2;
            label1.Text = "(vidas sobrantes?)";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Lavender;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(455, 667);
            label2.Name = "label2";
            label2.Size = new Size(255, 23);
            label2.TabIndex = 3;
            label2.Text = "(reemplazar con puntaje)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Lavender;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 19);
            label3.Name = "label3";
            label3.Size = new Size(224, 23);
            label3.TabIndex = 4;
            label3.Text = "(numero de pregunta)";
            // 
            // FormJuego
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            BackgroundImage = Properties.Resources.fondoMorado;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1179, 775);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label_pregunta);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormJuego";
            Text = "Preguntados UASLP";
            Load += FormJuego_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_pregunta;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}