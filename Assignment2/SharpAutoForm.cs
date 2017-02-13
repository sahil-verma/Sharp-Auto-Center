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
                case "basePrice":
                    //will check if there's any value in text field and it will store number of base price in variable storingData
                    if (basePrice.Text.Length != 0 && (!double.TryParse(basePrice.Text, out storingData)))
                    {
                        MessageBox.Show("Enter numbers only", "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                        basePrice.ResetText();
                    }
                    break;

                case "tradeInAllowance":
                    if (tradeInAllowance.Text.Length != 0 && (!double.TryParse(tradeInAllowance.Text, out storingData)))
                    {
                        MessageBox.Show("Enter numbers only", "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                        tradeInAllowance.ResetText();
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
                case "stereoSystem":

                    if (stereoSystem.Checked)
                    {
                        additionalOptions.Text = (double.Parse(additionalOptions.Text.Equals("") ? "0" : additionalOptions.Text) + 425.76).ToString();
                    }
                    else
                    {
                        additionalOptions.Text = (double.Parse(additionalOptions.Text) - 425.76).ToString();
                    }
                    break;

                case "leatherInterior":

                    if (leatherInterior.Checked)
                    {
                        additionalOptions.Text = (double.Parse(additionalOptions.Text.Equals("") ? "0" : additionalOptions.Text) + 987.41).ToString();
                    }
                    else
                    {
                        additionalOptions.Text = (double.Parse(additionalOptions.Text) - 987.41).ToString();
                    }
                    break;

                case "computerNavigation":

                    if (computerNavigation.Checked)
                    {
                        additionalOptions.Text = (double.Parse(additionalOptions.Text.Equals("") ? "0" : additionalOptions.Text) + 1741.23).ToString();
                    }
                    else
                    {
                        additionalOptions.Text = (double.Parse(additionalOptions.Text) - 1741.23).ToString();
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
                case "standard":
                    if (standard.Checked)
                    {
                        additionalOptions.Text = (double.Parse(additionalOptions.Text.Equals("") ? "0" : additionalOptions.Text)).ToString();
                    }
                    break;

                case "pearlized":
                    if (pearlized.Checked)
                    {
                        additionalOptions.Text = (double.Parse(additionalOptions.Text.Equals("") ? "0" : additionalOptions.Text) + 345.72).ToString();
                    }
                    else
                    {
                        additionalOptions.Text = (double.Parse(additionalOptions.Text.Equals("") ? "0" : additionalOptions.Text) - 345.72).ToString();
                    }
                    break;

                case "customizedDetailing":
                    if (customizedDetailing.Checked)
                    {
                        additionalOptions.Text = (double.Parse(additionalOptions.Text.Equals("") ? "0" : additionalOptions.Text) + 599.99).ToString();
                    }
                    else
                    {
                        additionalOptions.Text = (double.Parse(additionalOptions.Text.Equals("") ? "0" : additionalOptions.Text) - 599.99).ToString();
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
                    if (basePrice.Text.Length != 0)
                    {
                        subTotal.Text = (double.Parse(additionalOptions.Text.Equals("") ? "0" : additionalOptions.Text) + double.Parse(basePrice.Text)).ToString();
                        salesTax.Text = (double.Parse(subTotal.Text) * 0.13).ToString();
                        total.Text = (double.Parse(subTotal.Text) + double.Parse(salesTax.Text)).ToString();
                        amountDue.Text = (double.Parse(total.Text) - (tradeInAllowance.Text.Equals("") ? 0 : double.Parse(tradeInAllowance.Text))).ToString();
                        amountDue.Text = Double.Parse(amountDue.Text).ToString("C", CultureInfo.CurrentCulture);
                    }
                    break;

                // will clear the text fields
                case "Clear":
                    basePrice.ResetText();
                    subTotal.ResetText();
                    salesTax.ResetText();
                    total.ResetText();
                    tradeInAllowance.Text = "0";
                    amountDue.ResetText();
                    standard.Checked = true;
                    pearlized.Checked = false;
                    customizedDetailing.Checked = false;
                    stereoSystem.Checked = false;
                    leatherInterior.Checked = false;
                    computerNavigation.Checked = false;
                    additionalOptions.ResetText();
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
            calculate.PerformClick();
        }

        /// <summary>
        /// to clear the things from menu bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clear.PerformClick();
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
            basePrice.Font = autoCenterFontDialog.Font;
            amountDue.Font = autoCenterFontDialog.Font;
        }

        /// <summary>
        ///  event handler to display the colors for text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            autoCenterColorDialog.ShowDialog();
            basePrice.ForeColor = autoCenterColorDialog.Color;
            amountDue.BackColor = amountDue.BackColor;
            amountDue.ForeColor = autoCenterColorDialog.Color;
        }
    }
}
