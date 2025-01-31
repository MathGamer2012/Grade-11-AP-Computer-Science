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
//Date: <Oct 20 - Oct 23>
//Assignment: Assignment 3 
//Purpose: To make a program to determine shape when given angles and sides 

namespace Quadrilateral
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            double angleA;  //declear variables to store angles, sides, radians, diagonals, and adacjent sums 
            double angleB;
            double angleC;
            double angleD;

            double sideA;
            double sideB;
            double sideC;
            double sideD;

            double radC;
            double radA;
            double diagonalA;
            double diagonalB; 
            double adajcentA;
            double adajcentB; 

            angleA = double.Parse(txtAngle1.Text); // angle 1
            angleB = double.Parse(txtAngle2.Text); // angle 2
            angleC = double.Parse(txtAngle3.Text); // angle 3
            angleD = double.Parse(txtAngle4.Text); // angle 4 

            sideA = double.Parse(txtSide1.Text); // side 1 
            sideB = double.Parse(txtSide2.Text); // side 2
            sideC = double.Parse(txtSide3.Text); // side 3
            sideD = double.Parse(txtSide4.Text); // side 4 

            double angleSum; // declear angleSum to check if the sum of all angles is 360

            radA = Math.Cos((angleA * (Math.PI)) / 180); // calculte radians of angleA 
            radC = Math.Cos((angleC * (Math.PI)) / 180); // calculate radians of angleC (opposite to A) 

            

            diagonalA = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2) - 2 * sideA * sideB * radA); // Find length of diagonal between side A and B
            diagonalB = Math.Sqrt(Math.Pow(sideC, 2) + Math.Pow(sideD, 2) - 2 * sideC * sideD * radC); // Find length of diagonal between side C and D

            angleSum = angleA + angleB + angleC + angleD; // adds all the angles up 
            adajcentA = angleA + angleB; // adds the adajcent angles 
            adajcentB = angleC + angleD; // adds the other adajcent angles 
          

            if (angleA <= 0 || angleB <= 0 || angleC <= 0 || angleD <= 0) // checks if any angle is less than or equal to zero, if it is prints invalid angles, otherwise continues to go thourgh the algrioithim
            {
                lblOutput.Text = "Invalid Angle(s)";
            }

            else // nested else to make sure that invalid angles is not mixed up with impossible 
            {
                    //also all shapes expect for impossible check if the angle sum is 360, so instead of writing it multiple tiemes I mentioned it here 
                    if (sideA <= 0 || sideB <= 0 || sideC <= 0 || sideD <= 0) // checks if sides are illogical 
                    {
                        lblOutput.Text = "Invalid Side";
                    }
                    else if(angleA == 90 && angleB == 90 && angleC == 90 && angleD == 90 && sideA == sideB && sideA == sideC && sideA == sideD && angleSum == 360) // checks if all sides are equal and each angle is 90 degress
                    {
                        lblOutput.Text = "Square";
                    }

                    else if (angleA == 90 && angleB == 90 && angleC == 90 && angleD == 90 && sideA == sideC && sideB == sideD && angleSum == 360) // checks if each angle is 90 degress and if opposite sides are equal
                    {
                        lblOutput.Text = "Rectangle";
                    }

                    else if (angleA == angleC && angleB == angleD && sideA == sideB && sideA == sideC && sideA == sideD && angleSum == 360) // checks if all sides are equal and oppsoite angles are equal 
                    {
                        lblOutput.Text = "Rhombus";
                    }

                    else if (angleA == angleC && angleB == angleD && sideA == sideC && sideB == sideD && angleSum == 360) // checks if opposite sides and angles are equal 
                    {
                        lblOutput.Text = "Parallelogram";
                    }

                    else if (angleB == angleD && sideA == sideD && sideB == sideC && angleSum == 360) // checks if opposite angle is equal and if sideB is equal to SideC and Side A is equal to Side D
                    {
                        lblOutput.Text = "Kite";
                    }

                    else if (angleA != 90 || angleB != 90 || angleC != 90 || angleD != 90 && angleA == angleD && angleC == angleB && sideB == sideD && sideA != sideC && angleSum == 360) // checks if angles across are equal and if opposite side B = side D
                    {
                        lblOutput.Text = "Isosceles Trapezoid";
                    }

                    else if (adajcentA == 180 && adajcentB == 180 && angleA != angleB && angleB != angleC && angleC != angleD && sideA != sideB && sideB != sideC && sideC != sideD && angleSum == 360) // checks if adajcent angles add up to 180 and if sides and angles are not equal 
                    {
                        lblOutput.Text = "Trapezoid";
                    }

                    else if (diagonalA != diagonalB || angleSum != 360) // checks if angleSum is not equal to 360 and if the diagonal is not the same (as no shape as different opposite diagonals) 
                    {
                        lblOutput.Text = "Impossible";
                    }

                    else //after checking every possible outcome prints out undefined for anything that was not mentioned above (e.g. concave quadrilaterals) 
                    {
                        lblOutput.Text = "Undefined Shape";
                    }
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clears the angle and side values and replaces it with what was displayed originally when the program was run 
            txtAngle1.Text = "AngleA";
            txtAngle2.Text = "AngleB";
            txtAngle3.Text = "AngleC";
            txtAngle4.Text = "AngleD";

            txtSide1.Text = "SideA";
            txtSide2.Text = "SideB";
            txtSide3.Text = "SideC";
            txtSide4.Text = "SideD";

            lblOutput.Text = "";

            //Code explnantion: 

            //At the start of the program the user inputs the values of angles and sides 
            //When they click submit the program says the user inputs into their respected varibales (e.g. AngleA) 
            //After given these values the program finds the radians of angle A and C 
            //After finding the radians it calculates the length of the diaognals between side A-B and C-D
            //After it calculates the sum of the angles by adding all the anlgle variables 
            //After that add the adajcent angles to get adajcent sum 
            //Then, it starts evaulting and checks first if angles are illogical (less than or equal to 0) if they are prints invalid angles 
            //Then, in the else statment it evaultes all the other if statments 
            //First checks if sides are illogical (less or equal to 0) if they are prints impossible 
            //Next, checks if each angle is 90 and all sides are equal if so outputs sqaure
            //Checks if each angle is 90 degress and if opposite sides are equal and if they are prints rectangle 
            //Checks if all sides are equal and oppsoite angles are equal and if they are prints rhombus 
            //Checks if opposite sides and angles are equal if they are outputs paralleogram 
            //Checks if opposite angle is equal and if sideB is equal to SideC and Side A is equal to Side D and if they are outputs kite 
            //Checks if angles across are equal and if opposite side B = side D and if they are prints isoceles trapeziod 
            //Checks if adajcent angles add up to 180 and if sides and angles are not equal
            //Checks if angleSum is not equal to 360 and if the diagonal is not the same (as no shape as different opposite diagonals)
            //After checking every possible outcome prints out undefined for anything that was not mentioned above (e.g. concave quadrilaterals) 
            //Lastly, when the user types clear it changes the values back to what they orginally were on the start of the program
        }
    }
}
