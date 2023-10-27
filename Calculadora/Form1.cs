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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txtBoxN1.Text);
            double n2 = Convert.ToDouble(txtBoxN2.Text);
            double resultado = n1 + n2;
            labelResultado.Text = resultado.ToString("F2");
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txtBoxN1.Text);
            double n2 = Convert.ToDouble(txtBoxN2.Text);
            double resultado = n1 - n2;
            labelResultado.Text = resultado.ToString("F2");
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txtBoxN1.Text);
            double n2 = Convert.ToDouble(txtBoxN2.Text);
            double resultado = n1 * n2;
            labelResultado.Text = resultado.ToString("F2");
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txtBoxN1.Text);
            double n2 = Convert.ToDouble(txtBoxN2.Text);
            double resultado = n1 / n2;
            labelResultado.Text = resultado.ToString("F2");
        }
    }
}
