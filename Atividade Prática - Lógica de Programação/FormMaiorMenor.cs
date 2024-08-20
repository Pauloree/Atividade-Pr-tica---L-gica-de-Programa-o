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

            valor01 = int.Parse(tb01.Text);
            valor02 = int.Parse(tb02.Text);
            valor03 = int.Parse(tb03.Text);

            if (valor01 > valor02 && valor01 > valor03)
            {
                lbmaior.Text = valor01.ToString();
            } else if (valor02 > valor01 && valor02 > valor03)
            {
                lbmaior.Text = valor02.ToString();
            } else if (valor03 > valor01 && valor03 > valor02)
            {
                lbmaior.Text = valor03.ToString();
            }


            if (valor01 < valor02 && valor01 < valor03)
            {
                lbmenor.Text = valor01.ToString();
            }
            else if (valor02 < valor01 && valor02 < valor03)
            {
                lbmenor.Text = valor02.ToString();
            }
            else
            {
                lbmenor.Text = valor03.ToString();
            }
        }
    }
}
