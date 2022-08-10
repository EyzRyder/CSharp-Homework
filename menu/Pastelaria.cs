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
        double valor;
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
                nudCarne.Enabled = true;
                nudCarne.Value = 1;
            }
            else
            {
                nudCarne.Enabled = false;
                nudCarne.Value = 0;
            }
        }

        private void CkbCarneQ_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbCarneQ.Checked == true)
            {
                nudCarneQ.Enabled = true;
                nudCarneQ.Value = 1;
            }
            else
            {
                nudCarneQ.Enabled = false;
                nudCarneQ.Value = 0;
            }
        }

        private void CkbFrango_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbFrango.Checked == true)
            {
                nudFrango.Enabled = true;
                nudFrango.Value = 1;
            }
            else
            {
                nudFrango.Enabled = false;
                nudFrango.Value = 0;
            }
        }

        private void CkbFrangoQ_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbFrangoQ.Checked == true)
            {
                nudFrangoQ.Enabled = true;
                nudFrangoQ.Value = 1;
            }
            else
            {
                nudFrangoQ.Enabled = false;
                nudFrangoQ.Value = 0;
            }
        }

        private void CkbPizza_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbPizza.Checked == true)
            {
                nudPizza.Enabled = true;
                nudPizza.Value = 1;
            }
            else
            {
                nudPizza.Enabled = false;
                nudPizza.Value = 0;
            }
        }

        private void CkbEscarola_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbEscarola.Checked == true)
            {
                nudEscarola.Enabled = true;
                nudEscarola.Value = 1;
            }
            else
            {
                nudEscarola.Enabled = false;
                nudEscarola.Value = 0;
            }
        }

        private void CkbPalmito_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbPalmito.Checked == true)
            {
                nudPalmito.Enabled = true;
                nudPalmito.Value = 1;
            }
            else
            {
                nudPalmito.Enabled = false;
                nudPalmito.Value = 0;
            }
        }

        private void Ckbbacalhau_CheckedChanged(object sender, EventArgs e)
        {
            if (Ckbbacalhau.Checked == true)
            {
                nudBacalhau.Enabled = true;
                nudBacalhau.Value = 1;
            }
            else
            {
                nudBacalhau.Enabled = false;
                nudBacalhau.Value = 0;
            }
        }

        private void CkbCalabresa_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbCalabresa.Checked == true)
            {
                nudCalabresa.Enabled = true;
                nudCalabresa.Value = 1;
            }
            else
            {
                nudCalabresa.Enabled = false;
                nudCalabresa.Value = 0;
            }
        }

        private void CkbCalabresaQ_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbCalabresaQ.Checked == true)
            {
                nudCalabresaQ.Enabled = true;
                nudCalabresaQ.Value = 1;
            }
            else
            {
                nudCalabresaQ.Enabled = false;
                nudCalabresaQ.Value = 0;
            }
        }

        private void CkbCarneS_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbCarneS.Checked == true)
            {
                nudCarneS.Enabled = true;
                nudCarneS.Value = 1;
            }
            else
            {
                nudCarneS.Enabled = false;
                nudCarneS.Value = 0;
            }
        }

        private void CkbModa_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbModa.Checked == true)
            {
                nudModa.Enabled = true;
                nudModa.Value = 1;
            }
            else
            {
                nudModa.Enabled = false;
                nudModa.Value = 0;
            }
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
            if (txtPago.Text == "0" || txtPago.Text == "")
            {
                btnPagar.Enabled = false;
            }
            else
            {
                btnPagar.Enabled = true;
            }
        }

        private void txtTroco_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            rdbNenhum.Checked = true;
            CkbCarne.Checked = false;
            CkbCarneQ.Checked = false;
            CkbFrango.Checked = false;
            CkbFrangoQ.Checked = false;
            CkbPizza.Checked = false;
            CkbCalabresa.Checked = false;
            CkbCalabresaQ.Checked = false;
            CkbPalmito.Checked = false;
            CkbCarneS.Checked = false;
            CkbModa.Checked = false;
            rdbMesa.Checked = false;
            rdbDelivery.Checked = false;
            txtEntrega.Text = "0";
            txtTotal.Text = "0";
            txtPago.Text = "0";
            txtTroco.Text = "0";
            txtEntrega.Text = " ";
            txtServ.Text = " ";
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

        private void frmPastelaria_Load(object sender, EventArgs e)
        {

        }

        private void nudBacalhau_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btncal_Click(object sender, EventArgs e)
        {
            valor = 0;
            double valorparcial = 0;

            if (rdbRefri.Checked == true)
            {
                valor += 10;
            }
            if (rdbCerv.Checked == true)
            {
                valor += 12;
            }
            if (rdbSuco.Checked == true)
            {
                valor += 11;
            }
            if (rdbCana.Checked == true)
            {
                valor += 7;
            }
            if (rdbAgua.Checked == true)
            {
                valor += 5;
            }

            if (CkbCarne.Checked == true)
            {
                valor += Convert.ToDouble(nudCarne.Value) * 5;
            }
            if (CkbCarneQ.Checked == true)
            {
                valor += Convert.ToDouble(nudCarneQ.Value) * 7;
            }
            if (CkbFrango.Checked == true)
            {
                valor += Convert.ToDouble(nudFrango.Value) * 5;
            }
            if (CkbFrangoQ.Checked == true)
            {
                valor += Convert.ToDouble(nudFrangoQ.Value) * 7;
            }
            if (CkbPizza.Checked == true)
            {
                valor += Convert.ToDouble(nudPizza.Value) * 6.5;
            }
            if (CkbCalabresa.Checked == true)
            {
                valor += Convert.ToDouble(nudCalabresa.Value) * 6;
            }
            if (CkbCalabresaQ.Checked == true)
            {
                valor += Convert.ToDouble(nudCalabresaQ.Value) * 8;
            }
            if (CkbPalmito.Checked == true)
            {
                valor += Convert.ToDouble(nudPalmito.Value) * 7;
            }
            if (CkbCarneS.Checked == true)
            {
                valor += Convert.ToDouble(nudCarneS.Value) * 5;
            }
            if (CkbModa.Checked == true)
            {
                valor += Convert.ToDouble(nudModa.Value) * 10;
            }

            if (cbxFPag.Text == "A Vista / Dinheiro")
            {
                valor -= valor * 0.05;
            }
            if (cbxFPag.Text == "Cartão de Crédito")
            {
                valor += valor * 0.05;
            }
            if (cbxFPag.Text == "PIX")
            {
                valor += valor * 0.02;
            }

            if (rdbMesa.Checked == true)
            {
                valorparcial = valor * 0.1;
                valor = valor + valorparcial;
                txtServ.Text = "R$" + Convert.ToString(valorparcial);
                txtEntrega.Text = "0";
            }
            if (rdbDelivery.Checked == true)
            {
                valorparcial = valor * 0.05;
                valor = valor + valorparcial;
                txtEntrega.Text = "R$" + Convert.ToString(valorparcial);
                txtServ.Text = "0";
            }

            txtTotal.Text = "R$" + Convert.ToString(valor);

        }

        private void cbxFPag_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grbFValorP_Enter(object sender, EventArgs e)
        {

        }

        private void txtServ_Click(object sender, EventArgs e)
        {

        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (txtPago.Text == "" || Convert.ToDouble(txtPago.Text) < valor)
            {
                MessageBox.Show("Valor Inválido ou Insuficiente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (Convert.ToDouble(txtPago.Text) >= valor)
            {
                txtTroco.Text = "R$" + (Convert.ToDouble(txtPago.Text) - valor);
            }
        }
    }
    }