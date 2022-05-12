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
    /// Логика взаимодействия для AddFilm.xaml
    /// </summary>
    public partial class AddFilm : Window
    {
        public AddFilm()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var films = new Films_tb
                {

                    title = namefilmTxt.Text,
                    budget = budgetTxt.Text,
                    rating = Int32.Parse(ratingTxt.Text),
                    country = countryTxt.Text,
                    genres = genresTxt.Text,

                };
                DBContext.filmsentity.Films_tb.Add(films);
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
