using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScreenGO1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            label7.Text = Environment.UserName;
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            label7.Text = Environment.UserName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreditIMPORTANT putis = new CreditIMPORTANT();
            putis.ShowDialog();
        }

        
    }
}
