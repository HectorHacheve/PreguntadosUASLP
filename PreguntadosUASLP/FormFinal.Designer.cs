namespace PreguntadosUASLP
{
    partial class FormFinal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            lblInstrucciones = new Label();
            label6 = new Label();
            pictureBoxCelebrate = new PictureBox();
            pictureBoxTrophy = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCelebrate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTrophy).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Rounded MT Bold", 28F, FontStyle.Bold);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(273, 26);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(362, 72);
            label1.TabIndex = 0;
            label1.Text = "¡GANASTE!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 20F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(78, 303);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(750, 50);
            label2.TabIndex = 1;
            label2.Text = "📊 PUNTUACIÓN: 0 / 12";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 16F);
            label3.ForeColor = Color.LightGreen;
            label3.Location = new Point(199, 383);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(250, 40);
            label3.TabIndex = 2;
            label3.Text = "✅ Correctas: 0";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 16F);
            label4.ForeColor = Color.LightCoral;
            label4.Location = new Point(449, 383);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(250, 40);
            label4.TabIndex = 3;
            label4.Text = "❌ Incorrectas: 0";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 11F);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(78, 156);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(750, 80);
            label5.TabIndex = 4;
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(199, 458);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(500, 100);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // lblInstrucciones
            // 
            lblInstrucciones.BackColor = Color.Transparent;
            lblInstrucciones.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblInstrucciones.ForeColor = Color.White;
            lblInstrucciones.Location = new Point(-23, 458);
            lblInstrucciones.Margin = new Padding(2, 0, 2, 0);
            lblInstrucciones.Name = "lblInstrucciones";
            lblInstrucciones.Size = new Size(942, 172);
            lblInstrucciones.TabIndex = 6;
            lblInstrucciones.Text = "🎮 PRESIONA:\n\nESPACIO → JUGAR DE NUEVO\nENTER → SALIR";
            lblInstrucciones.TextAlign = ContentAlignment.MiddleCenter;
            lblInstrucciones.Click += lblInstrucciones_Click;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial", 14F, FontStyle.Bold);
            label6.ForeColor = Color.Gold;
            label6.Location = new Point(100, 236);
            label6.Name = "label6";
            label6.Size = new Size(700, 55);
            label6.TabIndex = 7;
            label6.TextAlign = ContentAlignment.MiddleCenter;
            label6.Click += label6_Click;
            // 
            // pictureBoxCelebrate
            // 
            pictureBoxCelebrate.BackColor = Color.Transparent;
            pictureBoxCelebrate.BackgroundImage = Properties.Resources.celebrate;
            pictureBoxCelebrate.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxCelebrate.Location = new Point(-26, 409);
            pictureBoxCelebrate.Margin = new Padding(4);
            pictureBoxCelebrate.Name = "pictureBoxCelebrate";
            pictureBoxCelebrate.Size = new Size(226, 229);
            pictureBoxCelebrate.TabIndex = 10;
            pictureBoxCelebrate.TabStop = false;
            pictureBoxCelebrate.Click += pictureBoxCelebrate_Click;
            // 
            // pictureBoxTrophy
            // 
            pictureBoxTrophy.BackColor = Color.Transparent;
            pictureBoxTrophy.BackgroundImage = Properties.Resources.trophy;
            pictureBoxTrophy.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxTrophy.Location = new Point(631, -40);
            pictureBoxTrophy.Margin = new Padding(4);
            pictureBoxTrophy.Name = "pictureBoxTrophy";
            pictureBoxTrophy.Size = new Size(356, 233);
            pictureBoxTrophy.TabIndex = 11;
            pictureBoxTrophy.TabStop = false;
            // 
            // FormFinal
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.DarkSlateBlue;
            BackgroundImage = Properties.Resources.fondoMorado1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(908, 621);
            Controls.Add(pictureBoxTrophy);
            Controls.Add(pictureBoxCelebrate);
            Controls.Add(label6);
            Controls.Add(lblInstrucciones);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormFinal";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Resultado Final";
            Load += FormFinal_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCelebrate).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTrophy).EndInit();
            ResumeLayout(false);
        }

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
        private Label lblInstrucciones;
        private Label label6;
        private PictureBox pictureBoxCelebrate;
        private PictureBox pictureBoxTrophy;
    }
}