using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Controls;
using System.Windows.Forms;
using static ScreenGO1.Form7;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;



namespace ScreenGO1
{
    public partial class Form2 : Form
    {

        bool IsTimerRunning = false;
        int seconds = 0;
        int Placeholder;
        int PausedActive = 0;
        Form1 form1 = new Form1();
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        SoundPlayer putis;
        SoundPlayer soundr;
       

        public Form2()
        {
            InitializeComponent();

            string path = Properties.Settings.Default.customSoundfile;

            if (Properties.Settings.Default.resetsound == 1)
            {
                putis = new SoundPlayer(path);
               
            }
            else
            {
                soundr = new SoundPlayer(Properties.Resources.eter);
            }
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

        private void Form2_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.globalsoundcustom == 1)
            {
                
                putis.PlayLooping();

            }
            else
            {
                
                soundr.PlayLooping();
            }


            


        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            buton1msg(sender, e); this.Close();
            putis.Stop();
            soundr.Stop();


        }



        private void button2_Click(object sender, EventArgs e)
        {
            buton2msg(sender, e);
            
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
        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        

        private void Draggable_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Draggable_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
