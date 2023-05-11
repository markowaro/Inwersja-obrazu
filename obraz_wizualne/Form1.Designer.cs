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
            green = new Button();
            negatyw = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(555, 288);
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
            // green
            // 
            green.Location = new Point(600, 44);
            green.Name = "green";
            green.Size = new Size(121, 47);
            green.TabIndex = 2;
            green.Text = "Zielony";
            green.UseVisualStyleBackColor = true;
            green.Click += green_Click;
            // 
            // negatyw
            // 
            negatyw.Location = new Point(600, 97);
            negatyw.Name = "negatyw";
            negatyw.Size = new Size(121, 49);
            negatyw.TabIndex = 3;
            negatyw.Text = "Negatyw";
            negatyw.UseVisualStyleBackColor = true;
            negatyw.Click += negatyw_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(negatyw);
            Controls.Add(green);
            Controls.Add(Wczytaj);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button green;
        private Button negatyw;
        public Button Wczytaj;
    }
}