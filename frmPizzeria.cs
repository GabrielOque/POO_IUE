using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizzeria
{
    public partial class frmPizzeria : Form
    {
        double Total = 0;
        public frmPizzeria()
        {
            InitializeComponent();
        }

        private void frmPizzeria_Load(object sender, EventArgs e)
        {
         

        }

        private void rdbPersonal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)

        {
            if (this.rdbPersonal.Checked)
            {
                Total = 4000;
            }
            if (this.rdbMesdiana.Checked)
            {
                Total = 4000;
            }
            if (this.rdbFamiliar.Checked)
            {
                Total = 4000;
            }
            if (this.rdbMFamiliar.Checked)
            {
                Total = 4000;
            }

            if (cmbMasa.SelectedIndex==0)
            {
                Total *= 1.05; 
            }
            if (cmbMasa.SelectedIndex == 2)
            {
                Total *= 1.08; 
            }

            if (this.rdbVegatareiana.Checked)
            {
                Total *= 1.03; 
            }
            if (this.rdbItaliana.Checked)
            {
                Total *= 1.15; 
            }

            if (this.rdbAntioquena.Checked)
            {
                Total  *= 1.18; 
            }

            if (this.rdbHawiana.Checked)
            {
                Total *= 1.20; 
            }


            if (this.cheAceitunas.Checked)
            {
                Total += 5000;
            }
            if (this.cheChanpinones.Checked)
            {
                Total += 5000;
            }
            if (this.cheJalapeno.Checked)
            {
                Total += 5000;
            }
            if (this.chePeperoni.Checked)
            {
                Total += 5000;
            }
            if (this.chePina.Checked)
            {
                Total += 5000;
            }
            if (this.chePollo.Checked)
            {
                Total += 5000;
            }
            if (this.cheQueso.Checked)
            {
                Total += 5000;
            }
            if (this.cheTocineta.Checked)
            {
                Total += 5000;
            }

            txtTotal.Text = Total.ToString();

        }
    }
}
