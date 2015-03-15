using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Mass_Renamer
{
    public partial class Form1 : Form
    {
        //Declares Lists for keeping track of the data
        List<String> inputnames = new List<String>();
        List<String> inputfullpaths = new List<String>();
        List<String> outputnames = new List<String>();
        List<String> filetype = new List<String>();
        List<String> fullpath = new List<String>();
        String outputvalue;
        int starting_integer;
        int ending_integer;
        int significand_integer;

        public Form1()
        {
            InitializeComponent();
            clearall();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All Files (*.*) | *.*";
            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                for (int aa = 0; aa < openFileDialog1.FileNames.Count(); aa++)
                {
                    //Temporary value that holds where to end file path by deleting the filename from the filepath
                    int beginlength = openFileDialog1.FileNames[aa].Count() - openFileDialog1.SafeFileNames[aa].Count();
                    //Temporary value that holds where to delete to preserve filetype
                    int endlength = openFileDialog1.FileNames[aa].LastIndexOf(".");

                    //Save path, name, inputpath (with filename), and filetype all into the appropriate List
                    inputnames.Add(openFileDialog1.SafeFileNames[aa]);
                    inputfullpaths.Add(openFileDialog1.FileNames[aa]);
                    listBox1.Items.Add(openFileDialog1.SafeFileNames[aa]);
                    fullpath.Add(openFileDialog1.FileNames[aa].Remove(beginlength));
                    filetype.Add(openFileDialog1.FileNames[aa].Remove(0, endlength));
                    //listBox1.Items.Add(filetype[aa]); Error check
                }
            }
        }

        private void display_Output()
        {
            //clear the output 
            listBox2.Items.Clear();
            outputnames.Clear();
            try
            {
                //No errorcheck for now
                starting_integer = Convert.ToInt32(textBoxStarting.Text);
                ending_integer = Convert.ToInt32(textBoxEnding.Text);
                significand_integer = Convert.ToInt32(textBoxSignificand.Text);

                string renamedvalue = textBox1.Text;
                int i = 0;
                foreach (string input in inputfullpaths)
                {
                    //pad 0's to the amount of the sigificand and add it to the renamed value
                    String value_string = starting_integer.ToString(("D" + significand_integer));
                    outputvalue = renamedvalue + " " + value_string;
                    outputnames.Add(fullpath[i] + outputvalue + filetype[i]);
                    listBox2.Items.Add(fullpath[i] + outputvalue + filetype[i]);
                    starting_integer += 1;
                    i += 1;
                }
            }
            catch(Exception ee)
            {
                //No exception handling for now
            }
            Invalidate();
        }

        //Redisplay whenever any of the inputs change
        private void textBoxStarting_TextChanged(object sender, EventArgs e)
        {
            display_Output();
        }
        private void textBoxEnding_TextChanged(object sender, EventArgs e)
        {
            display_Output();
        }
        private void textBoxSignificand_TextChanged(object sender, EventArgs e)
        {
            display_Output();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            display_Output();
        }

        //When renamed, clear everything
        private void buttonRename_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (string fullpath in inputfullpaths)
            {
                System.IO.File.Move(fullpath, outputnames[i]);
                i += 1;
            }
            clearall();
        }

        //Clear all data
        private void clearall()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            inputnames.Clear();
            inputfullpaths.Clear();
            outputnames.Clear();
            filetype.Clear();
            fullpath.Clear();
        }



    }
}
