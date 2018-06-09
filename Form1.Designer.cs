namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.b1 = new System.Windows.Forms.TextBox();
            this.b0 = new System.Windows.Forms.TextBox();
            this.txta0 = new System.Windows.Forms.TextBox();
            this.txta1 = new System.Windows.Forms.TextBox();
            this.txta2 = new System.Windows.Forms.TextBox();
            this.txta3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(371, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(145, 59);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(26, 20);
            this.b1.TabIndex = 1;
            this.b1.Tag = "pole";
            // 
            // b0
            // 
            this.b0.Location = new System.Drawing.Point(206, 59);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(24, 20);
            this.b0.TabIndex = 2;
            this.b0.Tag = "pole";
            // 
            // txta0
            // 
            this.txta0.Location = new System.Drawing.Point(273, 100);
            this.txta0.Name = "txta0";
            this.txta0.Size = new System.Drawing.Size(25, 20);
            this.txta0.TabIndex = 3;
            this.txta0.Tag = "pole";
            // 
            // txta1
            // 
            this.txta1.Location = new System.Drawing.Point(219, 100);
            this.txta1.Name = "txta1";
            this.txta1.Size = new System.Drawing.Size(21, 20);
            this.txta1.TabIndex = 4;
            this.txta1.Tag = "pole";
            // 
            // txta2
            // 
            this.txta2.Location = new System.Drawing.Point(161, 100);
            this.txta2.Name = "txta2";
            this.txta2.Size = new System.Drawing.Size(23, 20);
            this.txta2.TabIndex = 5;
            this.txta2.Tag = "pole";
            // 
            // txta3
            // 
            this.txta3.Location = new System.Drawing.Point(110, 100);
            this.txta3.Name = "txta3";
            this.txta3.Size = new System.Drawing.Size(20, 20);
            this.txta3.TabIndex = 6;
            this.txta3.Tag = "pole";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(390, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "sprawdź stabilność";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txta3);
            this.Controls.Add(this.txta2);
            this.Controls.Add(this.txta1);
            this.Controls.Add(this.txta0);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox b1;
        private System.Windows.Forms.TextBox b0;
        private System.Windows.Forms.TextBox txta0;
        private System.Windows.Forms.TextBox txta1;
        private System.Windows.Forms.TextBox txta2;
        private System.Windows.Forms.TextBox txta3;
        private System.Windows.Forms.Button symulacja;
        private System.Windows.Forms.Button button1;
    }
}

