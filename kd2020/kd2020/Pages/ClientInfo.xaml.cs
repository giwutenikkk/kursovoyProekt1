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
using System.IO;

namespace kd2020.Pages
{
    /// <summary>
    /// Логика взаимодействия для ClientInfo.xaml
    /// </summary>
    public partial class ClientInfo : Page
    {
        List<ClientView> clientout;
        public ClientInfo()
        {
            InitializeComponent();
            StackPanel sp = new StackPanel();
            foreach (kd2020.clients o in TE.clients)
            {
                RadioButton r = new RadioButton();
                r.GroupName = "Cln";
                r.Content = o.lname + " " + o.fname;
                r.Checked += CheckClients;
                sp.Children.Add(r);

            }
            ClnInfo.Content = sp;

        }
        public class ClientView
        {

            public int pasportNum { get; set; }
            public int pasportSer { get; set; }
            public decimal priCe { get; set; }
            public DateTime dateO { get; set; }
            public DateTime dateP { get; set; }
            public int idTicket { get; set; }
            public string townName { get; set; }

        }
        private void CheckClients(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton r)
            {
                
                int idClient = -1;
                List<ClientView> cv = new List<ClientView>();
                foreach (clients c in TE.clients)
                {
                    
                    if (((string)r.Content) == (c.lname + " " + c.fname))
                    {
                        idClient = c.clientId;
                        break;
                    }
                }

                foreach (tickets t in TE.tickets)
                {
                    if (t.clientId == idClient)
                    {
                       
                        ClientView cn = new ClientView();
                        cn.idTicket = t.ticketId;
                        cn.pasportNum = TE.clients.Find(idClient).passportId;
                        cn.pasportSer = TE.clients.Find(idClient).passportSer;
                        foreach(tours ts in TE.tours)
                        {
                            if (t.tourId == ts.tourId)
                            {
                                cn.townName = ts.towns.townName;
                                cn.priCe = ts.tourPrice;
                                cn.dateO = ts.dateDeparture;
                                cn.dateP = ts.dateArrive;
                                break;
                            }

                        }

                        cv.Add(cn);

                    }

                }
                InfoCln.ItemsSource = cv;
                clientout = cv;
            }
        }

        private void ButS(object sender, RoutedEventArgs e)
        {
            StreamWriter sw = new StreamWriter("out.txt");
            sw.WriteLine("Чек на покупку тура");
            sw.WriteLine("___________________");
            string fn = "";
            int sum = 0, pasN = 0, pasS = 0;

            StackPanel sp = (StackPanel)ClnInfo.Content;
            foreach (RadioButton r in sp.Children)
            {
                if (r.IsChecked == true)
                {
                    fn = (string)r.Content;
                    break;
                }
            }
            sw.WriteLine("Клиент: " + fn);
            ClientView cw = (ClientView)InfoCln.Items[0];
            pasN = cw.pasportNum;
            pasS = cw.pasportSer;
            sw.WriteLine("Данные клиента: " + " " + "Номер паспорта " + pasN + " " + "Серия паспорта "  + pasS);
            foreach (ClientView c in clientout)
            {
                sw.WriteLine("Номер билета: " + c.idTicket);
                sw.WriteLine("Цена: " + c.priCe);
                sw.WriteLine("Город: " + c.townName);
                sw.WriteLine("Дата отъезда: " + c.dateO);
                sw.WriteLine("Дата приезда: " + c.dateP);
            }
            sw.WriteLine("___________________");
            sw.WriteLine("                   ");
            sw.WriteLine("Приятного путешествия!");
            sw.Close();

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

        private void BtnT_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Tables());
            return;
        }
    }
}