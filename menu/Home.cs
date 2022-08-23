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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void amigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mspaint.exe");
            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void portfolioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://bessiportfolio.vercel.app/");
            Application.Exit();
        }

        private void githubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/EyzRyder");
            Application.Exit();
        }

        private void pastelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPastelaria frm3 = new frmPastelaria();
            frm3.Show();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstoque frm4 = new frmEstoque();
            frm4.Show();
        }

        private void gogglyeyesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zoinho frm = new zoinho();
            frm.Show();
        }

        private void vendingMachinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VendingMachine frm5 = new VendingMachine();
            frm5.Show();
        }

        private void carrinhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Carrinho frm6 = new Carrinho("Oia o carrinho");
            frm6.ShowDialog();
        }
    }
}
