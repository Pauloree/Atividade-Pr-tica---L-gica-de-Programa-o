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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new FormMaiorMenor().ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            new FormMaiorMenor().ShowDialog();

        }

        private void maiorEMenorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormMaiorMenor().ShowDialog();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new Form1().ShowDialog();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            new Form1().ShowDialog();
        }

        private void placarDeResultadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form1().ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new FormPeso().ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            new FormPeso().ShowDialog();
        }

        private void pesoRelativoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormPeso().ShowDialog();
        }
    }
}
