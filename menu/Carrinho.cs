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
    public partial class Carrinho : Form
    {
        public Carrinho(string name)
        {
            InitializeComponent();
            label1.Text = name;
            timer1.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void car_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (car.Location.X < 500)
            {
                car.Location = new Point(car.Location.X + 10, 142);
            }
            else
            {
                timer1.Enabled = false;
            }
        }
    }
}
