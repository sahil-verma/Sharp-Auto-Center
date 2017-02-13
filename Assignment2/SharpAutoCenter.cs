using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class SharpAutoCenter : Form
    {
        public SharpAutoCenter()
        {
            InitializeComponent();
        }

        private void _textFields(object sender, EventArgs e)
        {
            //textbox _textFields = (Button)sender;
            TextBox _textFields = sender as TextBox;
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

        private void _buttonClick(object sender, EventArgs e)
        {
            //Button _textFields = (Button)sender;
            Button _buttonClick = sender as Button;

            switch (_buttonClick.Text.ToString())
            {
                case "Calculate":
                    if (basePrice.Text.Length != 0)
                    {
                        subTotal.Text = (double.Parse(additionalOptions.Text.Equals("") ? "0" : additionalOptions.Text) + double.Parse(basePrice.Text)).ToString();
                        salesTax.Text = (double.Parse(subTotal.Text) * 0.13).ToString();
                        total.Text = (double.Parse(subTotal.Text) + double.Parse(salesTax.Text)).ToString();
                        amountDue.Text = (double.Parse(total.Text) - (tradeInAllowance.Text.Equals("") ? 0 : double.Parse(tradeInAllowance.Text))).ToString();
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

                case "Exit":
                    this.Close();
                    break;
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calculate.PerformClick();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clear.PerformClick();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program calculates the amount due on a New or Used Vehicle", "About",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            autoCenterFontDialog.ShowDialog();
            basePrice.Font = autoCenterFontDialog.Font;
            amountDue.Font = autoCenterFontDialog.Font;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            autoCenterColorDialog.ShowDialog();
            basePrice.ForeColor = autoCenterColorDialog.Color;
            amountDue.BackColor = amountDue.BackColor;
            amountDue.ForeColor = autoCenterColorDialog.Color;
        }
    }
}
