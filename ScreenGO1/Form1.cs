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
    public partial class Form1 : Form
    {
        int seconds = 0;
        public Form1()
        {
            InitializeComponent();
            button2.Enabled = false;
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = seconds--.ToString();
            if (seconds < 0)
            {
                timer1.Stop();
                label1.Text = "0";
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please enter a number to start");
            }
            else
            {
                seconds = int.Parse(textBox1.Text);
                timer1.Start();
                button2.Enabled = true; 
            }



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // If the key pressed is a digit, block it
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true; // Prevents the number from appearing
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            button2.Enabled = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
