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
    /// Логика взаимодействия для AddEditclient.xaml
    /// </summary>
    public partial class AddEditclient : Page
    {
        private string mode;
        //public static clients _newclients;
        private clients _newclients = new clients();

        public AddEditclient(clients selectedclients)
        {
            InitializeComponent();
            _newclients = new clients();
            if (selectedclients != null)
            {
                _newclients = selectedclients;
                mode = "Edit";
            }
            else
            {
                _newclients.clientId = -1;
                foreach (clients cn in TE.clients)
                {
                    if (_newclients.clientId < cn.clientId) _newclients.clientId = cn.clientId + 11;
                    if (_newclients.clientId == cn.clientId) _newclients.clientId += 11;
                }
            }

            DataContext = _newclients;
        }

        

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (String.IsNullOrWhiteSpace(_newclients.lname))
                errors.AppendLine("Укажите имя клиента!");
            if (String.IsNullOrWhiteSpace(_newclients.fname))
                errors.AppendLine("Укажите фамилию клиента!");
            if (String.IsNullOrWhiteSpace(_newclients.mname))
                errors.AppendLine("Укажите отчество клиента!");
            if (_newclients.passportId < 1)
                errors.AppendLine("Укажите номер паспорта!");
            if (_newclients.passportSer < 1)
                errors.AppendLine("Укажите серию паспорта!");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }


            if (mode != "Edit")
                TE.clients.Add(_newclients);
            else
            {
                clients cl = TE.clients.Find(_newclients.clientId);
                cl.lname = _newclients.fname;
                cl.fname = _newclients.lname;
                cl.mname = _newclients.mname;
                cl.passportId = _newclients.passportId;
                cl.passportSer = _newclients.passportSer;
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
            NavigationService.Navigate(new Clients());
            return;
        }
    }
}
