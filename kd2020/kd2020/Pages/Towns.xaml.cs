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
    /// Логика взаимодействия для Towns.xaml
    /// </summary>
    public partial class Towns : Page
    {
        public Towns()
        {
            InitializeComponent();
            switch (Roly)
            {
                case "Менеджер":
                    AddBtn.Visibility = Visibility.Hidden;
                    AddBtn.IsEnabled = false;
                    DelBtn.IsEnabled = false;
                    DelBtn.Visibility = Visibility.Hidden;
                    break;

                case "Администратор":
                    AddBtn.Visibility = Visibility.Visible;
                    AddBtn.IsEnabled = true;
                    DelBtn.IsEnabled = true;
                    DelBtn.Visibility = Visibility.Visible;
                    break;

            }
          
        }

        private void EditBtnT_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEdittown((sender as Button).DataContext as towns));
        }

        private void BtnT_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Tables());
            return;
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEdittown(null));
            return;

        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                TE.ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DgridTowns.ItemsSource = TE.towns.ToList();
            }
        }

        private void DelBtn_Click(object sender, RoutedEventArgs e)
        {
            var townsForRemoving = DgridTowns.SelectedItems.Cast<towns>().ToList();

            if (MessageBox.Show($"Удалить следующие {townsForRemoving.Count()} записи?", "Внимание!",
                    MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    TE.towns.RemoveRange(townsForRemoving);
                    TE.SaveChanges();
                    MessageBox.Show("Данные удалены!");


                    DgridTowns.ItemsSource = TE.towns.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}
