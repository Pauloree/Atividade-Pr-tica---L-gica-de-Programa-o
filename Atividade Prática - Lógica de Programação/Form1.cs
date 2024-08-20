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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btcalculo_Click(object sender, EventArgs e)
        {
            int placar1, placar2, placar3, placar4, placar5, placar6, placar7, placar8, placar9, placar10, placar11, placar12;          

            placar1 = int.Parse(tb1.Text);
            placar2 = int.Parse(tb2.Text);
            placar3 = int.Parse(tb3.Text);
            placar4 = int.Parse(tb4.Text);
            placar5 = int.Parse(tb5.Text);
            placar6 = int.Parse(tb6.Text); 
            placar7 = int.Parse(tb7.Text);
            placar8 = int.Parse(tb8.Text);
            placar9 = int.Parse(tb9.Text);
            placar10 = int.Parse(tb10.Text);
            placar11 = int.Parse(tb11.Text);
            placar12 = int.Parse(tb12.Text);
            
           
            if (placar1 > placar2)
            {
                lb1.Text = "Barcelona";
            }
            else if (placar1 < placar2)
            {
                lb1.Text = "Real Madrid";
            }
            else
            {
                lb1.Text = "Empate";
            }
            //
            if (placar3 > placar4)
            {
                lb2.Text = "Manchester U.";
            }
            else if (placar3 < placar4)
            {
                lb2.Text = "Napoli";
            }
            else
            {
                lb2.Text = "Empate";
            }

            if (placar5 > placar6)
            {
                lb3.Text = "Chelsea";
            }
            else if (placar5 < placar6)
            {
                lb3.Text = "Inter de Milão";
            }
            else
            {
                lb3.Text = "Empate";
            }


            if (placar7 > placar8)
            {
                lb4.Text = "Liverpool";
            }
            else if (placar7 < placar8)
            {
                lb4.Text = "Bayern de Munich";
            }
            else
            {
                lb4.Text = "Empate";
            }


            if (placar9 > placar10)
            {
                lb5.Text = "Juventus";
            }
            else if (placar9 < placar10)
            {
                lb5.Text = "Manchester City";
            }
            else
            {
                lb5.Text = "Empate";
            }


            if (placar11 > placar12)
            {
                lb6.Text ="PSG";
            }
            else if (placar11 < placar12)
            {
                lb6.Text = "Lyon";
            }
            else
            {
                lb6.Text = "Empate";
            }



        }
    }
}
