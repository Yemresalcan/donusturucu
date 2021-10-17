using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnD_Click(object sender, EventArgs e)
        {
            int label2 = int.Parse(textBox1.Text);
            label7.Text = Convert.ToString(label2, 2);
            label8.Text = label2.ToString();
            label9.Text = Convert.ToString(label2, 16);
            label10.Text = Convert.ToString(label2, 8);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {

            DialogResult sonuc = MessageBox.Show("Çıkmak İstediğinizden Emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.No)
            {
               return;
            }
            Application.Exit();

        }






        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
