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
    /// Логика взаимодействия для PageOrder.xaml
    /// </summary>
    public partial class PageOrder : Page
    {
        public static int IDOrder {get; set;} //переменная которую можно использовать везде
        public static int IDDriver { get; set; }
        public PageOrder()
        {
            InitializeComponent();
            DG.ItemsSource = Odb.cars.TrailerDriver.ToList();
        }

        private void CmbSort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Простенькая сортировка на выбор
            switch (CmbSort.SelectedIndex)
            {
                case 0:
                    DG.ItemsSource = Odb.cars.TrailerDriver.OrderBy(x => x.Order.Weight).ToList();
                    break;
                case 1:
                    DG.ItemsSource = Odb.cars.TrailerDriver.OrderBy(x => x.Order.Distance).ToList();
                    break;
                default:
                    break;
            }
        }

        private void BtnDel_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int delIdTrailer, delIdOrder; //Этих штук две потому что нужно удалить значение из двух таблиц вместо одной
                dynamic row = DG.SelectedItem; //Записываем в неопределенную желаемую строку
                delIdTrailer = row.Id;
                delIdOrder = row.IdOrder;
                var delTrailer = Odb.cars.TrailerDriver.FirstOrDefault(x => x.Id == delIdTrailer);
                var delOrder = Odb.cars.Order.FirstOrDefault(x => x.Id == delIdOrder);
                Odb.cars.TrailerDriver.Remove(delTrailer);
                Odb.cars.Order.Remove(delOrder);
                Odb.cars.SaveChanges();
                MessageBox.Show("Вуаля");
                DG.ItemsSource = Odb.cars.TrailerDriver.ToList(); //Обновление данных в датагриде после удаления
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            PageClass.frmNav.Navigate(new PageAdd());
        }

        private void BtnChange_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                dynamic row = DG.SelectedItem;
                IDOrder = row.IdOrder;
                IDDriver = row.Id;
                PageClass.frmNav.Navigate(new PageEdit());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
