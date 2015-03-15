using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mass_Renamer
{
    public partial class Form1 : Form
    {
        List<String> inputnames = new List<String>();
        List<String> inputfullpaths = new List<String>();
        public Form1()
        {
            InitializeComponent();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All Files (*.*) | *.*";
            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                for (int aa = 0; aa < openFileDialog1.FileNames.Count(); aa++)
                {
                    inputnames.Add(openFileDialog1.SafeFileNames[aa]);
                    inputfullpaths.Add(openFileDialog1.FileNames[aa]);
                    //listBox1.Items.Add(openFileDialog1.FileNames[aa]);
                }
            }
        }


    }
}
