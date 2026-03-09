using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace ScreenGO1
{
    public partial class Form1 : Form
    {
        bool IsTimerRunning = false;
        int seconds = 0;
        int Placeholder;
        int PausedActive = 0;
        
        public Form1()
        {
            InitializeComponent();
            button2.Enabled = false;
            int PausedActive = 0;
            pausetimer.Enabled = false;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = seconds--.ToString();
            if (seconds < 0)
            {
                timer1.Stop();
                label1.Text = "00";
                Form2 form2 = new Form2();
                form2.ShowDialog();
                pausetimer.Enabled = false;
                button2.Enabled = false;
                button1.Enabled = true;
                notifyIcon1.Text = "Clocker - Stopped";
                this.Text = "Clocker - Stopped";
            }
            notifyIcon1.Text = "Clocker - " + (seconds + 1) + " Seconds remaning";
            this.Text = "Clocker - " + (seconds + 1) + " Seconds remaning";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PausedActive == 0)
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("Please enter a number to start a timer" + Placeholder,
                                         "Clocker", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    seconds = int.Parse(textBox1.Text);
                    timer1.Start();
                    IsTimerRunning = true;
                    button2.Enabled = true;
                    button1.Enabled = false;
                    pausetimer.Enabled = true;
                    PausedActive = 1;
                }
            }
            if (PausedActive == 1)
            {
                timer1.Start();
                seconds = seconds;
                IsTimerRunning = true;
                button2.Enabled = true;
                button1.Enabled = false;
                pausetimer.Enabled = true;
                PausedActive = 0;
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
            seconds = int.Parse(textBox1.Text);
            timer1.Stop();
            label1.Text = "00";
            PausedActive = 0;
            
            pausetimer.Enabled = false;
            button2.Enabled = false;
            button1.Enabled = true;
            notifyIcon1.Text = "Clocker - Stopped";
            this.Text = "Clocker - Stopped";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
                
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.Visible = true;
                
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            this.Show();
            this.WindowState = FormWindowState.Normal;

        }

        private void pausetimer_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            PausedActive = 1;
            notifyIcon1.Text = "Clocker - Paused";
            this.Text = "Clocker - Paused";
            button1.Enabled = true;
            pausetimer.Enabled = false;
           
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();


        }

        private void reviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Payo64/ScreenGO1/issues/new");
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void toolStripSplitButton2_ButtonClick(object sender, EventArgs e)
        {

        }
    }
}
