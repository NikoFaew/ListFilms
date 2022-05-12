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
    /// Логика взаимодействия для Film.xaml
    /// </summary>
    public partial class Film : Page
    {
        public Film()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            listView.ItemsSource = DBContext.filmsentity.Films_tb.ToList();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            new windows.AddFilm().ShowDialog();
        }

        private void UpBtn_Click(object sender, RoutedEventArgs e)
        {
            LoadData();
        }

        private void DelBtn_Click(object sender, RoutedEventArgs e)
        {
            if (listView.SelectedItems != null)
            {
                foreach (var item in listView.SelectedItems)
                {
                    DBContext.filmsentity.Films_tb.Remove((Films_tb)item);
                }
            }
            DBContext.filmsentity.SaveChanges();
            LoadData();
        }

        private void EdBtn_Click(object sender, RoutedEventArgs e)
        {
            var item = (Films_tb)listView.SelectedItem;
            if (listView.SelectedItem != null)
            {
                DBContext.IdFilm = item.id;
                new windows.EditFilm().Show();
            }
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new pages.MainPage());
        }
    }
}
