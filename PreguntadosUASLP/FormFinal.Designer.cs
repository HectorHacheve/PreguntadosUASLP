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
            label_placeholder2 = new Label();
            pictureBox1 = new PictureBox();
            lblInstrucciones = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Arial Rounded MT Bold", 28F, FontStyle.Bold);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(0, 80);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(750, 70);
            label1.TabIndex = 0;
            label1.Text = "¡GANASTE!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Arial", 20F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 170);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(750, 50);
            label2.TabIndex = 1;
            label2.Text = "📊 PUNTUACIÓN: 0 / 12";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Arial", 16F);
            label3.ForeColor = Color.LightGreen;
            label3.Location = new Point(125, 240);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(250, 40);
            label3.TabIndex = 2;
            label3.Text = "✅ Correctas: 0";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Arial", 16F);
            label4.ForeColor = Color.LightCoral;
            label4.Location = new Point(375, 240);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(250, 40);
            label4.TabIndex = 3;
            label4.Text = "❌ Incorrectas: 0";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Arial", 12F);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(0, 300);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(750, 50);
            label5.TabIndex = 4;
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_placeholder2
            // 
            label_placeholder2.AutoSize = true;
            label_placeholder2.Location = new Point(306, 184);
            label_placeholder2.Margin = new Padding(4, 0, 4, 0);
            label_placeholder2.Name = "label_placeholder2";
            label_placeholder2.Size = new Size(0, 25);
            label_placeholder2.TabIndex = 3;
            label_placeholder2.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(50, 0, 0, 0);
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(125, 350);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(500, 133);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // lblInstrucciones
            // 
            lblInstrucciones.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblInstrucciones.ForeColor = Color.White;
            lblInstrucciones.Location = new Point(125, 350);
            lblInstrucciones.Name = "lblInstrucciones";
            lblInstrucciones.Size = new Size(500, 133);
            lblInstrucciones.TabIndex = 6;
            lblInstrucciones.Text = "🎮 PRESIONA:\n\nESPACIO → JUGAR DE NUEVO\nENTER → SALIR";
            lblInstrucciones.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormFinal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(750, 500);
            Controls.Add(lblInstrucciones);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label_placeholder2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormFinal";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Resultado Final";
            Load += FormFinal_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label_placeholder2;
        private PictureBox pictureBox1;
        private Label lblInstrucciones;
    }
}