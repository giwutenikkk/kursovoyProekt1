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
    /// Логика взаимодействия для Tables.xaml
    /// </summary>
    public partial class Tables : Page
    {
        public Tables()
        {
            InitializeComponent();

        }

        private void BtnClient(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Clients());
            return;
        }

        private void BtnTicket(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Tickets());
            return;
        }

        private void BtnTour(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Tours());
            return;
        }

        private void BtnCountry(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Country());
            return;
        }

        private void BtnTown(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Towns());
            return;
        }

        private void BtnRole(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Roles());
            return;
        }

        private void BtnStaff(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Staffs());
            return;
        }

        private void Put_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ClientInfo());
            return;
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Roly = "";
            NavigationService.Navigate(new Page1());
            return;
        }
    }
}
