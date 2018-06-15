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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.b1 = new System.Windows.Forms.TextBox();
            this.b0 = new System.Windows.Forms.TextBox();
            this.txta1 = new System.Windows.Forms.TextBox();
            this.txta2 = new System.Windows.Forms.TextBox();
            this.txta3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.stabilnosc = new System.Windows.Forms.Label();
            this.txta0 = new System.Windows.Forms.TextBox();
            this.sym = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // 
            // b0
            // 
            this.b0.Location = new System.Drawing.Point(275, 73);
            this.b0.Margin = new System.Windows.Forms.Padding(4);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(31, 22);
            this.b0.TabIndex = 2;
            this.b0.Tag = "pole";
            // 
            // txta1
            // 
            this.txta1.Location = new System.Drawing.Point(292, 123);
            this.txta1.Margin = new System.Windows.Forms.Padding(4);
            this.txta1.Name = "txta1";
            this.txta1.Size = new System.Drawing.Size(27, 22);
            this.txta1.TabIndex = 4;
            this.txta1.Tag = "pole";
            // 
            // txta2
            // 
            this.txta2.Location = new System.Drawing.Point(215, 123);
            this.txta2.Margin = new System.Windows.Forms.Padding(4);
            this.txta2.Name = "txta2";
            this.txta2.Size = new System.Drawing.Size(29, 22);
            this.txta2.TabIndex = 5;
            this.txta2.Tag = "pole";
            // 
            // txta3
            // 
            this.txta3.Location = new System.Drawing.Point(147, 123);
            this.txta3.Margin = new System.Windows.Forms.Padding(4);
            this.txta3.Name = "txta3";
            this.txta3.Size = new System.Drawing.Size(25, 22);
            this.txta3.TabIndex = 6;
            this.txta3.Tag = "pole";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(395, 13);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "sprawdź stabilność";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.txta0.Location = new System.Drawing.Point(360, 123);
            this.txta0.Name = "txta0";
            this.txta0.Size = new System.Drawing.Size(33, 22);
            this.txta0.TabIndex = 17;
            // 
            // sym
            // 
            this.sym.Location = new System.Drawing.Point(12, 311);
            this.sym.Name = "sym";
            this.sym.Size = new System.Drawing.Size(106, 28);
            this.sym.TabIndex = 18;
            this.sym.Text = "Symuluj układ";
            this.sym.UseVisualStyleBackColor = true;
            this.sym.Click += new System.EventHandler(this.sym_Click);
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(203, 193);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series5.Legend = "Legend1";
            series5.Name = "y";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Legend = "Legend1";
            series6.Name = "u(t)";
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(1331, 815);
            this.chart1.TabIndex = 19;
            this.chart1.Text = "chart1";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "sinusoidalnym",
            "trójkątnym",
            "prostokątnym"});
            this.checkedListBox1.Location = new System.Drawing.Point(15, 233);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(135, 72);
            this.checkedListBox1.TabIndex = 22;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Pobudzenie sygnałem";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.sym);
            this.Controls.Add(this.txta0);
            this.Controls.Add(this.stabilnosc);
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
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label stabilnosc;
        private System.Windows.Forms.TextBox txta0;
        private System.Windows.Forms.Button sym;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label1;
    }
}

