using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap9_WInform
{
    public partial class Form1 : Form
    {
        public int txb = 1;
        public Form1()
        {
            InitializeComponent();
        }


        private void n0_Click(object sender, EventArgs e)
        {
            string st = "0";
            switch (txb)
            {
                case 1:
                    textBox1.Text += st;
                    break;
                case 3:
                    textBox3.Text += st;
                    break;
                default:
                    break;
            }
        }

        private void n1_Click(object sender, EventArgs e)
        {
            string st = "1";
            switch (txb)
            {
                case 1:
                    textBox1.Text += st;
                    break;
                case 3:
                    textBox3.Text += st;
                    break;
                default:
                    break;
            }
        }

        private void n2_Click(object sender, EventArgs e)
        {
            string st = "2";
            switch (txb)
            {
                case 1:
                    textBox1.Text += st;
                    break;
                case 3:
                    textBox3.Text += st;
                    break;
                default:
                    break;
            }
        }

        private void n3_Click(object sender, EventArgs e)
        {
            string st = "3";
            switch (txb)
            {
                case 1:
                    textBox1.Text += st;
                    break;
                case 3:
                    textBox3.Text += st;
                    break;
                default:
                    break;
            }
        }

        private void n4_Click(object sender, EventArgs e)
        {
            string st = "4";
            switch (txb)
            {
                case 1:
                    textBox1.Text += st;
                    break;
                case 3:
                    textBox3.Text += st;
                    break;
                default:
                    break;
            }
        }

        private void n5_Click(object sender, EventArgs e)
        {
            string st = "5";
            switch (txb)
            {
                case 1:
                    textBox1.Text += st;
                    break;
                case 3:
                    textBox3.Text += st;
                    break;
                default:
                    break;
            }
        }

        private void n6_Click(object sender, EventArgs e)
        {
            string st = "6";
            switch (txb)
            {
                case 1:
                    textBox1.Text += st;
                    break;
                case 3:
                    textBox3.Text += st;
                    break;
                default:
                    break;
            }
        }

        private void n7_Click(object sender, EventArgs e)
        {
            string st = "7";
            switch (txb)
            {
                case 1:
                    textBox1.Text += st;
                    break;
                case 3:
                    textBox3.Text += st;
                    break;
                default:
                    break;
            }
        }

        private void n8_Click(object sender, EventArgs e)
        {
            string st = "8";
            switch (txb)
            {
                case 1:
                    textBox1.Text += st;
                    break;
                case 3:
                    textBox3.Text += st;
                    break;
                default:
                    break;
            }
        }

        private void n9_Click(object sender, EventArgs e)
        {
            string st = "9";
            switch (txb)
            {
                case 1:
                    textBox1.Text += st;
                    break;
                case 3:
                    textBox3.Text += st;
                    break;
                default:
                    break;
            }
        }


        private void textBox1_Click(object sender, EventArgs e)
        {
            txb = 1;
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            txb = 3;
        }

        private void btnKQ_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox3.Text);

            switch (Convert.ToChar(textBox2.Text))
            {
                case '+':
                    textBoxKQ.Text = a + b + "";
                    break;
                case '-':
                    textBoxKQ.Text = a - b + "";
                    break;
                case '*':
                    textBoxKQ.Text = a * b + "";
                    break;
                case '/':
                    if (b != 0)
                    {
                        textBoxKQ.Text = a / b + "";
                    }
                    else
                        textBoxKQ.Text = "error";
                    break;
                default:
                    break;
            }

        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            string st = ".";
            switch (txb)
            {
                case 1:
                    textBox1.Text += st;
                    break;
                case 3:
                    textBox3.Text += st;
                    break;
                default:
                    break;
            }

        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            textBox2.Text = "+";
            txb = 3;
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            textBox2.Text = "-";
            txb = 3;
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            textBox2.Text = "*";
            txb = 3;
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            textBox2.Text = "/";
            txb = 3;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txb == 1)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
            else
                textBox3.Text = textBox3.Text.Substring(0, textBox3.Text.Length - 1);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxKQ.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            txb = 1;
        }

        private void btnTab_Click(object sender, EventArgs e)
        {
            if (txb == 1)
            {
                txb = 3;
            }
            else
                txb = 1;
        }
    }
}
