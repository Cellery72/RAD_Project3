//
//      Author: Justin Ellery
//        Date: 2016-11-11
//       Class: SplashForm
// Description: The Splash Form displays the logo for exactly a second and a half.
//
using System;
using System.Windows.Forms;

namespace Project3
{
    public partial class SplashForm : Form
    {
        public bool isClosed = false;

        public SplashForm()
        {
            InitializeComponent();
            this.SplashTimer.Start();
        }

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            Timer tim = sender as Timer;
            tim.Stop();
            SelectionForm selectionForm = new SelectionForm();
            isClosed = true;
            selectionForm.previousForm = this;
            selectionForm.Show();
            this.Hide();

        }
    }
}
