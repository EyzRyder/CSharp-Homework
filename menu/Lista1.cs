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
    public partial class Lista1 : Form
    {
        public Lista1()
        {
            InitializeComponent();
        }

        private void Tarefa1_Load(object sender, EventArgs e)
        {

        }

        private void txt1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnMediaAri_Click(object sender, EventArgs e)
        {
            Double a1 = 0;
            Double a2 = 0;
            Double a3 = 0;
            Double an = 0;
            a1 = Convert.ToInt32(textBox1.Text);
            a2 = Convert.ToInt32(textBox2.Text);
            a3 = Convert.ToInt32(textBox3.Text);
            an = (a1 + a2 + a3) / 3;

            textBox4.Text = Convert.ToString(an);

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var a1 = 0;

            a1 = Convert.ToInt32(textBox5.Text);

            var asus = a1 - 1;
            var aant = a1 + 1;


            textBox5.Text = Convert.ToString($"{asus}, {a1}, {aant}");
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var a1 = 0;
            var a2 = 0;
            var r = 0;
            a1 = Convert.ToInt32(textBox6.Text);
            a2 = Convert.ToInt32(textBox7.Text);
            r = a1 + a2;

            textBox8.Text = Convert.ToString(r);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Double a1 = 0;
            Double ter = 0;
            a1 = Convert.ToInt32(textBox9.Text);
            ter = a1 / 3;

            textBox10.Text = Convert.ToString(ter);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Double a1 = 0;
            Double a2 = 0;
            Double a3 = 0;
            Double a4 = 0;
            Double r = 0;
            a1 = Convert.ToInt32(textBox14.Text);
            a2 = Convert.ToInt32(textBox13.Text);
            a3 = Convert.ToInt32(textBox12.Text);
            a4 = Convert.ToInt32(textBox15.Text);
            r = ((a1 * 1) + (a2 * 2) + (a3 * 3) + (a4 * 4)) / (1 + 2 + 3 + 4);

            textBox11.Text = Convert.ToString(r);
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Double saldo = 0;
            Double reajuste = 0;

            saldo = Convert.ToInt32(textBox17.Text);
            reajuste = saldo * 0.01;
            saldo += reajuste;

            textBox16.Text = Convert.ToString(saldo);
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            var h = 0;
            var b = 0;
            var a = 0;
            var peri = 0;
            h = Convert.ToInt32(textBox19.Text);
            b = Convert.ToInt32(textBox18.Text);
            a = h * b;
            peri = 2 * (b + h);

            textBox21.Text = Convert.ToString(a);
            textBox20.Text = Convert.ToString(peri);
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Double r = 0;
            Double a = 0;
            Double peri = 0;
            r = Convert.ToInt32(textBox25.Text);
            a = 3.14 * Math.Pow(r, 2);
            peri = 2 * 3.14 * r;

            textBox22.Text = Convert.ToString(a);
            textBox23.Text = Convert.ToString(peri);
        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            var h = 0;
            var b = 0;
            var a = 0;
            h = Convert.ToInt32(textBox28.Text);
            b = Convert.ToInt32(textBox27.Text);
            a = (h * b) / 2;

            textBox24.Text = Convert.ToString(a);

        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox26_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Double valor = 0;
            Double temp = 0;
            Double tax = 0;
            Double prest = 0;

            valor = Convert.ToInt32(textBox29.Text);
            temp = Convert.ToInt32(textBox30.Text);
            tax = Convert.ToInt32(textBox31.Text);
            prest = valor + (valor * (tax / 100) * temp);

            textBox26.Text = Convert.ToString(prest);
        }

        private void textBox34_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox33_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Double num = 0;
            Double den = 0;
            Double dec = 0;

            num = Convert.ToInt32(textBox34.Text);
            den = Convert.ToInt32(textBox33.Text);
            dec = num / den;

            textBox32.Text = Convert.ToString(dec);
        }
    }
}
