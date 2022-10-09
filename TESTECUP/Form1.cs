using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TESTECUP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Resultado OutroForm = new Resultado();

        private void button1_Click(object sender, EventArgs e)
        {

            if (Filtros.CheckedIndices.Contains(0) && Filtros.CheckedIndices.Contains(1))
            {
                Pesquisa.Text = "teste";
                
                OutroForm.Pesquisa.Text = this.Pesquisa.Text;
               
            }
            else
            {
                Pesquisa.Text = "";
            }
            for (int i = 0; i <= 2; i++)
            {
                if (Filtros.CheckedIndices.Contains(i))
                {
                    OutroForm.Filtros2.SetItemChecked(i, true);
                }
                else
                {
                    OutroForm.Filtros2.SetItemChecked(i, false);
                }
            }
            OutroForm.ShowDialog();

        }

        private void Filtros_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.Filtros.Visible == false)
            {
                this.Filtros.Visible = true;
                this.bfiltros.Text = "Filtros <";
            }
            else
            {
                this.Filtros.Visible = false;
                this.bfiltros.Text = "Filtros >";
            }
        }
    }
}
