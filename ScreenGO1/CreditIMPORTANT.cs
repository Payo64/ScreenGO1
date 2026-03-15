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
    }
}
