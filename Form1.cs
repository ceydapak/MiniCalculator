﻿using System;
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
        double x, y;
        string islem;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="0")
            {
                textBox1.Text = "2";          }
            else
            {
                textBox1.Text += "2";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text += "1";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text += "0";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            islem = "toplama";
            label1.Text = textBox1.Text + " + ";
            textBox1.Text = "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            y = Convert.ToDouble(textBox1.Text);
            if (islem == "toplama")
            {
                label1.Text = Convert.ToString(x + y);
                textBox1.Text = " ";
            }
            else if (islem == "cikartma")
            {
                label1.Text = Convert.ToString(x - y);
                textBox1.Text = " ";
            }
            else if (islem == "carpma")
            {
                label1.Text = Convert.ToString(x * y);
                textBox1.Text = " ";
            }
            else if (islem == "bolme")
            {
                label1.Text = Convert.ToString(x / y);
                textBox1.Text = " ";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            islem = "cikartma";
            label1.Text = textBox1.Text + " - ";
            textBox1.Text = "0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            islem = "carpma";
            label1.Text = textBox1.Text + " * ";
            textBox1.Text = "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            islem = "bolme";
            label1.Text = textBox1.Text + " / ";
            textBox1.Text = "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            textBox1.Text += ",";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label1.Text = " ";
        }
    }
}
