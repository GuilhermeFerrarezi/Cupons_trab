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
    public partial class Resultado : Form
    {
        public Resultado()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.Filtros2.Visible == false)
            {
                this.Filtros2.Visible = true;
                this.bfiltros2.Text = "Filtros <";
            }
            else
            {
                this.Filtros2.Visible = false;
                this.bfiltros2.Text = "Filtros >";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Resultado_Load(object sender, EventArgs e)
        {
            this.Filtros2.Visible = false;
            this.Nike.Visible = false;
            this.imgnike.Visible = false;
            this.iFood.Visible = false;
            this.imgifood.Visible = false;
            this.Samsung.Visible =false;
            this.imgsam.Visible = false;
            this.Apple.Visible = false;
            this.imgapple.Visible = false;
            this.Amazon.Visible = false;
            this.imgamaz.Visible = false;
            
            if (Filtros2.CheckedIndices.Contains(0) && Filtros2.CheckedIndices.Contains(1) && Filtros2.CheckedIndices.Contains(2)) 
            {
                this.Nike.Visible = true;
                this.imgnike.Visible = true;
                this.iFood.Visible = true;
                this.imgifood.Visible = true;
                this.Samsung.Visible = true;
                this.imgsam.Visible = true;
                this.Apple.Visible = true;
                this.imgapple.Visible = true;
                this.Amazon.Visible = true;
                this.imgamaz.Visible = true;
            }
            else if (Filtros2.CheckedIndices.Contains(0) && Filtros2.CheckedIndices.Contains(1))
            {
                this.Nike.Visible = true;
                this.imgnike.Visible = true;
                this.iFood.Visible = true;
                this.imgifood.Visible = true;
                this.Samsung.Visible = true;
                this.imgsam.Visible = true;
                this.Amazon.Visible = true;
                this.imgamaz.Visible = true;
            }
            else if (Filtros2.CheckedIndices.Contains(1) && Filtros2.CheckedIndices.Contains(2))
            {
                this.Samsung.Visible = true;
                this.imgsam.Visible = true;
                this.Amazon.Visible = true;
                this.imgamaz.Visible = true;
                this.Apple.Visible = true;
                this.imgapple.Visible = true;
            }
            else if (Filtros2.CheckedIndices.Contains(0) && Filtros2.CheckedIndices.Contains(2))
            {
                this.Nike.Visible = true;
                this.imgnike.Visible = true;
                this.iFood.Visible = true;
                this.imgifood.Visible = true;
                this.Apple.Visible = true;
                this.imgapple.Visible = true;
            }
            else if (Filtros2.CheckedIndices.Contains(0))
            {
                this.Nike.Visible = true;
                this.imgnike.Visible = true;
                this.iFood.Visible = true;
                this.imgifood.Visible = true;
            }
            else if (Filtros2.CheckedIndices.Contains(1))
            {
               this.Samsung.Visible = true;
               this.imgsam.Visible = true;
               this.Amazon.Visible = true;
               this.imgamaz.Visible = true;
            }
            else if (Filtros2.CheckedIndices.Contains(2))
            {
                this.Apple.Visible = true;
                this.imgapple.Visible = true;
            }
            else
            {
                this.Nike.Visible = true;
                this.imgnike.Visible = true;
                this.iFood.Visible = true;
                this.imgifood.Visible = true;
                this.Samsung.Visible = true;
                this.imgsam.Visible = true;
                this.Apple.Visible = true;
                this.imgapple.Visible = true;
                this.Amazon.Visible = true;
                this.imgamaz.Visible = true;
            }
        }

        private void Samsung_Click(object sender, EventArgs e)
        {

        }
    }
}
