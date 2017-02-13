///<summary>
///	Name of Programme - Sharp Auto Center
///	Name - sahil verma
///	Student Number - 200335300
///	Date Last Modified - Feb-12, 2017
///	Short revision history - functionality added, structured, gui, splash form
///	Description - the app calculates the amount due for the purchases done by the customer
/// </summary>

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class SharpAutoForm : Form
    {
        //3. create a reference to the previous form
        public Form previousForm;


        //CONSTRUCTORS +++++++++++++++++++++++++++++++++++++++++++

        /// <summary>
        /// default constructor
        /// </summary>
        public SharpAutoForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// event handler for the valid inputs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _textFields(object sender, EventArgs e)
        {
            //textbox _textFields = (Button)sender;
            TextBox _textFields = sender as TextBox;
            //data will be stored for basePrice and trade-inAllowance will be stored in storingData
            double storingData;
            switch (_textFields.Name.ToString())
            {
                case "basePriceTextBox":
                    //will check if there's any value in text field and it will store number of base price in variable storingData
                    if (basePriceTextBox.Text.Length != 0 && (!double.TryParse(basePriceTextBox.Text, out storingData)))
                    {
                        MessageBox.Show("Enter numbers only", "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                        basePriceTextBox.ResetText();
                    }
                    break;

                case "tradeInAllowanceTextBox":
                    if (tradeInAllowanceTextBox.Text.Length != 0 && (!double.TryParse(tradeInAllowanceTextBox.Text, out storingData)))
                    {
                        MessageBox.Show("Enter numbers only", "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                        tradeInAllowanceTextBox.ResetText();
                    }
                    break;
            }
        }

        /// <summary>
        /// event handler for check boxes which will give the additional cost for additional items
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _checkBox(object sender, EventArgs e)
        {
            //CheckBox _checkBox = (Button)sender;
            CheckBox _checkBox = sender as CheckBox;
            switch (_checkBox.Name)
            {
                case "stereoSystemCheckBox":

                    if (stereoSystemCheckBox.Checked)
                    {
                        additionalOptionsTextBox.Text = (double.Parse(additionalOptionsTextBox.Text.Equals("") ? "0" : additionalOptionsTextBox.Text) + 425.76).ToString();
                    }
                    else
                    {
                        additionalOptionsTextBox.Text = (double.Parse(additionalOptionsTextBox.Text) - 425.76).ToString();
                    }
                    break;

                case "leatherInteriorCheckBox":

                    if (leatherInteriorCheckBox.Checked)
                    {
                        additionalOptionsTextBox.Text = (double.Parse(additionalOptionsTextBox.Text.Equals("") ? "0" : additionalOptionsTextBox.Text) + 987.41).ToString();
                    }
                    else
                    {
                        additionalOptionsTextBox.Text = (double.Parse(additionalOptionsTextBox.Text) - 987.41).ToString();
                    }
                    break;

                case "computerNavigationCheckBox":

                    if (computerNavigationCheckBox.Checked)
                    {
                        additionalOptionsTextBox.Text = (double.Parse(additionalOptionsTextBox.Text.Equals("") ? "0" : additionalOptionsTextBox.Text) + 1741.23).ToString();
                    }
                    else
                    {
                        additionalOptionsTextBox.Text = (double.Parse(additionalOptionsTextBox.Text) - 1741.23).ToString();
                    }
                    break;
            }
        }

        /// <summary>
        /// event handler for radioButtons which will give additional cost for exterior finish
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _radioButton(object sender, EventArgs e)
        {
            //RadioButton _radioButton = (Button)sender;
            RadioButton _radioButton = sender as RadioButton;
            switch (_radioButton.Name)
            {
                case "standardRadioButton":
                    if (standardRadioButton.Checked)
                    {
                        additionalOptionsTextBox.Text = (double.Parse(additionalOptionsTextBox.Text.Equals("") ? "0" : additionalOptionsTextBox.Text)).ToString();
                    }
                    break;

                case "pearlizedRadioButton":
                    if (pearlizedRadioButton.Checked)
                    {
                        additionalOptionsTextBox.Text = (double.Parse(additionalOptionsTextBox.Text.Equals("") ? "0" : additionalOptionsTextBox.Text) + 345.72).ToString();
                    }
                    else
                    {
                        additionalOptionsTextBox.Text = (double.Parse(additionalOptionsTextBox.Text.Equals("") ? "0" : additionalOptionsTextBox.Text) - 345.72).ToString();
                    }
                    break;

                case "customizedDetailingRadioButton":
                    if (customizedDetailingRadioButton.Checked)
                    {
                        additionalOptionsTextBox.Text = (double.Parse(additionalOptionsTextBox.Text.Equals("") ? "0" : additionalOptionsTextBox.Text) + 599.99).ToString();
                    }
                    else
                    {
                        additionalOptionsTextBox.Text = (double.Parse(additionalOptionsTextBox.Text.Equals("") ? "0" : additionalOptionsTextBox.Text) - 599.99).ToString();
                    }
                    break;
            }
        }


        /// <summary>
        /// event handler for buttons to calculate, clear and exit the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _buttonClick(object sender, EventArgs e)
        {
            //Button _textFields = (Button)sender;
            Button _buttonClick = sender as Button;

            switch (_buttonClick.Text.ToString())
            {
                //calculate the amount due
                case "Calculate":
                    if (basePriceTextBox.Text.Length != 0)
                    {
                        subTotalTextBox.Text = (double.Parse(additionalOptionsTextBox.Text.Equals("") ? "0" : additionalOptionsTextBox.Text) + double.Parse(basePriceTextBox.Text)).ToString();
                        salesTaxTextBox.Text = (double.Parse(subTotalTextBox.Text) * 0.13).ToString();
                        totalTextBox.Text = (double.Parse(subTotalTextBox.Text) + double.Parse(salesTaxTextBox.Text)).ToString();
                        amountDueTextBox.Text = (double.Parse(totalTextBox.Text) - (tradeInAllowanceTextBox.Text.Equals("") ? 0 : double.Parse(tradeInAllowanceTextBox.Text))).ToString();
                        amountDueTextBox.Text = Double.Parse(amountDueTextBox.Text).ToString("C", CultureInfo.CurrentCulture);
                    }
                    break;

                // will clear the text fields
                case "Clear":
                    basePriceTextBox.ResetText();
                    subTotalTextBox.ResetText();
                    salesTaxTextBox.ResetText();
                    totalTextBox.ResetText();
                    tradeInAllowanceTextBox.Text = "0";
                    amountDueTextBox.ResetText();
                    standardRadioButton.Checked = true;
                    pearlizedRadioButton.Checked = false;
                    customizedDetailingRadioButton.Checked = false;
                    stereoSystemCheckBox.Checked = false;
                    leatherInteriorCheckBox.Checked = false;
                    computerNavigationCheckBox.Checked = false;
                    additionalOptionsTextBox.ResetText();
                    break;
                
                // will exit the form
                case "Exit":
                    this.Close();
                    break;
            }
        }

        /// <summary>
        /// event handler for splashForm for closing and opening of sharpAutoCenter form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void autoCenterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you Sure", "Confirm",
                                  MessageBoxButtons.OKCancel,
                                  MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                this.previousForm.Close();
            }

            else
            {
                e.Cancel = true;
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SharpAutoCenter_Load(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void stereoSystem_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void additionalOptions_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// to exit the form from menu bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// to calculate the amount due from menu bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calculateButton.PerformClick();
        }

        /// <summary>
        /// to clear the things from menu bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearButton.PerformClick();
        }

        /// <summary>
        /// to give small decription for the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program calculates the amount due on a New or Used Vehicle", "About",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }

        /// <summary>
        /// event handler to display the font 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            autoCenterFontDialog.ShowDialog();
            basePriceTextBox.Font = autoCenterFontDialog.Font;
            amountDueTextBox.Font = autoCenterFontDialog.Font;
        }

        /// <summary>
        ///  event handler to display the colors for text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            autoCenterColorDialog.ShowDialog();
            basePriceTextBox.ForeColor = autoCenterColorDialog.Color;
            amountDueTextBox.BackColor = amountDueTextBox.BackColor;
            amountDueTextBox.ForeColor = autoCenterColorDialog.Color;
        }
    }
}
