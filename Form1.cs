using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            int a0, a1, a2, a3;
            a1 = Convert.ToInt32(txta1.Text);
            a2 = Convert.ToInt32(txta2.Text);
            a3 = Convert.ToInt32(txta3.Text);
            a0 = Convert.ToInt32(txta0.Text);
            if (a1 > 0 && a0 > 0 && a2 > 0 && a3 > 0)
            {
                if((a1*a2-a3*a0)>0){
                    MessageBox.Show("Warunek konieczny i wystarczający został spełniony, układ jest stabilny.");
                }
                else
                {
                    MessageBox.Show("Warunek konieczny został spełniony. Warunek wystarczający NIE został spełniony, układ jest niestabilny.");
                }
                
            }
            else
            {
                MessageBox.Show("warunek konieczny nie jest spełniony, układ jest niestabilny.");
            }
        }
    }
}
