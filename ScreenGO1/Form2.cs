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



namespace ScreenGO1
{
    public partial class Form2 : Form
    {
       

        public Form2()
        {
            InitializeComponent();
            this.TopMost = true;
            string path = Path.Combine(Application.StartupPath, "audio.mp3");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("cmd.exe", "/c shutdown /s /t 0");
            this.Close();
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("cmd.exe", "/c shutdown /s /t 300");
            this.Close();
        }
    }
}
