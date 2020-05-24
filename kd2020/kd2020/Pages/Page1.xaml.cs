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
using System.Data.SqlClient;
using kd2020.Pages;
using static kd2020.Podkl;

namespace kd2020.Pages
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
       
        public Page1()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            {
                List<roles> rols = TE.roles.ToList();
                foreach (roles r in rols)
                {

                    if (r.login == login.Text && r.password == password.Password)
                    {
                        MessageBox.Show("Вход выполнен"); Roly = r.role;


                        NavigationService.Navigate(new Tables());
                    }

                }
            }

        }
    }
}