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
    /// Логика взаимодействия для AddEditticket.xaml
    /// </summary>
    public partial class AddEditticket : Page
    {
        private string mode;
        private tickets _newTickets = new tickets();
        public AddEditticket(tickets selectedtickets)
        {
            InitializeComponent();
            _newTickets = new tickets();
            if (selectedtickets != null)
            {
                _newTickets = selectedtickets;
                mode = "Edit";
                StackPanel sp = new StackPanel();
                foreach (tours t in TE.tours)
                {
                    RadioButton r = new RadioButton();
                    r.Content = t.tourId;
                    r.Tag = t.tourId;
                    r.GroupName = "tour";
                    if (_newTickets.tourId == (int)r.Tag)
                        r.IsChecked = true;
                    r.IsEnabled = false;
                    sp.Children.Add(r);
                }
                tourscroll.Content = sp;

                sp = new StackPanel();
                foreach (clients c in TE.clients)
                {
                    RadioButton r = new RadioButton();
                    r.Content = c.lname;
                    r.Tag = c.clientId;
                    r.GroupName = "client";
                    if (_newTickets.clientId == (int)r.Tag)
                        r.IsChecked = true;
                    sp.Children.Add(r);
                }
                clientscroll.Content = sp;

                sp = new StackPanel();
                foreach (staffs s in TE.staffs)
                {
                    RadioButton r = new RadioButton();
                    r.Content = s.lname;
                    r.Tag = s.staffId;
                    r.GroupName = "staff";
                    if (_newTickets.staffId == (int)r.Tag)
                        r.IsChecked = true;
                    sp.Children.Add(r);
                }
                staffscroll.Content = sp;
            }

            else
            {
                StackPanel sp = new StackPanel();
                foreach (tours t in TE.tours)
                {
                    RadioButton r = new RadioButton();
                    r.Content = t.tourId;
                    r.Tag = t.tourId;
                    r.GroupName = "tour";
                    sp.Children.Add(r);
                }
                tourscroll.Content = sp;

                sp = new StackPanel();
                foreach (clients c in TE.clients)
                {
                    RadioButton r = new RadioButton();
                    r.Content = c.lname;
                    r.Tag = c.clientId;
                    r.GroupName = "client";
                    sp.Children.Add(r);
                }
                clientscroll.Content = sp;

                sp = new StackPanel();
                foreach (staffs s in TE.staffs)
                {
                    RadioButton r = new RadioButton();
                    r.Content = s.lname;
                    r.Tag = s.staffId;
                    r.GroupName = "staff";
                    sp.Children.Add(r);
                }
                staffscroll.Content = sp;

                _newTickets.ticketId = -1;
                foreach (tickets tt in TE.tickets)
                {
                    if (_newTickets.ticketId < tt.ticketId) _newTickets.ticketId = tt.ticketId + 1;
                    if (_newTickets.ticketId == tt.ticketId) _newTickets.ticketId += 1;
                }
            }

            DataContext = _newTickets;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

     

            if (mode != "Edit")
            {
                _newTickets.tourId = 0;
                _newTickets.clientId = 0;
                _newTickets.staffId = 0;

                StackPanel sp = (StackPanel)tourscroll.Content;
                foreach (RadioButton r in sp.Children)
                {
                    if (r.IsChecked == true)
                        _newTickets.tourId = (int)r.Tag;
                }

                sp = (StackPanel)clientscroll.Content;
                foreach (RadioButton r in sp.Children)
                {
                    if (r.IsChecked == true)
                        _newTickets.clientId = (int)r.Tag;
                }

                sp = (StackPanel)staffscroll.Content;
                foreach (RadioButton r in sp.Children)
                {
                    if (r.IsChecked == true)
                        _newTickets.staffId = (int)r.Tag;
                }


                if (_newTickets.tourId == 0)
                {
                    errors.AppendLine("Выберите тур");
                }

                if (_newTickets.clientId == 0)
                {
                    errors.AppendLine("Выберите клиента");
                }

                if (_newTickets.staffId == 0)
                {
                    errors.AppendLine("Выберите сотрудника");
                }

                if (errors.Length > 0)
                {
                    MessageBox.Show(errors.ToString());
                    return;
                }

                else
                {
                    tours t = TE.tours.Find(_newTickets.tourId);
                    t.ticketQnt -= 1;
                    TE.tickets.Add(_newTickets);
                }

            }
            else
            {
                tickets tt = TE.tickets.Find(_newTickets.ticketId);
                tt.tourId = _newTickets.tourId;
                tt.clientId = _newTickets.clientId;
                tt.staffId = _newTickets.staffId;
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
            NavigationService.Navigate(new Tickets());
            return;
        }
    }
}

