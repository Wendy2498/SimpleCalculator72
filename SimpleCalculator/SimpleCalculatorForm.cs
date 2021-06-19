/*Wendy Faulk
 * 6/17/2021
 * CIS 123
 * Week 5 Murach Coding Assignments (Teamwork--done individually)
 * Extra Ex 7-2 Add Data Validation to Simple Calculator
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class SimpleCalculatorForm : Form
    {
        public SimpleCalculatorForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        //Add try-catch statement. Catch any exceptions.
        {
            try
            {   //Step 6: Add code that performs calculation and displays if entries are valid
                if (IsValidData())
                {
                    decimal operand1 = Convert.ToDecimal(txtOperand1.Text);
                    string operator1 = txtOperator.Text;
                    decimal operand2 = Convert.ToDecimal(txtOperand2.Text);
                    decimal result = Calculate(operand1, operator1, operand2);

                    result = Math.Round(result, 4);
                    this.txtResult.Text = result.ToString();
                    txtOperand1.Focus();
                }
            }
            ////Add 3 more catch blocks
            ////catch format exceptions with message box
            //catch (FormatException)
            //{
            //    MessageBox.Show(
            //        "Invalid numeric format. Please check all entries.",
            //        "Entry Error");
            //}
            ////catch overflow exceptions with message box
            //catch (OverflowException)
            //{
            //    MessageBox.Show(
            //        "Overflow error. Please enter smaller values.",
            //        "Entry Error");
            //}
            ////catch dividing by zero exceptions with message box
            //catch (DivideByZeroException)
            //{
            //    MessageBox.Show(
            //        "Divide-by-zero error. Please enter a non-zero value for operand 2.",
            //        "Entry Error");
            //}
            catch (Exception ex)
            {
                //Message box with message, type & stack trace
                MessageBox.Show(ex.Message + "\n\n" +
                ex.GetType().ToString() + "\n" +
                ex.StackTrace, "Exception");
            }
        }


        //STEP 6: isValiddata method calls methods

        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";

            // testing for Operand1 
            errorMessage += IsPresent(txtOperand1.Text, txtOperand1.Tag.ToString());
            errorMessage += IsDecimal(txtOperand1.Text, txtOperand1.Tag.ToString());
            errorMessage += IsWithinRange(txtOperand1.Text, txtOperand1.Tag.ToString(), 0, 1000000);

            // testing for Operator
            errorMessage += IsPresent(txtOperator.Text, txtOperator.Tag.ToString());
            errorMessage += IsDecimal(txtOperator.Text, txtOperator.Tag.ToString());
            errorMessage += IsOperator(txtOperand1.Text, txtOperand1.Tag.ToString());
            errorMessage += IsValidOperation(txtOperator.Text, txtOperator.Tag.ToString());

            // testing for Operand2
            errorMessage += IsPresent(txtOperand2.Text, txtOperand2.Tag.ToString());
            errorMessage += IsDecimal(txtOperand2.Text, txtOperand2.Tag.ToString());
            errorMessage += IsWithinRange(txtOperand2.Text, txtOperand2.Tag.ToString(), 0, 1000000);
            errorMessage += IsValidOperation(txtOperand2.Text, txtOperand2.Tag.ToString());

            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
            }
            return success;
        }

        //Step 2 Code 3 methods
        //IsPresent method verifies that fields aren't empty
        private string IsPresent(string value, string name)
        {
            string msg = "";
            if (value == "")
            {
                msg = name + " is a required field.\n";
            }
            return msg;
        }

        // IsDecimal method ensures values are decimals
        private string IsDecimal(string value, string name)
        {      //declaring variable for message
            string msg = "";
            if (!Decimal.TryParse(value, out decimal number))
            {
                msg += name + " must be a vaild decimal value.\n";
            }
            return msg;
        }


        //IsWithinRange method ensures values are in proper range
        private string IsWithinRange(string value, string name, decimal min, decimal max)
        {
            string msg = "";
            if (Decimal.TryParse(value, out decimal number))
            {
                if (number < min || number > max)
                    msg += name + " must be between " + min + " and " + max + ".\n";

            }
            return msg;
        }

        //Step 3 Code method IsOperator
        //IsOperator checks that value is + - * or /
        private string IsOperator(string value, string name)        
        {                                                     
            string msg = "";
            if (txtOperator.Text != "+" || txtOperator.Text != "-" || txtOperator.Text != "*" || txtOperator.Text != "/")
            {
                msg = name + " must be + - * or /";
            }
            return msg;
        }

        //Step 4 Code method IsValidOperation
        //IsOperation checks for divide by zero operation
        private string IsValidOperation(string value, string name)
        {
            string msg = "";
            if ((txtOperator.Text == "/") && (txtOperand2.Text == "0"))
            {
                msg += name + "Division by zero error";
            }
            return msg;
        }


        //Step 5 Code method IsValidData
        //IsValidData checks Operand1 & Operand2 entry 
        private string IsValidData(string value, string name, decimal min, decimal max)
        {
            string msg = "";
            if (Decimal.TryParse(value, out decimal number))
            {
                if (number < min || number > max)
                    msg += name + " must be between " + min + " and " + max + ".\n";

            }
            return msg;
        }


        private decimal Calculate(decimal operand1, string operator1,
            decimal operand2)
        {
            decimal result = 0;
            if (operator1 == "+")
                result = operand1 + operand2;
            else if (operator1 == "-")
                result = operand1 - operand2;
            else if (operator1 == "*")
                result = operand1 * operand2;
            else if (operator1 == "/")
                result = operand1 / operand2;
            return result;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearResult(object sender, EventArgs e)
        {
            this.txtResult.Text = "";
        }
    }
}
