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
//Assigment: NumberSign 
//Purpose: To check is num1 and num2 are postive or negative numbers 

namespace NumberSign
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnNumCheck_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtNum1.Text);
            double num2 = double.Parse(txtNum2.Text);

            if (num1 < 0 && num2 < 0)
            {
                MessageBox.Show("Both are negative!");
            }

            else if (num1 < 0)
            {
                MessageBox.Show("Number 1 is a negative!");
            }

            else if (num2 < 0)
            {
                MessageBox.Show("Number 2 is a negative!");
            }

            if (num1 >= 0 && num2 >= 0) {

                MessageBox.Show("Both are positive"); 
            }

            else if (num1 >= 0)
            {
                MessageBox.Show("Number 1 is a positive!");
            }

            else if (num2 >= 0)
            {
                MessageBox.Show("Number 2 is a positive!");
            } 

            MessageBox.Show("Done");
        }
    }
}
