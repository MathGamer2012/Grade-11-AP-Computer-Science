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
//Date: <Oct 8 - Oct 8> 
//Assignment: OntarioG1Test 
//Purpose: To make a practice G1 test for the user to test their knowledge on driving signs 

namespace OntarioG1Test
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string ans1;
            string ans2;
            string ans3;
            string ans4;
            string ans5;
            string ans6;
            string ans7;
            string ans8;
            string ans9;
            string ans10;
            byte score = 0;

            ans1 = txtAns1.Text;
            ans1.ToLower();

            ans2 = txtAns2.Text;
            ans2.ToLower();

            ans3 = txtAns3.Text;
            ans3.ToLower();

            ans4 = txtAns4.Text;
            ans4.ToLower();

            ans5 = txtAns5.Text;
            ans5.ToLower();

            ans6 = txtAns6.Text;
            ans6.ToLower();

            ans7 = txtAns7.Text;
            ans7.ToLower();

            ans8 = txtAns8.Text;
            ans8.ToLower();

            ans9 = txtAns9.Text;
            ans9.ToLower();

            ans10 = txtAns10.Text;
            ans10.ToLower();

            if (ans1 == "t")
            {
                lblCheck1.Text = "Correct";
                score += 1; 
            }

            else
            {
                lblCheck1.Text = "Incorrect";
            }

            if (ans2 == "f")
            {
                lblCheck2.Text = "Correct";
                score += 1;
            }

            else
            {
                lblCheck2.Text = "Incorrect";
            }

            if (ans3 == "f")
            {
                lblCheck3.Text = "Correct";
                score += 1;
            }

            else
            {
                lblCheck3.Text = "Incorrect";
            }

            if (ans4 == "f")
            {
                lblCheck4.Text = "Correct";
                score += 1;
            }

            else
            {
                lblCheck4.Text = "Incorrect";
            }

            if (ans5 == "f")
            {
                lblCheck5.Text = "Correct";
                score += 1;
            }

            else
            {
                lblCheck5.Text = "Incorrect";
            }

            if (ans6 == "t")
            {
                lblCheck6.Text = "Correct";
                score += 1;
            }

            else
            {
                lblCheck6.Text = "Incorrect";
            }

            if (ans7 == "t")
            {
                lblCheck7.Text = "Correct";
                score += 1;
            }

            else
            {
                lblCheck7.Text = "Incorrect";
            }

            if (ans8 == "t")
            {
                lblCheck8.Text = "Correct";
                score += 1;
            }

            else
            {
                lblCheck8.Text = "Incorrect";
            }

            if (ans9 == "f")
            {
                lblCheck9.Text = "Correct";
                score += 1;
            }

            else
            {
                lblCheck9.Text = "Incorrect";
            }

            if (ans10 == "t")
            {
                lblCheck10.Text = "Correct";
                score += 1;
            }

            else
            {
                lblCheck10.Text = "Incorrect";
            }

            lblScore.Text = score.ToString();
            score = 0; 
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblCheck1.Text = "";
            lblCheck2.Text = "";
            lblCheck3.Text = "";
            lblCheck4.Text = "";
            lblCheck5.Text = "";
            lblCheck6.Text = "";
            lblCheck7.Text = "";
            lblCheck8.Text = "";
            lblCheck9.Text = "";
            lblCheck10.Text = "";

            txtAns1.Text = "";
            txtAns2.Text = "";
            txtAns3.Text = "";
            txtAns4.Text = "";
            txtAns5.Text = "";
            txtAns6.Text = "";
            txtAns7.Text = "";
            txtAns8.Text = "";
            txtAns9.Text = "";
            txtAns10.Text = "";

            lblScore.Text = "0";

            txtName.Text = ""; 
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            string name;
            string score;
            double calc;
            double percent; 

            score = lblScore.Text; 
            name = txtName.Text;

            calc = double.Parse(score);

            percent = (calc / 10) * 100; 

            if (name == "")
            {
                name = "No Name"; 
            }

            MessageBox.Show("Well, " + name + " you scored: " + percent + "%" + " (" + score + "/10) "); 
        }
    }
}
