
namespace menu
{
    partial class frmPastelaria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grbBebida = new System.Windows.Forms.GroupBox();
            this.rdbRefri = new System.Windows.Forms.RadioButton();
            this.rdbCerv = new System.Windows.Forms.RadioButton();
            this.rdbSuco = new System.Windows.Forms.RadioButton();
            this.rdbNenhum = new System.Windows.Forms.RadioButton();
            this.rdbAgua = new System.Windows.Forms.RadioButton();
            this.rdbCana = new System.Windows.Forms.RadioButton();
            this.grbPastel = new System.Windows.Forms.GroupBox();
            this.grbFPag = new System.Windows.Forms.GroupBox();
            this.grbFServ = new System.Windows.Forms.GroupBox();
            this.grbFValorP = new System.Windows.Forms.GroupBox();
            this.grbFValor = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblQtd = new System.Windows.Forms.Label();
            this.CkbCarne = new System.Windows.Forms.CheckBox();
            this.CkbCarneQ = new System.Windows.Forms.CheckBox();
            this.CkbFrango = new System.Windows.Forms.CheckBox();
            this.CkbFrangoQ = new System.Windows.Forms.CheckBox();
            this.CkbPizza = new System.Windows.Forms.CheckBox();
            this.CkbEscarola = new System.Windows.Forms.CheckBox();
            this.CkbPalmito = new System.Windows.Forms.CheckBox();
            this.Ckbbacalhau = new System.Windows.Forms.CheckBox();
            this.CkbCalabresa = new System.Windows.Forms.CheckBox();
            this.CkbCalabresaQ = new System.Windows.Forms.CheckBox();
            this.CkbCarneS = new System.Windows.Forms.CheckBox();
            this.CkbModa = new System.Windows.Forms.CheckBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.cbxFPag = new System.Windows.Forms.ComboBox();
            this.rdbMesa = new System.Windows.Forms.RadioButton();
            this.rdbDelivery = new System.Windows.Forms.RadioButton();
            this.lblserv = new System.Windows.Forms.Label();
            this.lblEntrega = new System.Windows.Forms.Label();
            this.txtServ = new System.Windows.Forms.TextBox();
            this.txtEntrega = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPago = new System.Windows.Forms.Label();
            this.lblTroco = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.txtTroco = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.grbBebida.SuspendLayout();
            this.grbPastel.SuspendLayout();
            this.grbFPag.SuspendLayout();
            this.grbFServ.SuspendLayout();
            this.grbFValorP.SuspendLayout();
            this.grbFValor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(52, 47);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(75, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Pastel Apenas";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // grbBebida
            // 
            this.grbBebida.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grbBebida.Controls.Add(this.rdbNenhum);
            this.grbBebida.Controls.Add(this.rdbAgua);
            this.grbBebida.Controls.Add(this.rdbCana);
            this.grbBebida.Controls.Add(this.rdbSuco);
            this.grbBebida.Controls.Add(this.rdbCerv);
            this.grbBebida.Controls.Add(this.rdbRefri);
            this.grbBebida.Location = new System.Drawing.Point(27, 90);
            this.grbBebida.Name = "grbBebida";
            this.grbBebida.Size = new System.Drawing.Size(329, 100);
            this.grbBebida.TabIndex = 1;
            this.grbBebida.TabStop = false;
            this.grbBebida.Text = "Bebida Garrafa";
            this.grbBebida.Enter += new System.EventHandler(this.grbBebida_Enter);
            // 
            // rdbRefri
            // 
            this.rdbRefri.AutoSize = true;
            this.rdbRefri.Location = new System.Drawing.Point(16, 29);
            this.rdbRefri.Name = "rdbRefri";
            this.rdbRefri.Size = new System.Drawing.Size(83, 17);
            this.rdbRefri.TabIndex = 0;
            this.rdbRefri.TabStop = true;
            this.rdbRefri.Text = "Refrigerante";
            this.rdbRefri.UseVisualStyleBackColor = true;
            // 
            // rdbCerv
            // 
            this.rdbCerv.AutoSize = true;
            this.rdbCerv.Location = new System.Drawing.Point(130, 29);
            this.rdbCerv.Name = "rdbCerv";
            this.rdbCerv.Size = new System.Drawing.Size(61, 17);
            this.rdbCerv.TabIndex = 1;
            this.rdbCerv.TabStop = true;
            this.rdbCerv.Text = "Cerveja";
            this.rdbCerv.UseVisualStyleBackColor = true;
            // 
            // rdbSuco
            // 
            this.rdbSuco.AutoSize = true;
            this.rdbSuco.Location = new System.Drawing.Point(221, 29);
            this.rdbSuco.Name = "rdbSuco";
            this.rdbSuco.Size = new System.Drawing.Size(50, 17);
            this.rdbSuco.TabIndex = 2;
            this.rdbSuco.TabStop = true;
            this.rdbSuco.Text = "Suco";
            this.rdbSuco.UseVisualStyleBackColor = true;
            // 
            // rdbNenhum
            // 
            this.rdbNenhum.AutoSize = true;
            this.rdbNenhum.Location = new System.Drawing.Point(221, 64);
            this.rdbNenhum.Name = "rdbNenhum";
            this.rdbNenhum.Size = new System.Drawing.Size(65, 17);
            this.rdbNenhum.TabIndex = 5;
            this.rdbNenhum.TabStop = true;
            this.rdbNenhum.Text = "Nenhum";
            this.rdbNenhum.UseVisualStyleBackColor = true;
            // 
            // rdbAgua
            // 
            this.rdbAgua.AutoSize = true;
            this.rdbAgua.Location = new System.Drawing.Point(130, 64);
            this.rdbAgua.Name = "rdbAgua";
            this.rdbAgua.Size = new System.Drawing.Size(50, 17);
            this.rdbAgua.TabIndex = 4;
            this.rdbAgua.TabStop = true;
            this.rdbAgua.Text = "Agua";
            this.rdbAgua.UseVisualStyleBackColor = true;
            // 
            // rdbCana
            // 
            this.rdbCana.AutoSize = true;
            this.rdbCana.Location = new System.Drawing.Point(16, 64);
            this.rdbCana.Name = "rdbCana";
            this.rdbCana.Size = new System.Drawing.Size(95, 17);
            this.rdbCana.TabIndex = 3;
            this.rdbCana.TabStop = true;
            this.rdbCana.Text = "Caldo de Cana";
            this.rdbCana.UseVisualStyleBackColor = true;
            // 
            // grbPastel
            // 
            this.grbPastel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grbPastel.Controls.Add(this.textBox9);
            this.grbPastel.Controls.Add(this.textBox10);
            this.grbPastel.Controls.Add(this.textBox11);
            this.grbPastel.Controls.Add(this.textBox12);
            this.grbPastel.Controls.Add(this.textBox5);
            this.grbPastel.Controls.Add(this.textBox6);
            this.grbPastel.Controls.Add(this.textBox7);
            this.grbPastel.Controls.Add(this.textBox8);
            this.grbPastel.Controls.Add(this.textBox4);
            this.grbPastel.Controls.Add(this.textBox3);
            this.grbPastel.Controls.Add(this.textBox2);
            this.grbPastel.Controls.Add(this.textBox1);
            this.grbPastel.Controls.Add(this.CkbModa);
            this.grbPastel.Controls.Add(this.CkbCarneS);
            this.grbPastel.Controls.Add(this.CkbCalabresaQ);
            this.grbPastel.Controls.Add(this.CkbCalabresa);
            this.grbPastel.Controls.Add(this.Ckbbacalhau);
            this.grbPastel.Controls.Add(this.CkbPalmito);
            this.grbPastel.Controls.Add(this.CkbEscarola);
            this.grbPastel.Controls.Add(this.CkbPizza);
            this.grbPastel.Controls.Add(this.CkbFrangoQ);
            this.grbPastel.Controls.Add(this.CkbFrango);
            this.grbPastel.Controls.Add(this.CkbCarneQ);
            this.grbPastel.Controls.Add(this.CkbCarne);
            this.grbPastel.Controls.Add(this.lblQtd);
            this.grbPastel.Controls.Add(this.lblTipo);
            this.grbPastel.Location = new System.Drawing.Point(27, 217);
            this.grbPastel.Name = "grbPastel";
            this.grbPastel.Size = new System.Drawing.Size(329, 344);
            this.grbPastel.TabIndex = 6;
            this.grbPastel.TabStop = false;
            this.grbPastel.Text = "Pastel";
            // 
            // grbFPag
            // 
            this.grbFPag.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grbFPag.Controls.Add(this.cbxFPag);
            this.grbFPag.Location = new System.Drawing.Point(362, 90);
            this.grbFPag.Name = "grbFPag";
            this.grbFPag.Size = new System.Drawing.Size(329, 100);
            this.grbFPag.TabIndex = 7;
            this.grbFPag.TabStop = false;
            this.grbFPag.Text = "Forma de Pagamento";
            // 
            // grbFServ
            // 
            this.grbFServ.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grbFServ.Controls.Add(this.rdbDelivery);
            this.grbFServ.Controls.Add(this.rdbMesa);
            this.grbFServ.Location = new System.Drawing.Point(362, 217);
            this.grbFServ.Name = "grbFServ";
            this.grbFServ.Size = new System.Drawing.Size(329, 100);
            this.grbFServ.TabIndex = 8;
            this.grbFServ.TabStop = false;
            this.grbFServ.Text = "Tipo de Serviço";
            this.grbFServ.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // grbFValorP
            // 
            this.grbFValorP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grbFValorP.Controls.Add(this.txtEntrega);
            this.grbFValorP.Controls.Add(this.txtServ);
            this.grbFValorP.Controls.Add(this.lblEntrega);
            this.grbFValorP.Controls.Add(this.lblserv);
            this.grbFValorP.Location = new System.Drawing.Point(362, 338);
            this.grbFValorP.Name = "grbFValorP";
            this.grbFValorP.Size = new System.Drawing.Size(329, 100);
            this.grbFValorP.TabIndex = 8;
            this.grbFValorP.TabStop = false;
            this.grbFValorP.Text = "Valor Parcial";
            // 
            // grbFValor
            // 
            this.grbFValor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grbFValor.Controls.Add(this.txtTroco);
            this.grbFValor.Controls.Add(this.txtPago);
            this.grbFValor.Controls.Add(this.txtTotal);
            this.grbFValor.Controls.Add(this.lblTroco);
            this.grbFValor.Controls.Add(this.lblPago);
            this.grbFValor.Controls.Add(this.lblTotal);
            this.grbFValor.Location = new System.Drawing.Point(362, 444);
            this.grbFValor.Name = "grbFValor";
            this.grbFValor.Size = new System.Drawing.Size(329, 100);
            this.grbFValor.TabIndex = 8;
            this.grbFValor.TabStop = false;
            this.grbFValor.Text = "Valor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 9;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(28, 33);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 1;
            this.lblTipo.Text = "Tipo";
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Location = new System.Drawing.Point(185, 33);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(62, 13);
            this.lblQtd.TabIndex = 2;
            this.lblQtd.Text = "Quantidade";
            // 
            // CkbCarne
            // 
            this.CkbCarne.AutoSize = true;
            this.CkbCarne.Location = new System.Drawing.Point(28, 65);
            this.CkbCarne.Name = "CkbCarne";
            this.CkbCarne.Size = new System.Drawing.Size(54, 17);
            this.CkbCarne.TabIndex = 3;
            this.CkbCarne.Text = "Carne";
            this.CkbCarne.UseVisualStyleBackColor = true;
            // 
            // CkbCarneQ
            // 
            this.CkbCarneQ.AutoSize = true;
            this.CkbCarneQ.Location = new System.Drawing.Point(28, 88);
            this.CkbCarneQ.Name = "CkbCarneQ";
            this.CkbCarneQ.Size = new System.Drawing.Size(101, 17);
            this.CkbCarneQ.TabIndex = 4;
            this.CkbCarneQ.Text = "Carne c/ Queijo";
            this.CkbCarneQ.UseVisualStyleBackColor = true;
            // 
            // CkbFrango
            // 
            this.CkbFrango.AutoSize = true;
            this.CkbFrango.Location = new System.Drawing.Point(28, 111);
            this.CkbFrango.Name = "CkbFrango";
            this.CkbFrango.Size = new System.Drawing.Size(59, 17);
            this.CkbFrango.TabIndex = 5;
            this.CkbFrango.Text = "Frango";
            this.CkbFrango.UseVisualStyleBackColor = true;
            // 
            // CkbFrangoQ
            // 
            this.CkbFrangoQ.AutoSize = true;
            this.CkbFrangoQ.Location = new System.Drawing.Point(28, 134);
            this.CkbFrangoQ.Name = "CkbFrangoQ";
            this.CkbFrangoQ.Size = new System.Drawing.Size(123, 17);
            this.CkbFrangoQ.TabIndex = 6;
            this.CkbFrangoQ.Text = "Frango com Catupiry";
            this.CkbFrangoQ.UseVisualStyleBackColor = true;
            // 
            // CkbPizza
            // 
            this.CkbPizza.AutoSize = true;
            this.CkbPizza.Location = new System.Drawing.Point(28, 157);
            this.CkbPizza.Name = "CkbPizza";
            this.CkbPizza.Size = new System.Drawing.Size(51, 17);
            this.CkbPizza.TabIndex = 7;
            this.CkbPizza.Text = "Pizza";
            this.CkbPizza.UseVisualStyleBackColor = true;
            // 
            // CkbEscarola
            // 
            this.CkbEscarola.AutoSize = true;
            this.CkbEscarola.Location = new System.Drawing.Point(28, 180);
            this.CkbEscarola.Name = "CkbEscarola";
            this.CkbEscarola.Size = new System.Drawing.Size(67, 17);
            this.CkbEscarola.TabIndex = 8;
            this.CkbEscarola.Text = "Escarola";
            this.CkbEscarola.UseVisualStyleBackColor = true;
            // 
            // CkbPalmito
            // 
            this.CkbPalmito.AutoSize = true;
            this.CkbPalmito.Location = new System.Drawing.Point(28, 203);
            this.CkbPalmito.Name = "CkbPalmito";
            this.CkbPalmito.Size = new System.Drawing.Size(60, 17);
            this.CkbPalmito.TabIndex = 9;
            this.CkbPalmito.Text = "Palmito";
            this.CkbPalmito.UseVisualStyleBackColor = true;
            // 
            // Ckbbacalhau
            // 
            this.Ckbbacalhau.AutoSize = true;
            this.Ckbbacalhau.Location = new System.Drawing.Point(28, 226);
            this.Ckbbacalhau.Name = "Ckbbacalhau";
            this.Ckbbacalhau.Size = new System.Drawing.Size(71, 17);
            this.Ckbbacalhau.TabIndex = 10;
            this.Ckbbacalhau.Text = "Bacalhau";
            this.Ckbbacalhau.UseVisualStyleBackColor = true;
            // 
            // CkbCalabresa
            // 
            this.CkbCalabresa.AutoSize = true;
            this.CkbCalabresa.Location = new System.Drawing.Point(28, 249);
            this.CkbCalabresa.Name = "CkbCalabresa";
            this.CkbCalabresa.Size = new System.Drawing.Size(73, 17);
            this.CkbCalabresa.TabIndex = 11;
            this.CkbCalabresa.Text = "Calabresa";
            this.CkbCalabresa.UseVisualStyleBackColor = true;
            // 
            // CkbCalabresaQ
            // 
            this.CkbCalabresaQ.AutoSize = true;
            this.CkbCalabresaQ.Location = new System.Drawing.Point(28, 272);
            this.CkbCalabresaQ.Name = "CkbCalabresaQ";
            this.CkbCalabresaQ.Size = new System.Drawing.Size(120, 17);
            this.CkbCalabresaQ.TabIndex = 12;
            this.CkbCalabresaQ.Text = "Calabresa c/ Queijo";
            this.CkbCalabresaQ.UseVisualStyleBackColor = true;
            // 
            // CkbCarneS
            // 
            this.CkbCarneS.AutoSize = true;
            this.CkbCarneS.Location = new System.Drawing.Point(28, 295);
            this.CkbCarneS.Name = "CkbCarneS";
            this.CkbCarneS.Size = new System.Drawing.Size(82, 17);
            this.CkbCarneS.TabIndex = 13;
            this.CkbCarneS.Text = "Carne Seca";
            this.CkbCarneS.UseVisualStyleBackColor = true;
            // 
            // CkbModa
            // 
            this.CkbModa.AutoSize = true;
            this.CkbModa.Location = new System.Drawing.Point(28, 318);
            this.CkbModa.Name = "CkbModa";
            this.CkbModa.Size = new System.Drawing.Size(63, 17);
            this.CkbModa.TabIndex = 14;
            this.CkbModa.Text = "A Moda";
            this.CkbModa.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(238, 583);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Cancelar";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(362, 583);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // cbxFPag
            // 
            this.cbxFPag.FormattingEnabled = true;
            this.cbxFPag.Items.AddRange(new object[] {
            "Avista/Dinheiro ",
            "Cartão de Debito ",
            "Cartão de crédito ",
            "Cheque"});
            this.cbxFPag.Location = new System.Drawing.Point(91, 39);
            this.cbxFPag.Name = "cbxFPag";
            this.cbxFPag.Size = new System.Drawing.Size(121, 21);
            this.cbxFPag.TabIndex = 12;
            this.cbxFPag.Text = "Selecione.....";
            // 
            // rdbMesa
            // 
            this.rdbMesa.AutoSize = true;
            this.rdbMesa.Location = new System.Drawing.Point(17, 33);
            this.rdbMesa.Name = "rdbMesa";
            this.rdbMesa.Size = new System.Drawing.Size(51, 17);
            this.rdbMesa.TabIndex = 0;
            this.rdbMesa.TabStop = true;
            this.rdbMesa.Text = "Mesa";
            this.rdbMesa.UseVisualStyleBackColor = true;
            // 
            // rdbDelivery
            // 
            this.rdbDelivery.AutoSize = true;
            this.rdbDelivery.Location = new System.Drawing.Point(17, 64);
            this.rdbDelivery.Name = "rdbDelivery";
            this.rdbDelivery.Size = new System.Drawing.Size(63, 17);
            this.rdbDelivery.TabIndex = 1;
            this.rdbDelivery.TabStop = true;
            this.rdbDelivery.Text = "Delivery";
            this.rdbDelivery.UseVisualStyleBackColor = true;
            // 
            // lblserv
            // 
            this.lblserv.AutoSize = true;
            this.lblserv.Location = new System.Drawing.Point(33, 36);
            this.lblserv.Name = "lblserv";
            this.lblserv.Size = new System.Drawing.Size(52, 13);
            this.lblserv.TabIndex = 0;
            this.lblserv.Text = "10% Serv";
            // 
            // lblEntrega
            // 
            this.lblEntrega.AutoSize = true;
            this.lblEntrega.Location = new System.Drawing.Point(33, 63);
            this.lblEntrega.Name = "lblEntrega";
            this.lblEntrega.Size = new System.Drawing.Size(44, 13);
            this.lblEntrega.TabIndex = 1;
            this.lblEntrega.Text = "Entrega";
            // 
            // txtServ
            // 
            this.txtServ.Enabled = false;
            this.txtServ.Location = new System.Drawing.Point(124, 36);
            this.txtServ.Name = "txtServ";
            this.txtServ.Size = new System.Drawing.Size(100, 20);
            this.txtServ.TabIndex = 2;
            this.txtServ.Text = "0";
            // 
            // txtEntrega
            // 
            this.txtEntrega.Enabled = false;
            this.txtEntrega.Location = new System.Drawing.Point(124, 63);
            this.txtEntrega.Name = "txtEntrega";
            this.txtEntrega.Size = new System.Drawing.Size(100, 20);
            this.txtEntrega.TabIndex = 3;
            this.txtEntrega.Text = "0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(33, 26);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total";
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Location = new System.Drawing.Point(33, 47);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(32, 13);
            this.lblPago.TabIndex = 1;
            this.lblPago.Text = "Pago";
            // 
            // lblTroco
            // 
            this.lblTroco.AutoSize = true;
            this.lblTroco.Location = new System.Drawing.Point(33, 69);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(35, 13);
            this.lblTroco.TabIndex = 2;
            this.lblTroco.Text = "Troco";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(91, 23);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 4;
            this.txtTotal.Text = "0";
            // 
            // txtPago
            // 
            this.txtPago.Enabled = false;
            this.txtPago.Location = new System.Drawing.Point(91, 49);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(100, 20);
            this.txtPago.TabIndex = 5;
            this.txtPago.Text = "0";
            // 
            // txtTroco
            // 
            this.txtTroco.Enabled = false;
            this.txtTroco.Location = new System.Drawing.Point(91, 74);
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.Size = new System.Drawing.Size(100, 20);
            this.txtTroco.TabIndex = 6;
            this.txtTroco.Text = "0";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(186, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "0";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(186, 85);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 16;
            this.textBox2.Text = "0";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(186, 108);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 17;
            this.textBox3.Text = "0";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(186, 131);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 18;
            this.textBox4.Text = "0";
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(186, 225);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 22;
            this.textBox5.Text = "0";
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(186, 202);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 21;
            this.textBox6.Text = "0";
            // 
            // textBox7
            // 
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(186, 179);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 20;
            this.textBox7.Text = "0";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(186, 155);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 19;
            this.textBox8.Text = "0";
            // 
            // textBox9
            // 
            this.textBox9.Enabled = false;
            this.textBox9.Location = new System.Drawing.Point(188, 316);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 26;
            this.textBox9.Text = "0";
            // 
            // textBox10
            // 
            this.textBox10.Enabled = false;
            this.textBox10.Location = new System.Drawing.Point(188, 293);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 25;
            this.textBox10.Text = "0";
            // 
            // textBox11
            // 
            this.textBox11.Enabled = false;
            this.textBox11.Location = new System.Drawing.Point(188, 270);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 20);
            this.textBox11.TabIndex = 24;
            this.textBox11.Text = "0";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(188, 246);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 20);
            this.textBox12.TabIndex = 23;
            this.textBox12.Text = "0";
            // 
            // frmPastelaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 618);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbFValor);
            this.Controls.Add(this.grbFValorP);
            this.Controls.Add(this.grbFServ);
            this.Controls.Add(this.grbFPag);
            this.Controls.Add(this.grbPastel);
            this.Controls.Add(this.grbBebida);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmPastelaria";
            this.Text = "Pastelaria";
            this.grbBebida.ResumeLayout(false);
            this.grbBebida.PerformLayout();
            this.grbPastel.ResumeLayout(false);
            this.grbPastel.PerformLayout();
            this.grbFPag.ResumeLayout(false);
            this.grbFServ.ResumeLayout(false);
            this.grbFServ.PerformLayout();
            this.grbFValorP.ResumeLayout(false);
            this.grbFValorP.PerformLayout();
            this.grbFValor.ResumeLayout(false);
            this.grbFValor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grbBebida;
        private System.Windows.Forms.RadioButton rdbNenhum;
        private System.Windows.Forms.RadioButton rdbAgua;
        private System.Windows.Forms.RadioButton rdbCana;
        private System.Windows.Forms.RadioButton rdbSuco;
        private System.Windows.Forms.RadioButton rdbCerv;
        private System.Windows.Forms.RadioButton rdbRefri;
        private System.Windows.Forms.GroupBox grbPastel;
        private System.Windows.Forms.GroupBox grbFPag;
        private System.Windows.Forms.GroupBox grbFServ;
        private System.Windows.Forms.GroupBox grbFValorP;
        private System.Windows.Forms.GroupBox grbFValor;
        private System.Windows.Forms.CheckBox CkbModa;
        private System.Windows.Forms.CheckBox CkbCarneS;
        private System.Windows.Forms.CheckBox CkbCalabresaQ;
        private System.Windows.Forms.CheckBox CkbCalabresa;
        private System.Windows.Forms.CheckBox Ckbbacalhau;
        private System.Windows.Forms.CheckBox CkbPalmito;
        private System.Windows.Forms.CheckBox CkbEscarola;
        private System.Windows.Forms.CheckBox CkbPizza;
        private System.Windows.Forms.CheckBox CkbFrangoQ;
        private System.Windows.Forms.CheckBox CkbFrango;
        private System.Windows.Forms.CheckBox CkbCarneQ;
        private System.Windows.Forms.CheckBox CkbCarne;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxFPag;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.RadioButton rdbDelivery;
        private System.Windows.Forms.RadioButton rdbMesa;
        private System.Windows.Forms.TextBox txtEntrega;
        private System.Windows.Forms.TextBox txtServ;
        private System.Windows.Forms.Label lblEntrega;
        private System.Windows.Forms.Label lblserv;
        private System.Windows.Forms.TextBox txtTroco;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTroco;
        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}