using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace gmTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void folderBrowserDialog_HelpRequest(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            groupBox1.Text = openFileDialog1.SafeFileName.Substring(0, openFileDialog1.SafeFileName.Length - 4);
            using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
            {
                // Read the stream to a string, and write the string to the console.
                string line = sr.ReadToEnd();
                textBox1.Text = line;
            }
            openCampaignButton.Enabled = true;
        }

        private void openCampaignButton_Click(object sender, EventArgs e)
        {
            //Open main form, pass filepath
        }
    }
}
