namespace PreguntadosUASLP
{
    partial class FormFutbol
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
            labelpregFutbol = new Label();
            botonOp1 = new Button();
            button2 = new Button();
            botonOp3 = new Button();
            botonOp4 = new Button();
            SuspendLayout();
            // 
            // labelpregFutbol
            // 
            labelpregFutbol.AutoSize = true;
            labelpregFutbol.Location = new Point(359, 33);
            labelpregFutbol.Name = "labelpregFutbol";
            labelpregFutbol.Size = new Size(38, 15);
            labelpregFutbol.TabIndex = 0;
            labelpregFutbol.Text = "label1";
            labelpregFutbol.Click += labelpregFutbol_Click;
            // 
            // botonOp1
            // 
            botonOp1.Location = new Point(255, 143);
            botonOp1.Name = "botonOp1";
            botonOp1.Size = new Size(75, 23);
            botonOp1.TabIndex = 1;
            botonOp1.Text = "button1";
            botonOp1.UseVisualStyleBackColor = true;
            botonOp1.Click += botonOp1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(465, 143);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // botonOp3
            // 
            botonOp3.Location = new Point(255, 200);
            botonOp3.Name = "botonOp3";
            botonOp3.Size = new Size(75, 23);
            botonOp3.TabIndex = 3;
            botonOp3.Text = "button3";
            botonOp3.UseVisualStyleBackColor = true;
            botonOp3.Click += botonOp3_Click;
            // 
            // botonOp4
            // 
            botonOp4.Location = new Point(465, 200);
            botonOp4.Name = "botonOp4";
            botonOp4.Size = new Size(75, 23);
            botonOp4.TabIndex = 4;
            botonOp4.Text = "button4";
            botonOp4.UseVisualStyleBackColor = true;
            botonOp4.Click += botonOp4_Click;
            // 
            // FormFutbol
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(botonOp4);
            Controls.Add(botonOp3);
            Controls.Add(button2);
            Controls.Add(botonOp1);
            Controls.Add(labelpregFutbol);
            Name = "FormFutbol";
            Text = "FormFutbol";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelpregFutbol;
        private Button botonOp1;
        private Button button2;
        private Button botonOp3;
        private Button botonOp4;
    }
}