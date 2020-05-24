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
    /// Логика взаимодействия для Clients.xaml
    /// </summary>
    public partial class Clients : Page
    {
        public Clients()
        {
            InitializeComponent();
            DgridClients.ItemsSource = TE.clients.ToList();
            switch (Roly)
            {
                case "Менеджер":
                    AddBtn.Visibility = Visibility.Hidden;
                    AddBtn.IsEnabled = false;
                    DelBtn.IsEnabled = false;
                    DelBtn.Visibility = Visibility.Hidden;
                    break;

                case "Администратор":
                    break;

            }
        }

        private void BtnT_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Tables());
            return;
        }

        private void Editbtn_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditclient ((sender as Button).DataContext as clients));
        }

        private void DelBtn_Click(object sender, RoutedEventArgs e)
        {
            var clientsForRemoving = DgridClients.SelectedItems.Cast<clients>().ToList();

            if (MessageBox.Show($"Удалить следующие {clientsForRemoving.Count()} записи?", "Внимание!",
                    MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    TE.clients.RemoveRange(clientsForRemoving);
                    TE.SaveChanges();
                    MessageBox.Show("Данные удалены!");


                    DgridClients.ItemsSource = TE.clients.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditclient(null));
            return;
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                TE.ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DgridClients.ItemsSource = tourfirmEntities.GetContext().clients.ToList();
            }
        }
    }
}
