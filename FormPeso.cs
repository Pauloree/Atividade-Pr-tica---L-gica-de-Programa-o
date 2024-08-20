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
    public partial class FormPeso : Form
    {
        public FormPeso()
        {
            InitializeComponent();
        }

        private void btcalcular_Click(object sender, EventArgs e)
        {

            //Definição das variáveis
            double pesoTerra, resul;

            //Entrada do peso digitado pelo usuário através da TextBox
            pesoTerra = double.Parse(tbpeso.Text);

            //Condicional if else para validar o planeta selecionado pelo usuário, mudando os valores do cálculo
            if (rbmerc.Checked == true )
            {
               resul = pesoTerra * 0.37;

                MessageBox.Show("Este seria seu peso no Planeta Mercúrio: " + Math.Round(resul, 2));
            }
            else if (rbmar.Checked == true)
            {
                resul = pesoTerra * 0.38;

                MessageBox.Show("Este seria seu peso no Planeta Marte: " + Math.Round(resul, 2));
            }
            else if (rbven.Checked == true)
            {
                resul = pesoTerra * 0.88;

                MessageBox.Show("Este seria seu peso no Planeta Vênus: " + Math.Round(resul, 2));
            }
            else if (rbjup.Checked == true)
            {
                resul = pesoTerra * 2.64;

                MessageBox.Show("Este seria seu peso no Planeta Júpiter: " + Math.Round(resul, 2));
            }
            else if (rbsat.Checked == true)
            {
                resul = pesoTerra * 1.15;

                MessageBox.Show("Este seria seu peso no Planeta Saturno: " + Math.Round(resul, 2));
            }
            else if (rbura.Checked == true)
            {
                resul = pesoTerra * 1.17;

                MessageBox.Show("Este seria seu peso no Planeta Urano: " + Math.Round(resul, 2));
            }
        }
    }
}
