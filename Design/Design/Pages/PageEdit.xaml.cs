using Design.Classes;
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
    /// Логика взаимодействия для PageEdit.xaml
    /// </summary>
    public partial class PageEdit : Page
    {
        public PageEdit()
        {
            InitializeComponent();
            CmbDriver.ItemsSource = Odb.cars.Driver.Select(x => x.FullName).ToList();
            Check();        
        }

        private void Check()
        {
            var order = Odb.cars.Order.FirstOrDefault(x => x.Id == PageOrder.IDOrder);
            if (order != null)
            {
                TxbName.Text = order.Name;
                TxbA.Text = order.PointDeparture;
                TxbB.Text = order.PointDestination;
                TxbDistanse.Text = order.Distance.ToString();
                TxbWeight.Text = order.Weight.ToString();
            }
        }

        private void BtnChange_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var a = Odb.cars.Order.FirstOrDefault(x => x.Id == PageOrder.IDOrder);
                var b = Odb.cars.TrailerDriver.FirstOrDefault(x => x.Id == PageOrder.IDDriver);
                a.Name = TxbName.Text;
                a.PointDeparture = TxbA.Text;
                a.PointDestination = TxbB.Text;
                a.Distance = int.Parse(TxbDistanse.Text);
                a.Weight = int.Parse(TxbWeight.Text);
                b.IdDriver = Odb.cars.Driver.FirstOrDefault(x => x.FullName == CmbDriver.SelectedItem.ToString()).Id;
                Odb.cars.SaveChanges();
                MessageBox.Show("Все прекрасно шоколадно");
                PageClass.frmNav.Navigate(new PageOrder());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ОШИБКА");
            }
        }
    }
}
