using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ListFilms.windows
{
    /// <summary>
    /// Логика взаимодействия для EditFilm.xaml
    /// </summary>
    public partial class EditFilm : Window
    {
        public EditFilm()
        {
            InitializeComponent();
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var film = DBContext.filmsentity.Films_tb.ToList().Find(x => x.id == DBContext.IdFilm);

                film.title = namefilmTxt.Text;
                    film.budget = budgetTxt.Text;
                    film.rating = Int32.Parse(ratingTxt.Text);
                    film.country = countryTxt.Text;
                    film.genres = genresTxt.Text;
                DBContext.filmsentity.SaveChanges();
                this.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
