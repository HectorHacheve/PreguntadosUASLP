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
            label_placeholder2 = new Label();
            label_placeholder1 = new Label();
            btn_audio1 = new PictureBox();
            btn_audio2 = new PictureBox();
            btn_audio3 = new PictureBox();
            btn_audio4 = new PictureBox();

            ((System.ComponentModel.ISupportInitialize)btn_audio1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_audio2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_audio3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_audio4).BeginInit();

            pb_placeholder3 = new PictureBox();
            pictureBox_op1 = new PictureBox();
            pictureBox_op2 = new PictureBox();
            pictureBox_op3 = new PictureBox();
            pictureBox_op4 = new PictureBox();
            pb_op01 = new PictureBox();
            pb_op02 = new PictureBox();
            pb_op03 = new PictureBox();
            pb_op04 = new PictureBox();
            pictureBox_cat1 = new PictureBox();
            pictureBox_cat2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pb_placeholder3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_op1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_op2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_op3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_op4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_op01).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_op02).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_op03).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_op04).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_cat1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_cat2).BeginInit();
            SuspendLayout();
            // 
            // label_pregunta
            // 
            label_pregunta.AutoSize = true;
            label_pregunta.BackColor = Color.Transparent;
            label_pregunta.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_pregunta.ForeColor = Color.White;
            label_pregunta.Location = new Point(260, 80);
            label_pregunta.MaximumSize = new Size(700, 0);
            label_pregunta.Name = "label_pregunta";
            label_pregunta.Size = new Size(268, 37);
            label_pregunta.TabIndex = 0;
            label_pregunta.Text = "(Ingresar pregunta)";
            label_pregunta.TextAlign = ContentAlignment.MiddleCenter;
            label_pregunta.Click += label_pregunta_Click;
            // 
            // label_placeholder2
            // 
            label_placeholder2.AutoSize = true;
            label_placeholder2.BackColor = Color.Transparent;
            label_placeholder2.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_placeholder2.ForeColor = Color.WhiteSmoke;
            label_placeholder2.Location = new Point(968, 15);
            label_placeholder2.Name = "label_placeholder2";
            label_placeholder2.Size = new Size(187, 28);
            label_placeholder2.TabIndex = 2;
            label_placeholder2.Text = "(num de pregunta)";
            // 
            // label_placeholder1
            // 
            label_placeholder1.AutoSize = true;
            label_placeholder1.BackColor = Color.Transparent;
            label_placeholder1.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_placeholder1.ForeColor = Color.WhiteSmoke;
            label_placeholder1.Location = new Point(21, 15);
            label_placeholder1.Name = "label_placeholder1";
            label_placeholder1.Size = new Size(118, 28);
            label_placeholder1.TabIndex = 4;
            label_placeholder1.Text = "(categoria)";
            // 
            // btn_audio1
            // 
            btn_audio1.Location = new Point(243, 283);
            btn_audio1.Name = "btn_audio1";
            btn_audio1.Size = new Size(363, 119);
            btn_audio1.TabIndex = 5;
            btn_audio1.TabStop = false;
            btn_audio1.Tag = "";
            btn_audio1.Paint += pb_opcion_Paint;
            btn_audio1.Click += btn_audio_Click;
            // 
            // btn_audio2
            // 
            btn_audio2.Location = new Point(623, 283);
            btn_audio2.Name = "btn_audio2";
            btn_audio2.Size = new Size(363, 119);
            btn_audio2.TabIndex = 6;
            btn_audio2.TabStop = false;
            btn_audio2.Tag = "";
            btn_audio2.Paint += pb_opcion_Paint;
            btn_audio2.Click += btn_audio_Click;
            // 
            // btn_audio3
            // 
            btn_audio3.Location = new Point(243, 424);
            btn_audio3.Name = "btn_audio3";
            btn_audio3.Size = new Size(363, 119);
            btn_audio3.TabIndex = 8;
            btn_audio3.TabStop = false;
            btn_audio3.Tag = "";
            btn_audio3.Paint += pb_opcion_Paint;
            btn_audio3.Click += btn_audio_Click;
            //
            // btn_audio4
            // 
            btn_audio4.Location = new Point(623, 424);
            btn_audio4.Name = "btn_audio4";
            btn_audio4.Size = new Size(363, 119);
            btn_audio4.TabIndex = 7;
            btn_audio4.TabStop = false;
            btn_audio4.Tag = "";
            btn_audio4.Paint += pb_opcion_Paint;
            btn_audio4.Click += btn_audio_Click;

            ((System.ComponentModel.ISupportInitialize)btn_audio1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_audio2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_audio3).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_audio4).EndInit();

            // 
            // pb_placeholder3
            // 
            pb_placeholder3.BackColor = Color.Transparent;
            pb_placeholder3.Location = new Point(490, 599);
            pb_placeholder3.Name = "pb_placeholder3";
            pb_placeholder3.Size = new Size(250, 40);
            pb_placeholder3.TabIndex = 9;
            pb_placeholder3.TabStop = false;
            pb_placeholder3.Paint += pb_puntaje_Paint;
            // 
            // pictureBox_op1
            // 
            pictureBox_op1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox_op1.Location = new Point(21, 268);
            pictureBox_op1.Name = "pictureBox_op1";
            pictureBox_op1.Size = new Size(280, 297);
            pictureBox_op1.TabIndex = 10;
            pictureBox_op1.TabStop = false;
            pictureBox_op1.BackgroundImageLayoutChanged += FormJuego_Load;
            // 
            // pictureBox_op2
            // 
            pictureBox_op2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox_op2.Location = new Point(306, 268);
            pictureBox_op2.Name = "pictureBox_op2";
            pictureBox_op2.Size = new Size(280, 297);
            pictureBox_op2.TabIndex = 11;
            pictureBox_op2.TabStop = false;
            pictureBox_op2.BackgroundImageLayoutChanged += FormJuego_Load;
            // 
            // pictureBox_op3
            // 
            pictureBox_op3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox_op3.Location = new Point(591, 268);
            pictureBox_op3.Name = "pictureBox_op3";
            pictureBox_op3.Size = new Size(280, 297);
            pictureBox_op3.TabIndex = 12;
            pictureBox_op3.TabStop = false;
            pictureBox_op3.BackgroundImageLayoutChanged += FormJuego_Load;
            // 
            // pictureBox_op4
            // 
            pictureBox_op4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox_op4.Location = new Point(876, 268);
            pictureBox_op4.Name = "pictureBox_op4";
            pictureBox_op4.Size = new Size(280, 297);
            pictureBox_op4.TabIndex = 13;
            pictureBox_op4.TabStop = false;
            pictureBox_op4.BackgroundImageLayoutChanged += FormJuego_Load;
            // 
            // pb_op01
            // 
            pb_op01.BackColor = Color.Transparent;
            pb_op01.Image = Properties.Resources.newBtn;
            pb_op01.Location = new Point(255, 268);
            pb_op01.Name = "pb_op01";
            pb_op01.Size = new Size(351, 141);
            pb_op01.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_op01.TabIndex = 14;
            pb_op01.TabStop = false;
            pb_op01.Tag = "";
            pb_op01.Click += pb_op1_Click;
            pb_op01.Paint += pb_opcion_Paint;
            // 
            // pb_op02
            // 
            pb_op02.BackColor = Color.Transparent;
            pb_op02.Image = Properties.Resources.newBtn;
            pb_op02.Location = new Point(623, 268);
            pb_op02.Name = "pb_op02";
            pb_op02.Size = new Size(351, 141);
            pb_op02.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_op02.TabIndex = 15;
            pb_op02.TabStop = false;
            pb_op02.Tag = "";
            pb_op02.Click += pb_op02_Click;
            pb_op02.Paint += pb_opcion_Paint;
            // 
            // pb_op03
            // 
            pb_op03.BackColor = Color.Transparent;
            pb_op03.Image = Properties.Resources.newBtn;
            pb_op03.Location = new Point(255, 424);
            pb_op03.Name = "pb_op03";
            pb_op03.Size = new Size(351, 141);
            pb_op03.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_op03.TabIndex = 16;
            pb_op03.TabStop = false;
            pb_op03.Tag = "";
            pb_op03.Click += pb_op3_Click;
            pb_op03.Paint += pb_opcion_Paint;
            // 
            // pb_op04
            // 
            pb_op04.BackColor = Color.Transparent;
            pb_op04.Image = Properties.Resources.newBtn;
            pb_op04.Location = new Point(623, 424);
            pb_op04.Name = "pb_op04";
            pb_op04.Size = new Size(351, 141);
            pb_op04.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_op04.TabIndex = 17;
            pb_op04.TabStop = false;
            pb_op04.Tag = "";
            pb_op04.Click += pb_op4_Click;
            pb_op04.Paint += pb_opcion_Paint;
            // 
            // pictureBox_cat1
            // 
            pictureBox_cat1.BackColor = Color.Transparent;
            pictureBox_cat1.Location = new Point(12, 68);
            pictureBox_cat1.Name = "pictureBox_cat1";
            pictureBox_cat1.Size = new Size(239, 194);
            pictureBox_cat1.TabIndex = 18;
            pictureBox_cat1.TabStop = false;
            // 
            // pictureBox_cat2
            // 
            pictureBox_cat2.BackColor = Color.Transparent;
            pictureBox_cat2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox_cat2.Location = new Point(930, 577);
            pictureBox_cat2.Name = "pictureBox_cat2";
            pictureBox_cat2.Size = new Size(237, 186);
            pictureBox_cat2.TabIndex = 19;
            pictureBox_cat2.TabStop = false;
            // 
            // FormJuego
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            BackgroundImage = Properties.Resources.fondoMorado;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1179, 775);
            Controls.Add(pictureBox_cat1);
            Controls.Add(label_pregunta);
            Controls.Add(pb_op04);
            Controls.Add(pb_op02);
            Controls.Add(pictureBox_cat2);
            Controls.Add(pb_placeholder3);
            Controls.Add(label_placeholder1);
            Controls.Add(label_placeholder2);
            Controls.Add(pb_op03);
            Controls.Add(pb_op01);
            Controls.Add(btn_audio3);
            Controls.Add(btn_audio4);
            Controls.Add(btn_audio1);
            Controls.Add(pictureBox_op2);
            Controls.Add(pictureBox_op1);
            Controls.Add(btn_audio2);
            Controls.Add(pictureBox_op3);
            Controls.Add(pictureBox_op4);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Name = "FormJuego";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Preguntados UASLP";
            Load += FormJuego_Load;
            KeyDown += FormJuego_Confirmar;
            ((System.ComponentModel.ISupportInitialize)pb_placeholder3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_op1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_op2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_op3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_op4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_op01).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_op02).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_op03).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_op04).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_cat1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_cat2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_pregunta;
        private Label label_placeholder1; //categoria
        private Label label_placeholder2; //num de pregunta
        private PictureBox pb_placeholder3; //puntaje
        private PictureBox pb_op01;
        private PictureBox pb_op02;
        private PictureBox pb_op03;
        private PictureBox pb_op04;
        private PictureBox btn_audio1;
        private PictureBox btn_audio2;
        private PictureBox btn_audio4;
        private PictureBox btn_audio3;
        private PictureBox pictureBox_op1;
        private PictureBox pictureBox_op2;
        private PictureBox pictureBox_op3;
        private PictureBox pictureBox_op4;
        private PictureBox pictureBox_cat1;
        private PictureBox pictureBox_cat2;
    }
}