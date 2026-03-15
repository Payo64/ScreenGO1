using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static ScreenGO1.Form1;
// some parts are handled by ai
// dont worry though i tried to minimized ai generated code as much as possible.
// so its maybe about 15/20% idk

namespace ScreenGO1
{
    public partial class Form7 : Form
    {
        
        public int soundpath = 0;
        
        
        public class DataStore
        {
            public static int globalInteger = 0;
            public static string soundfilepath;
            public static string selectedsound;
        }
        public Form7()
        {
            InitializeComponent();
            if (Properties.Settings.Default.resetsound == 1)
            {
                textBox1.Text = Properties.Settings.Default.customSoundfile;
                Properties.Settings.Default.globalsoundcustom = 1;
            }
            else
            {
                textBox1.Clear();
                Properties.Settings.Default.customSoundfile = string.Empty;
                Properties.Settings.Default.globalsoundcustom = 0;
            }

        }

        private void Form7_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        
            Properties.Settings.Default.customSoundfile = textBox1.Text;
            Properties.Settings.Default.Save();
        
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {

            textBox1.Text = Properties.Settings.Default.customSoundfile;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog op = new OpenFileDialog() { Filter = "WAV FILE|*.wav" })
            {



                if (op.ShowDialog() == DialogResult.OK)
                {
                    DataStore.soundfilepath = op.FileName;
                    DataStore.selectedsound = Path.GetFileName(op.FileName);  // store the file path
                    string exe;
                    exe = op.FileName;


                    { textBox1.Text = DataStore.soundfilepath; textBox1.Refresh(); ; }
                    MessageBox.Show("Sound File Selected",
                                    "Preference", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Properties.Settings.Default.customSoundfile = DataStore.soundfilepath;
                    Properties.Settings.Default.Save();
                    DataForm1.soundfilepathform1 = Path.GetFileName(op.FileName);

                    DataStore.globalInteger = 1;
                    Properties.Settings.Default.resetsound = 1;
                    Properties.Settings.Default.globalsoundcustom = 1;
                    Properties.Settings.Default.Save();
                    // https://stackoverflow.com/questions/453161/how-can-i-save-application-settings-in-a-windows-forms-application

                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.resetsound = 0;
            textBox1.Clear();
            Properties.Settings.Default.customSoundfile = string.Empty;
            Properties.Settings.Default.globalsoundcustom = 0;
            DataStore.globalInteger = 0;
            Properties.Settings.Default.Save();
        }
    }
}
