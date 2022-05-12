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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ListFilms.pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ToFilm_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new pages.Film());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Кликните на кнопку фильмы чтобы просмотреть информацию о всех фильмах. Удачи!");
        }
    }
}
