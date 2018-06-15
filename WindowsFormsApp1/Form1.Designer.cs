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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.b1 = new System.Windows.Forms.TextBox();
            this.b0 = new System.Windows.Forms.TextBox();
            this.txta1 = new System.Windows.Forms.TextBox();
            this.txta2 = new System.Windows.Forms.TextBox();
            this.txta3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.n0 = new System.Windows.Forms.TextBox();
            this.n1 = new System.Windows.Forms.TextBox();
            this.d4 = new System.Windows.Forms.TextBox();
            this.d3 = new System.Windows.Forms.TextBox();
            this.d2 = new System.Windows.Forms.TextBox();
            this.d1 = new System.Windows.Forms.TextBox();
            this.stabilnosc = new System.Windows.Forms.Label();
            this.txta0 = new System.Windows.Forms.TextBox();
            this.sym = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(371, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(193, 73);
            this.b1.Margin = new System.Windows.Forms.Padding(4);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(33, 22);
            this.b1.TabIndex = 1;
            this.b1.Tag = "pole";
            this.b1.TextChanged += new System.EventHandler(this.b1_TextChanged_1);
            // 
            // b0
            // 
            this.b0.Location = new System.Drawing.Point(275, 73);
            this.b0.Margin = new System.Windows.Forms.Padding(4);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(31, 22);
            this.b0.TabIndex = 2;
            this.b0.Tag = "pole";
            this.b0.TextChanged += new System.EventHandler(this.b0_TextChanged);
            // 
            // txta1
            // 
            this.txta1.Location = new System.Drawing.Point(292, 123);
            this.txta1.Margin = new System.Windows.Forms.Padding(4);
            this.txta1.Name = "txta1";
            this.txta1.Size = new System.Drawing.Size(27, 22);
            this.txta1.TabIndex = 4;
            this.txta1.Tag = "pole";
            this.txta1.TextChanged += new System.EventHandler(this.txta1_TextChanged);
            // 
            // txta2
            // 
            this.txta2.Location = new System.Drawing.Point(215, 123);
            this.txta2.Margin = new System.Windows.Forms.Padding(4);
            this.txta2.Name = "txta2";
            this.txta2.Size = new System.Drawing.Size(29, 22);
            this.txta2.TabIndex = 5;
            this.txta2.Tag = "pole";
            this.txta2.TextChanged += new System.EventHandler(this.txta2_TextChanged);
            // 
            // txta3
            // 
            this.txta3.Location = new System.Drawing.Point(147, 123);
            this.txta3.Margin = new System.Windows.Forms.Padding(4);
            this.txta3.Name = "txta3";
            this.txta3.Size = new System.Drawing.Size(25, 22);
            this.txta3.TabIndex = 6;
            this.txta3.Tag = "pole";
            this.txta3.TextChanged += new System.EventHandler(this.txta3_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(520, 30);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "sprawdź stabilność";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(-1, 207);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(501, 169);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // n0
            // 
            this.n0.Location = new System.Drawing.Point(176, 336);
            this.n0.Margin = new System.Windows.Forms.Padding(4);
            this.n0.Name = "n0";
            this.n0.Size = new System.Drawing.Size(73, 22);
            this.n0.TabIndex = 9;
            // 
            // n1
            // 
            this.n1.Location = new System.Drawing.Point(89, 336);
            this.n1.Margin = new System.Windows.Forms.Padding(4);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(77, 22);
            this.n1.TabIndex = 10;
            // 
            // d4
            // 
            this.d4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.d4.Location = new System.Drawing.Point(115, 302);
            this.d4.Margin = new System.Windows.Forms.Padding(4);
            this.d4.Name = "d4";
            this.d4.Size = new System.Drawing.Size(32, 22);
            this.d4.TabIndex = 11;
            // 
            // d3
            // 
            this.d3.Location = new System.Drawing.Point(176, 302);
            this.d3.Margin = new System.Windows.Forms.Padding(4);
            this.d3.Name = "d3";
            this.d3.Size = new System.Drawing.Size(24, 22);
            this.d3.TabIndex = 12;
            // 
            // d2
            // 
            this.d2.Location = new System.Drawing.Point(239, 302);
            this.d2.Margin = new System.Windows.Forms.Padding(4);
            this.d2.Name = "d2";
            this.d2.Size = new System.Drawing.Size(27, 22);
            this.d2.TabIndex = 13;
            // 
            // d1
            // 
            this.d1.Location = new System.Drawing.Point(297, 302);
            this.d1.Margin = new System.Windows.Forms.Padding(4);
            this.d1.Name = "d1";
            this.d1.Size = new System.Drawing.Size(29, 22);
            this.d1.TabIndex = 14;
            // 
            // stabilnosc
            // 
            this.stabilnosc.AutoSize = true;
            this.stabilnosc.Location = new System.Drawing.Point(533, 91);
            this.stabilnosc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stabilnosc.Name = "stabilnosc";
            this.stabilnosc.Size = new System.Drawing.Size(0, 17);
            this.stabilnosc.TabIndex = 15;
            // 
            // txta0
            // 
            this.txta0.Location = new System.Drawing.Point(377, 123);
            this.txta0.Name = "txta0";
            this.txta0.Size = new System.Drawing.Size(33, 22);
            this.txta0.TabIndex = 17;
            this.txta0.TextChanged += new System.EventHandler(this.txta0_TextChanged_1);
            // 
            // sym
            // 
            this.sym.Location = new System.Drawing.Point(699, 30);
            this.sym.Name = "sym";
            this.sym.Size = new System.Drawing.Size(106, 28);
            this.sym.TabIndex = 18;
            this.sym.Text = "Symuluj układ";
            this.sym.UseVisualStyleBackColor = true;
            this.sym.Click += new System.EventHandler(this.sym_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(585, 175);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series1.Legend = "Legend1";
            series1.Name = "y";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(453, 300);
            this.chart1.TabIndex = 19;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.sym);
            this.Controls.Add(this.txta0);
            this.Controls.Add(this.stabilnosc);
            this.Controls.Add(this.d1);
            this.Controls.Add(this.d2);
            this.Controls.Add(this.d3);
            this.Controls.Add(this.d4);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.n0);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txta3);
            this.Controls.Add(this.txta2);
            this.Controls.Add(this.txta1);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox b1;
        private System.Windows.Forms.TextBox b0;
        private System.Windows.Forms.TextBox txta1;
        private System.Windows.Forms.TextBox txta2;
        private System.Windows.Forms.TextBox txta3;
        private System.Windows.Forms.Button symulacja;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox n0;
        private System.Windows.Forms.TextBox n1;
        private System.Windows.Forms.TextBox d4;
        private System.Windows.Forms.TextBox d3;
        private System.Windows.Forms.TextBox d2;
        private System.Windows.Forms.TextBox d1;
        private System.Windows.Forms.Label stabilnosc;
        private System.Windows.Forms.TextBox txta0;
        private System.Windows.Forms.Button sym;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

