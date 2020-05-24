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
    /// Логика взаимодействия для AddEditstaff.xaml
    /// </summary>
    public partial class AddEditstaff : Page
    {
        private string mode;
        private staffs _newStaff = new staffs();
        public AddEditstaff(staffs selectedstaffs)
        {
            InitializeComponent();
            _newStaff = new staffs();
            if (selectedstaffs != null)
            {
                _newStaff = selectedstaffs;
                mode = "Edit";
                DE.DisplayDate = selectedstaffs.dateEmployment;
              
            }

            else
            {
                DE.DisplayDate = DateTime.Now;
                _newStaff.staffId = -1;
                foreach (staffs st in TE.staffs)
                {
                    if (_newStaff.staffId < st.staffId) _newStaff.staffId = st.staffId + 1;
                    if (_newStaff.staffId == st.staffId) _newStaff.staffId += 1;
                }
            }

            DataContext = _newStaff;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (String.IsNullOrWhiteSpace(_newStaff.lname))
                errors.AppendLine("Укажите фамилию сотрудника!");
            if (String.IsNullOrWhiteSpace(_newStaff.fname))
                errors.AppendLine("Укажите имя сотрудника!");
            if (String.IsNullOrWhiteSpace(_newStaff.mname))
                errors.AppendLine("Укажите отчество сотрудника!");
            if (_newStaff.passportId < 1)
                errors.AppendLine("Укажите номер паспорта!");
            if (_newStaff.passportSer < 1)
                errors.AppendLine("Укажите серию паспорта!");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (mode != "Edit")
                TE.staffs.Add(_newStaff);
            else
            {
                MessageBox.Show(_newStaff.dateEmployment.ToString());
                staffs sf = TE.staffs.Find(_newStaff.staffId);
                sf.lname = _newStaff.lname;
                sf.fname = _newStaff.fname;
                sf.mname = _newStaff.mname;
                sf.passportId = _newStaff.passportId;
                sf.passportSer = _newStaff.passportSer;
                if (DE.SelectedDate != null)
                sf.dateEmployment = (DateTime)DE.SelectedDate;
                sf.phoneNum = _newStaff.phoneNum;
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
            NavigationService.Navigate(new Staffs());
            return;
        }
    }
}

