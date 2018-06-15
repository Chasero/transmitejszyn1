using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SortedList utSL = new SortedList();
        SortedList utpSL = new SortedList();
        SortedList uttSL = new SortedList();
        double ut;


        private void button1_Click(object sender, EventArgs e)
        {
            double a0, a1, a2, a3;
            a1 = Convert.ToDouble(txta1.Text);
            a2 = Convert.ToDouble(txta2.Text);
            a3 = Convert.ToDouble(txta3.Text);
            a0 = Convert.ToDouble(txta0.Text);
            if (a1 > 0 && a0 > 0 && a2 > 0 && a3 > 0)
            {
                if((a1*a2-a3*a0)>0){
                    stabilnosc.Text =("Warunek konieczny i wystarczający został spełniony, układ jest stabilny.");
                }
                else
                {
                    stabilnosc.Text = ("Warunek konieczny został spełniony. Warunek wystarczający NIE został spełniony, układ jest niestabilny.");
                }
                
            }
            else
            {
                stabilnosc.Text = ("Warunek konieczny nie jest spełniony, układ jest niestabilny.");
            }
        }

       /* private void b0_TextChanged(object sender, EventArgs e)
        {
            n1.Text = b0.Text;
        }
        private void b1_TextChanged_1(object sender, EventArgs e)
        {
            n0.Text = b1.Text;
        }

        private void txta3_TextChanged(object sender, EventArgs e)
        {
            //int valuea3 = Int32.Parse(txta3.Text);
            //int valued1;

            //macierzA = new int[4,4];

            //valued1 = -valuea3;
            // d1.Text = valued1;
            //macierzA[3, 3] = valued1;
            d1.Text = txta3.Text;
        }
         private void txta2_TextChanged(object sender, EventArgs e)
        {
            d2.Text = txta2.Text;
        }

        private void txta1_TextChanged(object sender, EventArgs e)
        {
            d3.Text = txta1.Text;
        }       
        private void txta0_TextChanged_1(object sender, EventArgs e)
        {
            d4.Text = txta0.Text;
        }
        */
        private void sym_Click(object sender, EventArgs e)
        {
            double dt, x1 = 0, x2 = 0, x3 = 0, x4 = 0, t = 0, y = 0, a1, a2, a3, a0, db1, db0;
            int j, i;           
            j = 5000;
            dt = 0.002;
            a1 = Convert.ToDouble(txta1.Text);
            a2 = Convert.ToDouble(txta2.Text);
            a3 = Convert.ToDouble(txta3.Text);
            a0 = Convert.ToDouble(txta0.Text);
            db0 = Convert.ToDouble(b0.Text);
            db1 = Convert.ToDouble(b1.Text);         
            SortedList x1SL = new SortedList();            
            SortedList x2SL = new SortedList();
            SortedList x3SL = new SortedList();
            SortedList x4SL = new SortedList();
            SortedList ySL = new SortedList();
            string[] s = { "sinusoidalnym", "trójkątnym", "prostokątnym" };
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            for (i = 0; i<j; i++) {
                foreach (Object item in checkedListBox1.CheckedItems)
                    if (item.ToString() == "sinusoidalnym")
                    {
                        ut = Convert.ToDouble(utSL[t]);
                    }
                    else
                    {
                        if (item.ToString() == "trójkątnym")
                            {
                                ut = Convert.ToDouble(uttSL[t]);
                            }
                            else
                            {
                                if (item.ToString() == "prostokatnym")
                                    {
                                        ut = Convert.ToDouble(utpSL[t]);
                                    }
                            }
                    }
                x1 = x1 + x2 * dt;
                x2 = x2 + x3 * dt;
                x3 = x3 + x4 * dt;
                x4 = x4 + (-a0 * x1 - a1 * x2 - a2 * x3 - a3 * x4 + db1 * ut + db0 * ut) * dt;
                y = x1;
                x1SL.Add(t, x1);
                x2SL.Add(t, x2);
                x3SL.Add(t, x3);
                x4SL.Add(t, x4);
                ySL.Add(t, y);
                chart1.Series["y"].Points.AddXY(t, ySL[t]);
                chart1.Series["u(t)"].Points.AddXY(t, ut);
                t = t + dt;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int j = 5000, i = 0;
            double dt = 0.002, t = 0, p = 0;
            for (i = 0; i < j; i++)
            {
                utSL.Add(t, Math.Sin(t));
                t = t + dt;
            }
            for (i = 0; i < j; i++)
            {
                if (Math.Sin(p) > 0) {
                    utpSL.Add(p, 1);
                    
                }
                else
                {
                    utpSL.Add(p, -1);
                }
                p = p + dt;
            }
        }
    }
}
