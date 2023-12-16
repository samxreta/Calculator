using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private object textbox;

        public Form1()
        {
            InitializeComponent();
        }

        double number1, number2;
        string symbol;
        

        

        private void button4_Click(object sender, EventArgs e)
        {
            if (gamotvla.Text=="0")
            {
                gamotvla.Text = "4";
            }
            else
            {
                gamotvla.Text += "4";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (gamotvla.Text=="0")
            {
                gamotvla.Text = "1";
            }
            else
            {
                gamotvla.Text += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (gamotvla.Text == "0")
            {
                gamotvla.Text = "2";
            }
            else
            {
                gamotvla.Text += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (gamotvla.Text == "0")
            {
                gamotvla.Text = "3";
            }
            else
            {
                gamotvla.Text += "3";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (gamotvla.Text == "0")
            {
                gamotvla.Text = "5";
            }
            else
            {
                gamotvla.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (gamotvla.Text == "0")
            {
                gamotvla.Text = "6";
            }
            else
            {
                gamotvla.Text += "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (gamotvla.Text == "0")
            {
                gamotvla.Text = "7";
            }
            else
            {
                gamotvla.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (gamotvla.Text == "0")
            {
                gamotvla.Text = "8";
            }
            else
            {
                gamotvla.Text += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (gamotvla.Text == "0")
            {
                gamotvla.Text = "9";
            }
            else
            {
                gamotvla.Text += "9";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (gamotvla.Text == "0")
            {
                gamotvla.Text = "0";
            }
            else
            {
                gamotvla.Text += "0";
            }
        }

        private void wertili_Click(object sender, EventArgs e)
        {
            gamotvla.Text += " . ";
        }

        private void washla_Click(object sender, EventArgs e)
        {
            gamotvla.Clear();
        }

        private void pliusi_Click(object sender, EventArgs e)
        {
            symbol = "+";
            number1 = Convert.ToDouble(gamotvla.Text);
            gamotvla.Clear();
        }

        private void minusi_Click(object sender, EventArgs e)
        {
            symbol = "-";
            number1 = Convert.ToDouble(gamotvla.Text);
            gamotvla.Clear();
        }

        private void gamravleba_Click(object sender, EventArgs e)
        {
            symbol = "x";
            number1 = Convert.ToDouble(gamotvla.Text);
            gamotvla.Clear();
        }

        private void gayofa_Click(object sender, EventArgs e)
        {
            symbol = "/";
            number1 = Convert.ToDouble(gamotvla.Text);
            gamotvla.Clear();
        }

        private void udris_Click(object sender, EventArgs e)
        {
            number2=Convert.ToDouble(gamotvla.Text);
            if(symbol=="+")
            {
                gamotvla.Text=Convert.ToString(number1+number2);
            }
            number2 = Convert.ToDouble(gamotvla.Text);
            if (symbol == "-")
            {
                gamotvla.Text = Convert.ToString(number1 - number2);
            }
            if (symbol == "x")
            {
                gamotvla.Text = Convert.ToString(number1 * number2);
            }
            if (symbol == "/")
            {
                gamotvla.Text = Convert.ToString(number1 / number2);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
