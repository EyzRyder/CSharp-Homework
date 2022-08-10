
namespace menu
{
    partial class frmEstoque
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lblListaCompras = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblPosicao = new System.Windows.Forms.Label();
            this.lblitemSele = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtbNomeProduto = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimparT = new System.Windows.Forms.Button();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Produto";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 246);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(378, 128);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lblListaCompras
            // 
            this.lblListaCompras.AutoSize = true;
            this.lblListaCompras.Location = new System.Drawing.Point(40, 112);
            this.lblListaCompras.Name = "lblListaCompras";
            this.lblListaCompras.Size = new System.Drawing.Size(88, 13);
            this.lblListaCompras.TabIndex = 3;
            this.lblListaCompras.Text = "Lista de Compras";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(43, 128);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(249, 95);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblPosicao
            // 
            this.lblPosicao.AutoSize = true;
            this.lblPosicao.Location = new System.Drawing.Point(40, 249);
            this.lblPosicao.Name = "lblPosicao";
            this.lblPosicao.Size = new System.Drawing.Size(81, 13);
            this.lblPosicao.TabIndex = 5;
            this.lblPosicao.Text = "Posição na lista";
            // 
            // lblitemSele
            // 
            this.lblitemSele.AutoSize = true;
            this.lblitemSele.Location = new System.Drawing.Point(40, 281);
            this.lblitemSele.Name = "lblitemSele";
            this.lblitemSele.Size = new System.Drawing.Size(89, 13);
            this.lblitemSele.TabIndex = 6;
            this.lblitemSele.Text = "Item Selecionado";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(40, 315);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(72, 13);
            this.lbltotal.TabIndex = 7;
            this.lbltotal.Text = "Total de Itens";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(135, 278);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 8;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(135, 312);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(200, 20);
            this.textBox3.TabIndex = 9;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtbNomeProduto
            // 
            this.txtbNomeProduto.Location = new System.Drawing.Point(298, 36);
            this.txtbNomeProduto.Name = "txtbNomeProduto";
            this.txtbNomeProduto.Size = new System.Drawing.Size(210, 20);
            this.txtbNomeProduto.TabIndex = 10;
            this.txtbNomeProduto.TextChanged += new System.EventHandler(this.txtbNomeProduto_TextChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(378, 169);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnLimparT
            // 
            this.btnLimparT.Location = new System.Drawing.Point(378, 209);
            this.btnLimparT.Name = "btnLimparT";
            this.btnLimparT.Size = new System.Drawing.Size(75, 23);
            this.btnLimparT.TabIndex = 12;
            this.btnLimparT.Text = "Limpar tudo";
            this.btnLimparT.UseVisualStyleBackColor = true;
            // 
            // btnLimpa
            // 
            this.btnLimpa.Location = new System.Drawing.Point(378, 244);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(75, 23);
            this.btnLimpa.TabIndex = 13;
            this.btnLimpa.Text = "Limpar";
            this.btnLimpa.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(378, 281);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 14;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpa);
            this.Controls.Add(this.btnLimparT);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtbNomeProduto);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lblitemSele);
            this.Controls.Add(this.lblPosicao);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblListaCompras);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmEstoque";
            this.Text = "Estoque";
            this.Load += new System.EventHandler(this.frmEstoque_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label lblListaCompras;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblPosicao;
        private System.Windows.Forms.Label lblitemSele;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtbNomeProduto;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimparT;
        private System.Windows.Forms.Button btnLimpa;
        private System.Windows.Forms.Button btnSair;
    }
}