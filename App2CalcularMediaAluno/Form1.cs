using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App2CalcularMediaAluno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void calcularMedia1()
        {
            try
            {
                double nota1 = Convert.ToDouble(inputBim1Cmp1.Text);
                double nota2 = Convert.ToDouble(inputBim2Cmp1.Text);
                double nota3 = Convert.ToDouble(inputBim3Cmp1.Text);
                double nota4 = Convert.ToDouble(inputBim4Cmp1.Text);
                double media = (nota1 + nota2 + nota3 + nota4) / 4;

                if (nota1 > 10 || nota2 > 10 || nota3 > 10 || nota4 > 10)
                {
                    MessageBox.Show("Como voce tirou mais de 10?");
                    mediaFinalRes.Text = "";
                    return;
                }


                if (media >= 7)
                {
                    mediaFinalRes.ForeColor = Color.Green;
                }
                else
                {
                    mediaFinalRes.ForeColor = Color.Red;
                }

                mediaFinalRes.Text = media.ToString();


            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao calcular a média: " + error.Message);
            }
        }

        public void calcularMedia2()
        {
            try
            {
                double nota1 = Convert.ToDouble(inputBim1Cmp2.Text);
                double nota2 = Convert.ToDouble(inputBim2Cmp2.Text);
                double nota3 = Convert.ToDouble(inputBim3Cmp2.Text);
                double nota4 = Convert.ToDouble(inputBim4Cmp2.Text);
                double media = (nota1 + nota2 + nota3 + nota4) / 4;

                if (nota1 > 10 || nota2 > 10 || nota3 > 10 || nota4 > 10)
                {
                    MessageBox.Show("Como voce tirou mais de 10?");
                    mediaFinalRes2.Text = "";
                    return;
                }

                if (media >= 7)
                {
                    mediaFinalRes2.ForeColor = Color.Green;
                }
                else
                {
                    mediaFinalRes2.ForeColor = Color.Red;
                }

                mediaFinalRes2.Text = media.ToString();

            } catch (Exception error)
            {
                MessageBox.Show("Erro ao calcular a média: " + error.Message);
            }
        }


        private void calcularBtn_Click(object sender, EventArgs e)
        {
            calcularMedia1();
            calcularMedia2();
        }
    }
}
