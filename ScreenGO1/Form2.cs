using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace ScreenGO1
{
    public partial class Form2 : Form
    {

        bool IsTimerRunning = false;
        int seconds = 0;
        int Placeholder;
        int PausedActive = 0;
        Form1 form1 = new Form1();
        public Form2()
        {
            InitializeComponent();
            this.TopMost = true;
            string path = Path.Combine(Application.StartupPath, "audio.mp3");
            timer1.Start();
            seconds = 10;
            label3.Text = seconds.ToString();
            timer1.Start();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = seconds--.ToString();
            if (seconds < 0)
            {
               
                label3.Text = "0";
                Process.Start("cmd.exe", "/c shutdown /s /t 0");
                timer1.Stop();
            }




        }


        private void button1_Click(object sender, EventArgs e)
        {
            buton1msg(sender, e);
            this.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            buton2msg(sender, e);
            this.Close();
        }

        private void buton1msg(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to shutdown this computer now?", "Clocker", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                this.Close();
                Process.Start("cmd.exe", "/c shutdown /s /t 0");
                button1.Enabled = true;
            }
            if (result == DialogResult.No)
            {
                button1.Enabled = true;
                
                form1.Close();
            }
        }

        private void buton2msg(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to add 5 more minutes?", "Clocker", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                this.Close();
                Process.Start("cmd.exe", "/c shutdown /s /t 300");
                button1.Enabled = true;
            }
            if (result == DialogResult.No)
            {
                button1.Enabled = true;
                
                form1.Close();
            }
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            buton1msg(sender, e); this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
