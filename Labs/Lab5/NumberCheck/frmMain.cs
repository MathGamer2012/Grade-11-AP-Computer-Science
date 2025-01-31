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
//Assigment: NumberCheck
//Purpose: Checks if num1 is >, <, or = to num2

namespace NumberCheck
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNum.Text);
            int num2 = int.Parse(txtNum2.Text);

            if (num1 == num2)
            {
                MessageBox.Show("Number 1 is equal to Number 2");
            }

            else if (num1 > num2)
            {
                MessageBox.Show("Number 1 is greater than Number 2");
            }

            else if (num1 < num2)
            {
                MessageBox.Show("Number 1 is less than Number 2");
            }

            MessageBox.Show("Done"); 
        }
    }
}
