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
        int numero1;
        int numero2;
        int resultado;
        private void oneButton_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "1";
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "+";
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "5";
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "2";
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "3";
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "4";
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "6";
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "7";
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "8";
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "9";
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "0";
        }
    }
}
