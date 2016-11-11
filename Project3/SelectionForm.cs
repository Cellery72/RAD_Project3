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
        // Selected Movie & BindingList to hold our movies
        private Movie selectedMovie;
        private BindingList<Movie> movieList;

        public SelectionForm()
        {
            InitializeComponent();

            // set the private binding list and give the list box a data source
            movieList = new BindingList<Movie>(Utility.GetMovieList());
            ListBoxCurrentMovies.DisplayMember = "Title";
            ListBoxCurrentMovies.DataSource = movieList;
            // don't select a row to begin
            ListBoxCurrentMovies.SelectedIndex = -1;
            // Clear the Controls upon first load.
            SetMovieSelection(true);
        }

        private void ListBoxCurrentMovies_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if ((sender as ListBox).SelectedIndex != -1)
            {
                selectedMovie = (Movie)(sender as ListBox).SelectedItem;
                SetMovieSelection(false);
            }
        }
        private void SetMovieSelection(bool clear)
        {
            if (clear)
            {
                PictureBoxMovie.BackgroundImage = null;
                TextBoxTitle.Clear();
                TextBoxCategory.Clear();
                TextBoxCost.Clear();
            }
            else
            {

                PictureBoxMovie.BackgroundImage = selectedMovie.Poster;
                TextBoxTitle.Text = selectedMovie.Title;
                TextBoxCategory.Text = selectedMovie.Genre;
                TextBoxCost.Text = selectedMovie.Price.ToString();
            }
        }
    }
}
