using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace ScreenGO1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            loadform(new Form9());
            if (Properties.Settings.Default.Apptheme == 1)
            {
                button1.BackColor = Color.FromArgb(25, 25, 25);
                button1.ForeColor = Color.White;
                button2.BackColor = Color.FromArgb(25, 25, 25);
                button2.ForeColor = Color.White;
                button3.BackColor = Color.FromArgb(25, 25, 25);
                button3.ForeColor = Color.White;
                this.BackColor = Color.FromArgb(25, 25, 25);

            }
            else if (Properties.Settings.Default.Apptheme == 0)
            {
                button1.BackColor = SystemColors.Control;
                button1.ForeColor = Color.FromArgb(25, 25, 25);
                button2.BackColor = SystemColors.Control;
                button2.ForeColor = Color.FromArgb(25, 25, 25);
                button3.BackColor = SystemColors.Control;
                button3.ForeColor = Color.FromArgb(25, 25, 25);
                this.BackColor = SystemColors.Control;
            }

        }

        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new Form7());

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadform(new Form8());

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadform(new Form9());
        }
    }
}
