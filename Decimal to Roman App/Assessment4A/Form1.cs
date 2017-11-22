using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment4A
{
    public partial class decimalToRomanConverterForm : Form
    {
        public decimalToRomanConverterForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {

            //Test if the textbox field empty
            if (txtBoxDecimalNumberInput.Text == "")
            {
                MessageBox.Show("Please enter a decimal number! This value cannot be empty.");
                lblAnswer.Text = "";
                txtBoxDecimalNumberInput.Focus();

            }
            //if the text field is not empty then conduct other validation tests
            else
            {
                //Data vlidation for the value entered in "txtBoxDecimalNumberInput" using Regex
                //Adding "System.Text.RegularExpressions" as library in order to use the Regex
                //The use of Regex is alternative of the Int.TryParse in order to check if the value entered is numeric

                Regex nonNumericRegex = new Regex(@"\D");
                if (nonNumericRegex.IsMatch(txtBoxDecimalNumberInput.Text))
                {
                    //value is not numeric, not decimal, has special characters/punctuation
                    //show message to aware the user to enter a valid input
                    MessageBox.Show("Please enter a valid value! Only numeric and decimal values accepted.");
                    txtBoxDecimalNumberInput.Text = ""; //empty the entered field
                    lblAnswer.Text = ""; //empty the answer in case there is old value in it
                    txtBoxDecimalNumberInput.Focus(); //focus on the "txtBoxDecimalNumberInput" field
                }
                // if the value is not empty and numeric input
                // then verify if the entry is a decimal number between [1..10] as required by the program
                else if (int.Parse(txtBoxDecimalNumberInput.Text) > 10 || int.Parse(txtBoxDecimalNumberInput.Text) < 1)
                {
                    //value is not in [1..10]
                    //show message to aware the user to enter a valid input
                    MessageBox.Show("Please enter a number between 1 and 10! [1..10]");
                    txtBoxDecimalNumberInput.Text = ""; //empty the entered field
                    lblAnswer.Text = ""; //empty the answer in case there is old value in it
                    txtBoxDecimalNumberInput.Focus(); //focus on the "txtBoxDecimalNumberInput" field
                }
                //if the value entered is valid then
                else
                {
                    int decimalNumber; //declare an integer variable to use for the entered value
                    decimalNumber = int.Parse(txtBoxDecimalNumberInput.Text); //Parse the string value entered to integer
                    switch (decimalNumber) //switch by case of the number entered
                    {
                        case 1: //if the value entered "decimalNumber" is 1 then 
                            lblAnswer.Text = "I"; //show in the answer label the Roman value of 1
                            break;
                        case 2:
                            lblAnswer.Text = "II";
                            break;
                        case 3:
                            lblAnswer.Text = "III";
                            break;
                        case 4:
                            lblAnswer.Text = "IV";
                            break;
                        case 5:
                            lblAnswer.Text = "V";
                            break;
                        case 6:
                            lblAnswer.Text = "VI";
                            break;
                        case 7:
                            lblAnswer.Text = "VII";
                            break;
                        case 8:
                            lblAnswer.Text = "VIII";
                            break;
                        case 9:
                            lblAnswer.Text = "IX";
                            break;
                        case 10:
                            lblAnswer.Text = "X";
                            break;
                        default:
                            lblAnswer.Text = "Not valid value!"; //entry not valid! Something went wrong
                            break;
                    }

                }

            }



        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //on click of the Reset button
            txtBoxDecimalNumberInput.Text = ""; //empty the entered field
            txtBoxDecimalNumberInput.Focus(); //focus on the "txtBoxDecimalNumberInput" field
            lblAnswer.Text = ""; //empty the answer in case there is old value in it
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }
    }
}