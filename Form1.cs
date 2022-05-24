using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
<<<<<<< HEAD

        private void oneButton_Click(object sender, EventArgs e)
        {
            if (textBox1 == null || textBox1.Text == "0")
            {
                textBox1.Text = "1";
            }
            else { 
=======
        double a;
        double b;
        string c;
        private void oneButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "1";
            }
            else
            {
>>>>>>> master
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (textBox1 == null || textBox1.Text == "0")
=======
            if (textBox1.Text == "")
>>>>>>> master
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (textBox1 == null || textBox1.Text == "0")
=======
            if (textBox1.Text == "")
>>>>>>> master
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (textBox1 == null || textBox1.Text == "0")
=======
            if (textBox1.Text == "")
>>>>>>> master
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (textBox1 == null || textBox1.Text == "0")
=======
            if (textBox1.Text == "")
>>>>>>> master
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (textBox1 == null || textBox1.Text == "0")
=======
            if (textBox1.Text == "")
>>>>>>> master
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (textBox1 == null || textBox1.Text == "0")
=======
            if (textBox1.Text == "")
>>>>>>> master
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (textBox1 == null || textBox1.Text == "0")
=======
            if (textBox1.Text == "")
>>>>>>> master
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (textBox1 == null || textBox1.Text == "0")
=======
            if (textBox1.Text == "")
>>>>>>> master
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (textBox1 == null || textBox1.Text == "0")
=======
            if (textBox1.Text == "")
>>>>>>> master
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (textBox1 == null || textBox1.Text == "0")
            {
                textBox1.Text = "+";
            }
            else
            {
                textBox1.Text = textBox1.Text + "+";
            }
=======
            a = Convert.ToDouble(this.textBox1.Text);
            c = "+";
            this.textBox1.Clear();
            this.textBox1.Focus();
>>>>>>> master
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (textBox1 == null || textBox1.Text == "0")
            {
                textBox1.Text = "-";
            }
            else
            {
                textBox1.Text = textBox1.Text + "-";
            }
=======
            a = Convert.ToDouble(this.textBox1.Text);
            c = "-";
            this.textBox1.Clear();
            this.textBox1.Focus();
>>>>>>> master
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (textBox1 == null || textBox1.Text == "0")
            {
                textBox1.Text = "x";
            }
            else
            {
                textBox1.Text = textBox1.Text + "x";
            }
=======
            a = Convert.ToDouble(this.textBox1.Text);
            c = "*";
            this.textBox1.Clear();
            this.textBox1.Focus();
>>>>>>> master
        }

        private void splitButton_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (textBox1 == null || textBox1.Text == "0")
            {
                textBox1.Text = "/";
            }
            else
            {
                textBox1.Text = textBox1.Text + "/";
            }
=======
            a = Convert.ToDouble(this.textBox1.Text);
            c = "/";
            this.textBox1.Clear();
            this.textBox1.Focus();
>>>>>>> master
        }

        private void pointButton_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (textBox1.Text.Contains(".") == false)
            {
                textBox1.Text = textBox1.Text+ ".";
            }
            
=======
            if (this.textBox1.Text.Contains('.') == false)
            {
                this.textBox1.Text = this.textBox1.Text + ".";
            }
        }

        private void sameButton_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(this.textBox1.Text);
            switch (c)
            {
                case "+":
                    this.textBox1.Text = Convert.ToString(b + a);
                    break;

                case "-":
                    this.textBox1.Text = Convert.ToString(b - a);
                    break;

                case "*":
                    this.textBox1.Text = Convert.ToString(b * a);
                    break;

                case "/":
                    this.textBox1.Text = Convert.ToString(b / a);
                    break;
            }
>>>>>>> master
        }
    }
}
