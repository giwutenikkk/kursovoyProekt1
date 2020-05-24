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
using static kd2020.Podkl;

namespace kd2020.Pages
{
    /// <summary>
    /// Логика взаимодействия для Country.xaml
    /// </summary>
    public partial class Country : Page
    {
        public Country()
        {
            InitializeComponent();
            DgridCountry.ItemsSource = TE.country.ToList();
            switch (Roly)
            {
                case "Менеджер":
                    BtnAdd.Visibility = Visibility.Hidden;
                    BtnAdd.IsEnabled = false;
                    BtnDel.IsEnabled = false;
                    BtnDel.Visibility = Visibility.Hidden;
                    break;

                case "Администратор":
                    break;

            }
        }

        private void Editbtn_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditcountry((sender as Button).DataContext as country));
        }

        private void BtnT_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Tables());
            return;
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditcountry(null));
            return;
        }

        private void BtnDel_Click(object sender, RoutedEventArgs e)
        {
            var countryForRemoving = DgridCountry.SelectedItems.Cast<country>().ToList();

            if (MessageBox.Show($"Удалить следующие {countryForRemoving.Count()} записи?", "Внимание!",
                    MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    TE.country.RemoveRange(countryForRemoving);
                    TE.SaveChanges();
                    MessageBox.Show("Данные удалены!");


                    DgridCountry.ItemsSource = TE.tours.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                TE.ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DgridCountry.ItemsSource = TE.country.ToList();
            }
        }
    }
}
