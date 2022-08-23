
namespace menu
{
    partial class zoinho
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(zoinho));
            this.eyesimg = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.ligadeliga = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.eyesimg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // eyesimg
            // 
            this.eyesimg.Image = ((System.Drawing.Image)(resources.GetObject("eyesimg.Image")));
            this.eyesimg.Location = new System.Drawing.Point(70, 32);
            this.eyesimg.Name = "eyesimg";
            this.eyesimg.Size = new System.Drawing.Size(32, 32);
            this.eyesimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.eyesimg.TabIndex = 1;
            this.eyesimg.TabStop = false;
            this.eyesimg.Click += new System.EventHandler(this.eyesimg_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(45, 102);
            this.trackBar1.Maximum = 700;
            this.trackBar1.Minimum = 10;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trackBar1.Size = new System.Drawing.Size(84, 45);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.TickFrequency = 50;
            this.trackBar1.Value = 200;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // ligadeliga
            // 
            this.ligadeliga.Location = new System.Drawing.Point(49, 70);
            this.ligadeliga.Name = "ligadeliga";
            this.ligadeliga.Size = new System.Drawing.Size(75, 23);
            this.ligadeliga.TabIndex = 5;
            this.ligadeliga.Text = "Liga/Desliga";
            this.ligadeliga.UseVisualStyleBackColor = true;
            this.ligadeliga.Click += new System.EventHandler(this.ligadeliga_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // zoinho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(176, 167);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.ligadeliga);
            this.Controls.Add(this.eyesimg);
            this.Name = "zoinho";
            this.Text = "zoinho";
            this.Load += new System.EventHandler(this.zoinho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eyesimg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox eyesimg;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button ligadeliga;
        private System.Windows.Forms.Timer timer1;
    }
}