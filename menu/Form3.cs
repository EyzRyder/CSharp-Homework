using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu
{
    public partial class frmPastelaria : Form
    {
        public frmPastelaria()
        {
            InitializeComponent();
        }

        private void grbBebida_Enter(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void rdbRefri_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbCerv_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbSuco_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbCana_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbAgua_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbNenhum_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CkbCarne_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbCarne.Checked == true)
            {
                lblQuantidade.Enable = true;
            }
            else
            {
                txtPcarne.Visible = false;
                txtPcarne.Text = "0";
            }
        }

        private void CkbCarneQ_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CkbFrango_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CkbFrangoQ_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CkbPizza_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CkbEscarola_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CkbPalmito_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Ckbbacalhau_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CkbCalabresa_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CkbCalabresaQ_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CkbCarneS_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CkbModa_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbxFPag_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rdbMesa_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbDelivery_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtServ_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEntrega_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPago_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTroco_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblValor_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void nudCarne_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudCarneQ_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudFrango_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudFrangoQ_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudPizza_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudEscarola_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudBacalhau_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudCalabresa_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudCalabresaQ_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudCarneS_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudModa_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
