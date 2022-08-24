using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Aula1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string Nome;
        string Sobrenome;

        int N1;
        int N2;
        int i;

        private void btnConcatenacao_Click(object sender, EventArgs e)
        {


            Nome = txtNome.Text;
            Sobrenome = txtSobrenome.Text;

            txtNomeSobrenome.Text = Nome + " " + Sobrenome;

        }

        private void btnSoma_Click(object sender, EventArgs e)
        {

            N1 = int.Parse(txtN1.Text);
            N2 = int.Parse(txtN2.Text);
            N1 = N1 + N2;
            txtN3.Text = N1.ToString();

            N1 = int.Parse(txtN1.Text);
            if (N1 >= 10)
            {
                txtN3.Text = "É um número igual ou maior que dez";
            }
            else
            {
                txtN3.Text = "É um número igual ou menor que dez";
            }
        }

        private void btnConta_Click(object sender, EventArgs e)
        {
            
            
            for (int i = 0; i < 10; i++) ;
            {
                //txtResultado.Text = i++.ToString();
                MessageBox.Show(i.ToString());
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

            

        






