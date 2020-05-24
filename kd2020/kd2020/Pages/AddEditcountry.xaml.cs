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
    /// Логика взаимодействия для AddEditcountry.xaml
    /// </summary>
    public partial class AddEditcountry : Page
    {
        private string mode;
        private country _newcountry = new country();
        public AddEditcountry(country selectedcountry)
        {
            InitializeComponent();
            _newcountry = new country();
            if (selectedcountry != null)
            {
                _newcountry = selectedcountry;
                mode = "Edit";
            }

            else
            {

                _newcountry.countryId = -1;
                foreach (country ct in TE.country)
                {
                    if (_newcountry.countryId < ct.countryId) _newcountry.countryId = ct.countryId + 11;
                    if (_newcountry.countryId == ct.countryId) _newcountry.countryId += 11;
                }
            }

            DataContext = _newcountry;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (String.IsNullOrWhiteSpace(_newcountry.countryName))
                errors.AppendLine("Укажите название страны");
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
            }

            if (mode != "Edit")
                TE.country.Add(_newcountry);
            else
            {
                country ct = TE.country.Find(_newcountry.countryId);
                ct.countryName = _newcountry.countryName;
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
            NavigationService.Navigate(new Country());
            return;
        }
    }
}
