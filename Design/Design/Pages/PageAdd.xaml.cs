using Design.Classes;
using Design.DBModel;
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

namespace Design.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageAdd.xaml
    /// </summary>
    public partial class PageAdd : Page
    {
        public PageAdd()
        {
            InitializeComponent();
            CmbDriver.ItemsSource = Odb.cars.Driver.Select(x => x.FullName).ToList();
        }

        //Выбор случайной машины из имеющихся
        private int CheckTrailer()
        {
            Random Ran = new Random();
            List<int> glist = new List<int>();
            foreach (var driver in Odb.cars.Driver.Select(x => x.Id))
            {
                glist.Add(driver);
            }
            int IdTrailer = Ran.Next(glist.Count);
            glist.Clear();
            return IdTrailer;
            
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Order order = new Order()
                {
                    Name = TxbName.Text,
                    PointDeparture = TxbA.Text,
                    PointDestination = TxbB.Text,
                    Distance = int.Parse(TxbDistanse.Text),
                    Weight = int.Parse(TxbWeight.Text),
                };
                TrailerDriver trailerDriver = new TrailerDriver()
                {
                    IdTrailer = CheckTrailer(),
                    IdDriver = Odb.cars.Driver.FirstOrDefault(x => x.FullName == CmbDriver.SelectedItem.ToString()).Id,
                    IdOrder = order.Id,
                    IdRoleInTrailer = 1
                };
                Odb.cars.Order.Add(order);
                Odb.cars.TrailerDriver.Add(trailerDriver);
                Odb.cars.SaveChanges();
                PageClass.frmNav.Navigate(new PageOrder());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ОШИБКА");
            }
        }
    }
}
