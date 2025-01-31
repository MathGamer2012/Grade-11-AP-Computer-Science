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
//Assigment: MyFirstWindowsForm
//Purpose: Shows "Button Clicked" when the button is clicked 

namespace MyFirstWindowsForm
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnTest_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Button Clicked"); 
        }

    }
}
