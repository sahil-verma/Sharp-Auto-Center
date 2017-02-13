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
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            //1. intantiate 
            SharpAutoForm autoCenterForm = new SharpAutoForm();

            //2. pass a reference to the 
            autoCenterForm.previousForm = this;

            this.splashFormTimer.Enabled = false;
            autoCenterForm.Show();
            this.Hide();
            //this.Show();
            //this.Close();
        
        }
    }
}
