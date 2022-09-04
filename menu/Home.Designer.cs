
namespace menu
{
    partial class Home
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pastelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gogglyeyesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendingMachinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carrinhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calcularCoisasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.githubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portfolioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Goldenrod;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem,
            this.mEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paintToolStripMenuItem,
            this.pastelToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.gogglyeyesToolStripMenuItem,
            this.vendingMachinToolStripMenuItem,
            this.carrinhoToolStripMenuItem,
            this.calcularCoisasToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.editarToolStripMenuItem.Text = "Apps";
            // 
            // paintToolStripMenuItem
            // 
            this.paintToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("paintToolStripMenuItem.Image")));
            this.paintToolStripMenuItem.Name = "paintToolStripMenuItem";
            this.paintToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.paintToolStripMenuItem.Text = "Paint";
            this.paintToolStripMenuItem.Click += new System.EventHandler(this.paintToolStripMenuItem_Click);
            // 
            // pastelToolStripMenuItem
            // 
            this.pastelToolStripMenuItem.Name = "pastelToolStripMenuItem";
            this.pastelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pastelToolStripMenuItem.Text = "Pastel";
            this.pastelToolStripMenuItem.Click += new System.EventHandler(this.pastelToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stockToolStripMenuItem.Text = "Stock";
            this.stockToolStripMenuItem.Click += new System.EventHandler(this.stockToolStripMenuItem_Click);
            // 
            // gogglyeyesToolStripMenuItem
            // 
            this.gogglyeyesToolStripMenuItem.Name = "gogglyeyesToolStripMenuItem";
            this.gogglyeyesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gogglyeyesToolStripMenuItem.Text = "Gogglyeyes";
            this.gogglyeyesToolStripMenuItem.Click += new System.EventHandler(this.gogglyeyesToolStripMenuItem_Click);
            // 
            // vendingMachinToolStripMenuItem
            // 
            this.vendingMachinToolStripMenuItem.Name = "vendingMachinToolStripMenuItem";
            this.vendingMachinToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vendingMachinToolStripMenuItem.Text = "VendingMachin";
            this.vendingMachinToolStripMenuItem.Click += new System.EventHandler(this.vendingMachinToolStripMenuItem_Click);
            // 
            // carrinhoToolStripMenuItem
            // 
            this.carrinhoToolStripMenuItem.Name = "carrinhoToolStripMenuItem";
            this.carrinhoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.carrinhoToolStripMenuItem.Text = "Carrinho";
            this.carrinhoToolStripMenuItem.Click += new System.EventHandler(this.carrinhoToolStripMenuItem_Click);
            // 
            // calcularCoisasToolStripMenuItem
            // 
            this.calcularCoisasToolStripMenuItem.Name = "calcularCoisasToolStripMenuItem";
            this.calcularCoisasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.calcularCoisasToolStripMenuItem.Text = "Calcular coisas";
            this.calcularCoisasToolStripMenuItem.Click += new System.EventHandler(this.calcularCoisasToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "Matrizes e vetores";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "DBTarefa";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // mEToolStripMenuItem
            // 
            this.mEToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.githubToolStripMenuItem,
            this.portfolioToolStripMenuItem});
            this.mEToolStripMenuItem.Name = "mEToolStripMenuItem";
            this.mEToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.mEToolStripMenuItem.Text = "RedesSociais";
            // 
            // githubToolStripMenuItem
            // 
            this.githubToolStripMenuItem.Name = "githubToolStripMenuItem";
            this.githubToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.githubToolStripMenuItem.Text = "Github";
            this.githubToolStripMenuItem.Click += new System.EventHandler(this.githubToolStripMenuItem_Click);
            // 
            // portfolioToolStripMenuItem
            // 
            this.portfolioToolStripMenuItem.Name = "portfolioToolStripMenuItem";
            this.portfolioToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.portfolioToolStripMenuItem.Text = "Portfolio";
            this.portfolioToolStripMenuItem.Click += new System.EventHandler(this.portfolioToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.MidnightBlue;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 30);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Margin = new System.Windows.Forms.Padding(5);
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 20);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(207, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(362, 214);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(488, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Todos meus atividades de Desenvolvimento de Sistemas";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "HomeWork Folder";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paintToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem mEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem githubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portfolioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pastelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gogglyeyesToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem vendingMachinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carrinhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calcularCoisasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}

