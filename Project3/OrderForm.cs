//
//      Author: Justin Ellery
//        Date: 2016-11-11
//       Class: Order Form
// Description: OrderForm handles viewing the customer's order 
//
using System;
using System.Linq;
using System.Windows.Forms;

namespace Project3
{
    public partial class OrderForm : Form
    {
        // public properties
        public SelectionForm previousForm;
                
        // default constructor
        public OrderForm()
        {
            InitializeComponent();
            LoadMovie();
        }

        // Event Handlers
        // ------------------
        private void ButtonStream_Click(object sender, System.EventArgs e)
        {
            FinalForm finalForm = new FinalForm();

            finalForm.Show();
            this.Hide();
        }
        private void ButtonCancel_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
        private void ButtonBack_Click(object sender, System.EventArgs e)
        {
            this.previousForm.Show();
            this.Close();
        }
        private void CheckboxDVD_CheckedChanged(object sender, System.EventArgs e)
        {
            // handle the checkbox flip flopping
            OrderDVD((sender as CheckBox).Checked);
        }

        // Private Methods 
        // -----------------
        private void LoadMovie()
        {
            // set movie properties
            TextBoxTitle.Text = Program.MovieSelection.Title;
            TextBoxCategory.Text = Program.MovieSelection.Genre;
            PictureBoxPoster.BackgroundImage = Program.MovieSelection.Poster;

            TextBoxCost.Text = "$ " + Program.MovieSelection.Price.ToString();

            // calculate the cost
            double cost = Program.MovieSelection.Price;
            double dvdCost = (CheckboxDVD.Checked)?10:0;
            double subTotal = Math.Round(cost + dvdCost,2);
            double salesTax = Math.Round(cost * 0.13,2);
            double grandTotal = subTotal + salesTax;

            // Set grand Total
            Program.TotalCost = grandTotal;

            // display values
            TextBoxDVD.Text = "$ " + dvdCost.ToString();
            TextBoxSubTotal.Text = "$ " + subTotal.ToString();
            TextBoxSalesTax.Text = "$ " + salesTax.ToString();
            TextBoxGrandTotal.Text = "$ " + grandTotal.ToString();
        }
        private void OrderDVD(bool isChecked)
        {
            // show/hide DVD controls
            LabelDVD.Visible = isChecked;
            TextBoxDVD.Visible = isChecked;

            // calculate the dvd cost and update the textbox
            double dvdCost = (isChecked) ? 10 : 0;
            TextBoxDVD.Text = "$ " + dvdCost.ToString();

            //update SubTotal, Sales Tax & Grand Total
            double subTotal = Math.Round(FindTheDouble(TextBoxCost.Text) + dvdCost,2);
            TextBoxSubTotal.Text = "$ " + subTotal.ToString();

            double salesTax = Math.Round(subTotal * 0.13,2);
            TextBoxSalesTax.Text = "$ " + salesTax.ToString();

            double grandTotal = subTotal + salesTax;
            TextBoxGrandTotal.Text = "$ " + grandTotal.ToString();
            Program.TotalCost = grandTotal;
            

        }

        private double FindTheDouble(string s)
        {
            double result = 0;
            bool success = double.TryParse(new string(s
                                 .SkipWhile(x => !char.IsDigit(x))
                                 .TakeWhile(x => char.IsDigit(x) || x == '.')
                                 .ToArray()), out result);
            return result;
        }

    }
}
