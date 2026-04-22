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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Apptheme == 1)
            {
                this.BackColor = Color.FromArgb(25, 25, 25);
                label1.ForeColor = Color.White;

            }
            else if (Properties.Settings.Default.Apptheme == 0)
            {
                this.BackColor = SystemColors.Control;
                label1.ForeColor = Color.FromArgb(25, 25, 25);

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
