using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Name: Ishaan Mittal 
//Date: <Sept 29 - Sept 29>
//Assigment: Mark
//Purpose: To tell the user if they passed or failed based on average 

namespace Marks
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnMark_Click(object sender, EventArgs e)
        {
            double mark = double.Parse(txtMark.Text);

            if (mark >= 50)
            {
                MessageBox.Show("You Passed!");
            }

            else
            {
                MessageBox.Show("You Failure!");
            }

            MessageBox.Show("Done!"); 
         
        }
    }
}
