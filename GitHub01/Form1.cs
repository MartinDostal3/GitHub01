using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHub01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = int.Parse(textBox1.Text);
            double b = int.Parse(textBox2.Text);
            double vysledek = a + b;
            double rozdil = a - b;
            double soucin = a * b;
            
            MessageBox.Show("Vysledek sčítání je: " + vysledek);
            MessageBox.Show("Vysledek odčítání je: " + rozdil);
            MessageBox.Show("Vysledek násobení je: " + soucin);
        }
    }
}
