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
    /// Логика взаимодействия для AddEditrole.xaml
    /// </summary>
    public partial class AddEditrole : Page
    {
        private string mode;
        private roles _newRole = new roles();
        public AddEditrole(roles selectedrole)
        {
            InitializeComponent();
            _newRole = new roles();
            if (selectedrole != null)
            {
                _newRole = selectedrole;
                mode = "Edit";
                login1.IsEnabled = false;
                //контейнер для объектов 1
                StackPanel sp = new StackPanel();
                // перебираем всех сотрудников
                foreach (staffs s in TE.staffs)
                {
                    // создаем новую кнопку
                    RadioButton r = new RadioButton();
                    // задаем надпись около кнопки
                    r.Content = s.lname;
                    //в тег записываем номер сотрудника = фамилии, чтобы не потерять и не искать заново
                    r.Tag = s.staffId;
                    //делаем группу кнопк, когда 1, другие убираются
                    r.GroupName = "staff";
                    //если номер сотрудника совпадает с тегом
                    if (_newRole.staffId == (int)r.Tag)
                        //выбираем эту кнопку
                        r.IsChecked = true;
                    //запрещаем редактирование 
                    r.IsEnabled = false;
                    //добавляем кнопку в контейнер
                    sp.Children.Add(r);
                }
                //задаем содержимое окна прокрутки
                staffscroll.Content = sp;
            }

            else
            {
                
                StackPanel sp = new StackPanel();
                foreach (staffs s in TE.staffs)
                {
                    RadioButton r = new RadioButton();
                    r.Content = s.lname;
                    r.Tag = s.staffId;
                    r.GroupName = "staff";
                    sp.Children.Add(r);
                }

                staffscroll.Content = sp;
            }

            DataContext = _newRole;

        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            //если добавляем новое
            if (mode != "Edit")
            {
                //получаем содержимое окна прокрутки
                StackPanel sp = (StackPanel)staffscroll.Content;
                //перебираем все кнопки
                foreach (RadioButton r in sp.Children)
                {
                    //если кнопка выбрана
                    if (r.IsChecked == true)
                        //задаем добавляемые роли ид сотрудника по выбранной кнопке
                        _newRole.staffId = (int)r.Tag;
                }

                TE.roles.Add(_newRole);

            }

            else
            {
                roles rl = TE.roles.Find(_newRole.staffId);
                rl.login = _newRole.login;
                rl.password = _newRole.password;
                rl.role = _newRole.role;

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
            NavigationService.Navigate(new Roles());
            return;
        }
    }
}
