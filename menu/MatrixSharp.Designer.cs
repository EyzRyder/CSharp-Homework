namespace menu
{
    partial class MatrixSharp
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
            this.txtlinha = new System.Windows.Forms.TextBox();
            this.txtcoluna = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.Label();
            this.listMatrix = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtlinha
            // 
            this.txtlinha.Location = new System.Drawing.Point(34, 69);
            this.txtlinha.Name = "txtlinha";
            this.txtlinha.Size = new System.Drawing.Size(100, 20);
            this.txtlinha.TabIndex = 0;
            this.txtlinha.TextChanged += new System.EventHandler(this.txtlinha_TextChanged);
            // 
            // txtcoluna
            // 
            this.txtcoluna.Location = new System.Drawing.Point(159, 68);
            this.txtcoluna.Name = "txtcoluna";
            this.txtcoluna.Size = new System.Drawing.Size(100, 20);
            this.txtcoluna.TabIndex = 1;
            this.txtcoluna.TextChanged += new System.EventHandler(this.txtcoluna_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Linha";
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Location = new System.Drawing.Point(192, 39);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(40, 13);
            this.text.TabIndex = 3;
            this.text.Text = "Coluna";
            // 
            // listMatrix
            // 
            this.listMatrix.FormattingEnabled = true;
            this.listMatrix.Location = new System.Drawing.Point(34, 123);
            this.listMatrix.Name = "listMatrix";
            this.listMatrix.Size = new System.Drawing.Size(225, 147);
            this.listMatrix.TabIndex = 4;
            this.listMatrix.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(307, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "Gerar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(307, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 39);
            this.button2.TabIndex = 6;
            this.button2.Text = "Somar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MatrixSharp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(424, 301);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listMatrix);
            this.Controls.Add(this.text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcoluna);
            this.Controls.Add(this.txtlinha);
            this.Name = "MatrixSharp";
            this.Text = "Matrizes e Vetores";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtlinha;
        private System.Windows.Forms.TextBox txtcoluna;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.ListBox listMatrix;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}