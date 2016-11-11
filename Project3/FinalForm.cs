using System.Windows.Forms;

namespace Project3
{
    public partial class FinalForm : Form
    {
        public FinalForm()
        {
            InitializeComponent();
            LabelPurchase.Text = "We have succesfully charged your card for $ " + Program.TotalCost;
            LabelMovie.Text = Program.MovieSelection.Title + " is going to begin shortly!";

        }

        private void ButtonPlay_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
    }
}
