using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_Prática___Lógica_de_Programação
{
    public partial class FormMaiorMenor : Form
    {
        public FormMaiorMenor()
        {
            InitializeComponent();
        }

        private void btcalcular_Click(object sender, EventArgs e)
        {
            int valor01, valor02, valor03;

            //Recebe os valores digitados pelo usuário e armazena nas variáveis
            valor01 = int.Parse(tb01.Text);
            valor02 = int.Parse(tb02.Text);
            valor03 = int.Parse(tb03.Text);


            //Analisa qual número é maior ou menor e armazena nas variáveis maior e menor
            int maior = valor01;

            if (valor02 > maior)
            {
                maior = valor02;

            }
            if (valor03 > maior)
            {
                maior = valor03;
            } else
            {
                //Exibe uma mensagem caso todos números sejam iguais
                MessageBox.Show("Todos os números são iguais.");
            }

            int menor = valor01;

            if (valor02 < menor)
            {
                menor = valor02;
            }
            if (valor03 < menor)
            {
                menor = valor03;
            }

            //Exibe o resultado ao usuário com base na estrutura condicional acima
            lbmaior.Text = maior.ToString();
            lbmenor.Text = menor.ToString();
        }

    }
}
