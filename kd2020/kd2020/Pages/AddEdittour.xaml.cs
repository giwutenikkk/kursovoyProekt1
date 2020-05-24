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
    /// Логика взаимодействия для AddEdittour.xaml
    /// </summary>
    public partial class AddEdittour : Page
    {
        private string mode;
        private tours _newTour = new tours();
        public AddEdittour(tours selectedtours)
        {
            InitializeComponent();
            StackPanel sp = new StackPanel();
            foreach (towns t in TE.towns)
            {
                RadioButton r = new RadioButton();
                r.Content = t.townName;
                r.GroupName = "townsselect";

                if (selectedtours != null && selectedtours.townId == t.townId)
                {
                    r.IsChecked = true;
                }

                sp.Children.Add(r);
            }



            townsscroll.Content = sp;
            townsscroll.HorizontalScrollBarVisibility = ScrollBarVisibility.Auto;
            _newTour = new tours();
            if (selectedtours != null)
            {
                _newTour = selectedtours;
                mode = "Edit";
                DD.DisplayDate = selectedtours.dateDeparture;
                DA.DisplayDate = selectedtours.dateArrive;
                
            }
            else
            {
                DD.DisplayDate = DateTime.Now;
                DA.DisplayDate = DateTime.Now;

                _newTour.tourId = -1;
                foreach(tours t in TE.tours)
                {
                    if (_newTour.tourId < t.tourId) _newTour.tourId = t.tourId + 111;
                    if (_newTour.tourId == t.tourId) _newTour.tourId += 111;
                }
            }

            DataContext = _newTour;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (_newTour.daysQnt < 1)
                errors.AppendLine("Количество должно быть от 1");


     
            

            StackPanel sp = (StackPanel)townsscroll.Content;
            foreach (RadioButton r in sp.Children)
            {
                if (r.IsChecked == true)
                {
                    foreach (towns t in TE.towns)
                    {
                        if ((string) r.Content == t.townName)
                        {
                            _newTour.towns = t;
                            break;
                        }
                    }
                    break;
                }
            }

            if (_newTour.towns == null)
                errors.AppendLine("Выберите город");
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (mode != "Edit")
                TE.tours.Add(_newTour);
            else
            {
                tours t = TE.tours.Find(_newTour.tourId);
                t.tourPrice = _newTour.tourPrice;
                t.townId = _newTour.townId;
                t.ticketQnt = _newTour.ticketQnt;
                if (DD.SelectedDate != null)
                    t.dateDeparture = (DateTime)DD.SelectedDate;
                if (DA.SelectedDate != null)
                    t.dateArrive = (DateTime)DA.SelectedDate;
                t.daysQnt = _newTour.daysQnt;
            }
            try
            {
                TE.SaveChanges();
                MessageBox.Show("Информация сохранена");
                Manager.MainFrame.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Tours());
            return;
        }
    }
}
