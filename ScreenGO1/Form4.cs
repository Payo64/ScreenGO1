using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

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
            if (Properties.Settings.Default.Apptheme == 1)
            {
                label1.BackColor = Color.FromArgb(25, 25, 25);
                label1.ForeColor = Color.White;
                label2.BackColor = Color.FromArgb(25, 25, 25);
                label2.ForeColor = Color.White;
                label3.BackColor = Color.FromArgb(25, 25, 25);
                label3.ForeColor = Color.White;
                label4.BackColor = Color.FromArgb(25, 25, 25);
                label4.ForeColor = Color.White;
                label5.BackColor = Color.FromArgb(25, 25, 25);
                label5.ForeColor = Color.White;
                label6.BackColor = Color.FromArgb(25, 25, 25);
                label6.ForeColor = Color.White;
                label7.BackColor = Color.FromArgb(25, 25, 25);
                label7.ForeColor = Color.White;
                button1.BackColor = Color.FromArgb(25, 25, 25);
                button1.ForeColor = Color.White;
                button1.BackColor = Color.FromArgb(25, 25, 25);
                button2.BackColor = Color.FromArgb(25, 25, 25);
                button2.ForeColor = Color.White;

                this.BackColor = Color.FromArgb(25, 25, 25);
            }
            if (Properties.Settings.Default.Apptheme == 0)
            {
                label1.BackColor = SystemColors.Control;
                label1.ForeColor = Color.FromArgb(25, 25, 25);
                label2.BackColor = SystemColors.Control;
                label2.ForeColor = Color.FromArgb(25, 25, 25);
                label3.BackColor = SystemColors.Control;
                label3.ForeColor = Color.FromArgb(25, 25, 25);
                label4.BackColor = SystemColors.Control;
                label4.ForeColor = Color.FromArgb(25, 25, 25);
                label5.BackColor = SystemColors.Control;
                label5.ForeColor = Color.FromArgb(25, 25, 25);
                label6.BackColor = SystemColors.Control;
                label6.ForeColor = Color.FromArgb(25, 25, 25);
                label7.BackColor = SystemColors.Control;
                label7.ForeColor = Color.FromArgb(25, 25, 25);
                button1.BackColor = SystemColors.Control;
                button1.ForeColor = Color.FromArgb(25, 25, 25);
                button1.BackColor = SystemColors.Control;
                button2.BackColor = SystemColors.Control;
                button2.ForeColor = Color.FromArgb(25, 25, 25); 
                this.BackColor = SystemColors.Control;
            }


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

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
