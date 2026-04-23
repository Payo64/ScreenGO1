using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;
using static ScreenGO1.Form7;
// some parts are handled by ai
// dont worry though i tried to minimized ai generated code as much as possible.
// so its maybe about 15/20% idk
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
            if (Properties.Settings.Default.resetsound == 1)
            {
                DataForm1.soundfilepathform1 = Properties.Settings.Default.customSoundfile;
                DataStore.globalInteger = 1;
            }
            else
            {
                Properties.Settings.Default.customSoundfile = string.Empty;
                Properties.Settings.Default.globalsoundcustom = 0;
                DataStore.globalInteger = 0;
            }
        }

        public class DataForm1
        {
            public static string soundfilepathform1;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            toolStrip1.RenderMode = ToolStripRenderMode.System;
           
                seconds = Properties.Settings.Default.timervalue;
                label1.Text = Properties.Settings.Default.timervalue.ToString();
                textBox1.Text = Properties.Settings.Default.timervalue.ToString();
            
            

            if (Properties.Settings.Default.Apptheme == 1)
            {
                button1.BackColor = Color.FromArgb(25, 25, 25);
                button1.ForeColor = Color.White;
                pausetimer.BackColor = Color.FromArgb(25, 25, 25);
                pausetimer.ForeColor = Color.White;
                button2.BackColor = Color.FromArgb(25, 25, 25);
                button2.ForeColor = Color.White;

                this.BackColor = Color.FromArgb(25, 25, 25);

                label1.ForeColor = Color.White;
                label1.BackColor = Color.FromArgb(25, 25, 25);
                label6.ForeColor = Color.White;
                label6.BackColor = Color.FromArgb(25, 25, 25);
                label3.ForeColor = Color.White;
                label3.BackColor = Color.FromArgb(25, 25, 25);
                label4.ForeColor = Color.White;
                label4.BackColor = Color.FromArgb(25, 25, 25);
                label5.ForeColor = Color.White;
                label5.BackColor = Color.FromArgb(25, 25, 25);
                label6.ForeColor = Color.White;
                label6.BackColor = Color.FromArgb(25, 25, 25);
            }
            else if (Properties.Settings.Default.Apptheme == 0)
            {

                this.BackColor = SystemColors.Control;
                button1.BackColor = SystemColors.Control;
                button1.ForeColor = Color.FromArgb(25, 25, 25);
                pausetimer.BackColor = SystemColors.Control;
                pausetimer.ForeColor = Color.FromArgb(25, 25, 25);
                button2.BackColor = SystemColors.Control;
                button2.ForeColor = Color.FromArgb(25, 25, 25);

                label1.ForeColor = Color.FromArgb(25, 25, 25);
                label1.BackColor = SystemColors.Control;
                label6.ForeColor = Color.FromArgb(25, 25, 25);
                label6.BackColor = SystemColors.Control;
                label3.ForeColor = Color.FromArgb(25, 25, 25);
                label3.BackColor = SystemColors.Control;
                label4.ForeColor = Color.FromArgb(25, 25, 25);
                label4.BackColor = SystemColors.Control;
                label5.ForeColor = Color.FromArgb(25, 25, 25);
                label5.BackColor = SystemColors.Control;
                label6.ForeColor = Color.FromArgb(25, 25, 25);
                label6.BackColor = SystemColors.Control;
            }
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
                notifyIcon1.Text = "ScreenGO1 - Stopped";
                this.Text = "ScreenGO1 - Stopped";
                
            }
            notifyIcon1.Text = "ScreenGO1 - " + (seconds + 1) + " Seconds remaning";
            this.Text = "ScreenGO1 - " + (seconds + 1) + " Seconds remaning";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PausedActive == 0)
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("Please enter a number to start a timer" + Placeholder,
                                         "ScreenGO1", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
              Properties.Settings.Default.timervalue = seconds;
                Properties.Settings.Default.timervalue = 00;
                Properties.Settings.Default.Save();
            
                
            timer1.Stop();
            label1.Text = "00";
            PausedActive = 0;
            
            pausetimer.Enabled = false;
            button2.Enabled = false;
            button1.Enabled = true;
            notifyIcon1.Text = "ScreenGO1 - Stopped";
            this.Text = "ScreenGO1 - Stopped";
        }

        private void label6_Click(object sender, EventArgs e)
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
            
                Properties.Settings.Default.timervalue = seconds;
                Properties.Settings.Default.Save();
            
                
            PausedActive = 1;
            notifyIcon1.Text = "ScreenGO1 - Paused";
            this.Text = "ScreenGO1 - Paused";
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

        private void optionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void preferenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSplitButton3_ButtonClick(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
