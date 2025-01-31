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
//Date: <Oct 5 - Oct 5>
//Assignement: Logical 
//Purpose: To tell the user if the input is a lower or uppercase letter S

namespace Logical
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnLetter_Click(object sender, EventArgs e)
        {
            char input;

            input = char.Parse(txtLetter.Text);

            if (input >= 'A' & input <= 'Z')
            {
                MessageBox.Show("The letter is an uppercase");
            }

            else if (input >= 'a' & input <= 'z')
            {
                MessageBox.Show("The letter is a lowercase");
            }

          //  var lowerCase = new[] {
          //      'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
          //  };

          //  var upperCase = new[] {
          //      'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
          //  };

          //  for (int i = 0; i < lowerCase.Count(); i++) {

           //     if (input == lowerCase[i])
           //     {
           //         MessageBox.Show("The letter is a lowercase"); 
            //    }
 
           // }

           // for (int i = 0; i < upperCase.Count(); i++)
           // {

           //     if (input == upperCase[i])
             //   {
                   // MessageBox.Show("The letter is an uppercase");
               // }

           // } 
        }
    }
}
