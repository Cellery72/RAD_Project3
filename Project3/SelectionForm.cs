//
//      Author: Justin Ellery
//        Date: 2016-11-11
//       Class: Selection Form
// Description: SelectionForm will handing choosing a movie and display attributes about that film before moving onto the OrderForm
//

using System.ComponentModel;
using System.Windows.Forms;

namespace Project3
{
    public partial class SelectionForm : Form
    {
        // public properties
        public SplashForm previousForm;

        // private properties
        // Selected Movie & BindingList to hold our movies
        private Movie selectedMovie;
        private BindingList<Movie> movieList;

        public SelectionForm()
        {
            InitializeComponent();

            // set the private bindinglist and give the list box a data source
            movieList = new BindingList<Movie>(Utility.GetMovieList());
            ListBoxCurrentMovies.DisplayMember = "Title";
            ListBoxCurrentMovies.DataSource = movieList;
            
            // don't select a row to begin
            ListBoxCurrentMovies.SelectedIndex = -1;
            // Clear the Controls upon first load.
            SetMovieSelection(true);
        }

        // Event Handlers
        // --------------
        private void ListBoxCurrentMovies_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if ((sender as ListBox).SelectedIndex != -1)
            {
                selectedMovie = (Movie)(sender as ListBox).SelectedItem;
                // set Movie selection from selectedMovie
                SetMovieSelection(false);
            }
        }
        private void ButtonNext_Click(object sender, System.EventArgs e)
        {
            // initialize in the new form
            OrderForm orderForm = new OrderForm();
            orderForm.previousForm = this;
            // swap forms
            orderForm.Show();
            this.Hide();
        }

        // Private Functions
        // -----------------
        private void SetMovieSelection(bool clear)
        {
            // set/disable next button
            ButtonNext.Enabled = !clear;
            if (clear)
            {
                PictureBoxMovie.BackgroundImage = null;
                TextBoxTitle.Clear();
                TextBoxCategory.Clear();
                TextBoxCost.Clear();
                // confirm selectedMovie is null if we're clearing
                selectedMovie = null;
                Program.MovieSelection = null;
            }
            else
            {
                PictureBoxMovie.BackgroundImage = selectedMovie.Poster;
                TextBoxTitle.Text = selectedMovie.Title;
                TextBoxCategory.Text = selectedMovie.Genre;
                TextBoxCost.Text = "$ " + selectedMovie.Price.ToString();
                Program.MovieSelection = selectedMovie;
            }
        }

    }
}
