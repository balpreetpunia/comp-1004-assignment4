using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{/// <summary>
/// App Name - Movie Bonanza
/// Author - Balpreet Punia
/// Student Id - 200335082
/// Creation Date - 2017-03-05
/// Description - This app lets user place an order and buy a computer.
/// </summary>
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        
        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            StartForm startForm = new StartForm();
            this.SplashTimer.Enabled = false;
            startForm.Show();
            this.Hide();
        }

       
    }
}
