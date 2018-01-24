using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double F = Convert.ToDouble(textBox1.Text);
            double Angle = Convert.ToDouble(textBox2.Text);

            double Fx = F * cos(Angle);
            double Fy = F * sin(Angle);
            MessageBox.Show("Fx = " + Fx + "N");
            MessageBox.Show("Fy = " + Fy + "N");

        }
        double sin(double x)
        { 
            return(Math.Sin(x* Math.PI/180.0));
        }  
           
        double cos(double x)
        {
            return (Math.Cos(x * Math.PI / 180.0));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
