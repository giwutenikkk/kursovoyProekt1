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
    /// Логика взаимодействия для AddEdittown.xaml
    /// </summary>
    public partial class AddEdittown : Page
    {
        private string mode;
        private towns _newtowns = new towns();

        public AddEdittown(towns selectedtowns)
        {
            InitializeComponent();
            _newtowns = new towns();
            if (selectedtowns != null)
            {
                _newtowns = selectedtowns;
                mode = "Edit";
                nametown.Text = _newtowns.townName;
                tId.Text = _newtowns.townId.ToString();
                tId.IsEnabled = false;

                StackPanel sp = new StackPanel();
                foreach (country c in TE.country)
                {
                    RadioButton r = new RadioButton();
                    r.Content = c.countryName;
                    r.Tag = c.countryId;
                    r.GroupName = "country";
                    if (_newtowns.countryId == (int)r.Tag)
                        r.IsChecked = true;
                    sp.Children.Add(r);
                }
                countryscroll.Content = sp;

            }
            else
            {

                StackPanel sp = new StackPanel();
                foreach (country c in TE.country)
                {
                    RadioButton r = new RadioButton();
                    r.Content = c.countryName;
                    r.Tag = c.countryId;
                    r.GroupName = "country";
                    sp.Children.Add(r);
                }

                countryscroll.Content = sp;

                mode = "New";
                _newtowns.townId = -1;
                foreach (towns t in TE.towns)
                {
                    if (_newtowns.townId < t.townId) _newtowns.townId = t.townId + 10;
                    if (_newtowns.townId == t.townId) _newtowns.townId += 10;
                }
                townsId.Text = Convert.ToString(_newtowns.townId);
                townsId.Visibility = Visibility.Hidden;
                townsId.IsEnabled = false;
                tId.Text = _newtowns.townId.ToString();
                
            }

            DataContext = _newtowns;
        }

        private void Savebtn_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            

           

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (mode != "Edit")
            {

                StackPanel sp = (StackPanel)countryscroll.Content;
                foreach (RadioButton r in sp.Children)
                {
                    if (r.IsChecked == true)
                        _newtowns.countryId = (int)r.Tag;
                }

                _newtowns.townName = nametown.Text;
                TE.towns.Add(_newtowns);


            }

             else

            {
                towns t = TE.towns.Find(_newtowns.townId);
                t.townName = nametown.Text;
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
            NavigationService.Navigate(new Towns());
            return;
        }
    }
}
