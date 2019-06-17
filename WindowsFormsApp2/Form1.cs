using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Calculate the total resistance
            try
            {

                double resistance1, resistance2, resistanceTotal;
                resistance1 = Convert.ToDouble(textBox1.Text);
                resistance2 = Convert.ToDouble(textBox2.Text);
                resistanceTotal = resistance1 + resistance2;
                label3.Text = "total series resistance = " + resistanceTotal;
                resistanceTotal = 1 / (1 / resistance1 + 1 / resistance2);
                label20.Text = "total parallel resistance = " + resistanceTotal;
            }
            catch
            {
                MessageBox.Show("type in two numbers.");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Calculate the total resistance
            try
            {

                double resistance1, resistance2, resistance3, resistanceTotal;
                resistance1 = Convert.ToDouble(textBox3.Text);
                resistance2 = Convert.ToDouble(textBox4.Text);
                resistance3 = Convert.ToDouble(textBox5.Text);
                resistanceTotal = resistance1 + resistance2 + resistance3;
                label8.Text = "total series resistance = " + resistanceTotal;
                resistanceTotal = 1 / (1 / resistance1 + 1 / resistance2 + 1 / resistance3);
                label21.Text = "total parallel resistance = " + resistanceTotal;

            }
            catch
            {
                MessageBox.Show("Type in three numbers");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Calculate the total resistance
            try
            {

                double resistance1, resistance2, resistance3, resistance4, resistanceTotal;
                resistance1 = Convert.ToDouble(textBox6.Text);
                resistance2 = Convert.ToDouble(textBox7.Text);
                resistance3 = Convert.ToDouble(textBox8.Text);
                resistance4 = Convert.ToDouble(textBox9.Text);
                resistanceTotal = resistance1 + resistance2 + resistance3 + resistance4;
                label13.Text = "total resistance = " + resistanceTotal;
                resistanceTotal = 1 / (1 / resistance1 + 1 / resistance2 + 1 / resistance3 + 1 / resistance4);
                label22.Text = "total parallel resistance = " + resistanceTotal;
            }
            catch
            {
                MessageBox.Show("Type in four numbers");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Calculate the total resistance
            try
            {

                double resistance1, resistance2, resistance3, resistance4, resistance5, resistanceTotal;
                resistance1 = Convert.ToDouble(textBox10.Text);
                resistance2 = Convert.ToDouble(textBox11.Text);
                resistance3 = Convert.ToDouble(textBox12.Text);
                resistance4 = Convert.ToDouble(textBox13.Text);
                resistance5 = Convert.ToDouble(textBox14.Text);
                resistanceTotal = resistance1 + resistance2 + resistance3 + resistance4 + resistance5;
                label19.Text = "total resistance = " + resistanceTotal;
                resistanceTotal = 1 / (1 / resistance1 + 1 / resistance2 + 1 / resistance3 + 1 / resistance4 + 1 / resistance5);
                label23.Text = "total parallel resistance = " + resistanceTotal;

            }
            catch
            {
                MessageBox.Show("Type in five numbers");
            }
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }
    }
}



