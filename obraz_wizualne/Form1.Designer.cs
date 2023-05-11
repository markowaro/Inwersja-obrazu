namespace obraz_wizualne
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
            pictureBox1 = new PictureBox();
            Wczytaj = new Button();
            obrot_90 = new Button();
            pion = new Button();
            poziom = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(530, 312);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Wczytaj
            // 
            Wczytaj.Location = new Point(31, 330);
            Wczytaj.Name = "Wczytaj";
            Wczytaj.Size = new Size(119, 45);
            Wczytaj.TabIndex = 1;
            Wczytaj.Text = "Wczytaj";
            Wczytaj.UseVisualStyleBackColor = true;
            Wczytaj.Click += Wczytaj_Click;
            // 
            // obrot_90
            // 
            obrot_90.Location = new Point(582, 246);
            obrot_90.Name = "obrot_90";
            obrot_90.Size = new Size(173, 51);
            obrot_90.TabIndex = 2;
            obrot_90.Text = "Obrót 90st.";
            obrot_90.UseVisualStyleBackColor = true;
            obrot_90.Click += obrot_90_Click;
            // 
            // pion
            // 
            pion.Location = new Point(582, 303);
            pion.Name = "pion";
            pion.Size = new Size(173, 52);
            pion.TabIndex = 3;
            pion.Text = "Odbicie w pionie";
            pion.UseVisualStyleBackColor = true;
            pion.Click += pion_Click;
            // 
            // poziom
            // 
            poziom.Location = new Point(582, 361);
            poziom.Name = "poziom";
            poziom.Size = new Size(173, 52);
            poziom.TabIndex = 4;
            poziom.Text = "Odbicie w poziomie";
            poziom.UseVisualStyleBackColor = true;
            poziom.Click += poziom_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(poziom);
            Controls.Add(pion);
            Controls.Add(obrot_90);
            Controls.Add(Wczytaj);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button Wczytaj;
        private Button obrot_90;
        private Button pion;
        private Button poziom;
    }
}