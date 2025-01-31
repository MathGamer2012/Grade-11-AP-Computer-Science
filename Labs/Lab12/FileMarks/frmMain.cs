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

//Name: Ishaan Mitta 
//Date: <Jan 11 - Jan 11>
//Assignment: Lab 12 
//Purpose: To store marks into array from a text file 

namespace FileMarks
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            StreamReader sr = new StreamReader("marks.txt");

            int line1; 
            line1 = int.Parse(sr.ReadLine());

            int[] marklist = new int[line1];

            for (int i = 0; i < marklist.Length; i++) {
                marklist[i] = int.Parse(sr.ReadLine());
            }

            for (int i = 0; i < marklist.Length; i++)
            {
                txtOutput.Text += marklist[i].ToString() + " "; 
            }

            sr.Close();



        }
    }
}
