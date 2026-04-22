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
    public partial class CreditIMPORTANT : Form
    {
        public CreditIMPORTANT()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/playlist?list=PLPQbCFC8uUuu4SWSDqp6uk5Ce47-Z18uh");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CreditIMPORTANT_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Apptheme == 1)
            {
                this.BackColor = Color.FromArgb(25, 25, 25);

                label3.ForeColor = Color.White;
                label4.ForeColor = Color.White;
                label5.ForeColor = Color.White;
                label6.ForeColor = Color.White;
                label7.ForeColor = Color.White;
                label8.ForeColor = Color.White;
                button1.BackColor = Color.FromArgb(25, 25, 25);
                button1.ForeColor = Color.White;
                button2.BackColor = Color.FromArgb(25, 25, 25);
                button2.ForeColor = Color.White;
            }
            else if (Properties.Settings.Default.Apptheme == 0)
            {
                this.BackColor = SystemColors.Control;

                label3.ForeColor = Color.FromArgb(25, 25, 25);
                label4.ForeColor = Color.FromArgb(25, 25 ,25);
                label5.ForeColor = Color.FromArgb(25, 25, 25);
                label6.ForeColor = Color.FromArgb(25, 25, 25);
                label7.ForeColor = Color.FromArgb(25, 25, 25);
                label8.ForeColor = Color.FromArgb(25, 25, 25);
                button1.BackColor = SystemColors.Control;
                button1.ForeColor = Color.FromArgb(25, 25, 25);
                button2.BackColor = SystemColors.Control;
                button2.ForeColor = Color.FromArgb(25, 25, 25);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
