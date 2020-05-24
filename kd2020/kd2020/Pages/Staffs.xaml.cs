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
    /// Логика взаимодействия для Staffs.xaml
    /// </summary>
    public partial class Staffs : Page
    {
        public Staffs()
        {
            InitializeComponent();
            DgridStaffs.ItemsSource = TE.staffs.ToList();

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

        private void BtnT_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Tables());
            return;
        }

        private void Editbtn_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditstaff((sender as Button).DataContext as staffs));
        }

        private void BtnDel_Click(object sender, RoutedEventArgs e)
        {
            var staffsForRemoving = DgridStaffs.SelectedItems.Cast<staffs>().ToList();

            if (MessageBox.Show($"Удалить следующие {staffsForRemoving.Count()} записи?", "Внимание!",
                    MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    TE.staffs.RemoveRange(staffsForRemoving);
                    TE.SaveChanges();
                    MessageBox.Show("Данные удалены!");


                    DgridStaffs.ItemsSource = TE.staffs.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditstaff(null));
            return;
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                TE.ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DgridStaffs.ItemsSource = TE.staffs.ToList();
            }
        }
    }
}
