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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();



        }

        private void Form8_Load_1(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Apptheme == 1)
            {

                button1.BackColor = Color.FromArgb(25, 25, 25);
                button1.ForeColor = Color.White;
                button2.BackColor = Color.FromArgb(25, 25, 25);
                button2.ForeColor = Color.White;
                this.BackColor = Color.FromArgb(25, 25, 25);
                label2.ForeColor = Color.White;
                label1.ForeColor = Color.White;
            }
            else if (Properties.Settings.Default.Apptheme == 0)
            {

                this.BackColor = SystemColors.Control;
                button1.BackColor = SystemColors.Control;
                button1.ForeColor = Color.FromArgb(25, 25, 25);
                button2.BackColor = SystemColors.Control;
                button2.ForeColor = Color.FromArgb(25, 25, 25);
                label2.ForeColor = Color.FromArgb(25, 25, 25);
                label1.ForeColor = Color.FromArgb(25, 25, 25);

            }
        }

        private void butonbrotherzmsg(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("You need to restart the app if you want to see the changes. Do you want to restart the app now?", "ScreenGO1", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                Application.Restart();
            }

            if (result == DialogResult.No)
            {
                // Do nothing
            }
        }

        public class AppThemey
        {
            public static int Apptheme = 0;
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            Properties.Settings.Default.Apptheme = 0;

            Properties.Settings.Default.Save();
            butonbrotherzmsg(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Apptheme = 1;

            Properties.Settings.Default.Save();
            butonbrotherzmsg(sender, e);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
