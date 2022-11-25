using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Maz maz = new Maz(24, 15);
        Man man = new Man(16, 10);
        Mersedes mers = new Mersedes(20, 25);

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {


            switch (bus_type.Text)
            {
                case "MAN":
                    if (man.StartTrip((string)CityName.Content, endList.Text))
                    {
                        price.Content = $"Цена: {man.Price}";
                    }
                    else
                    {
                        price.Content = "Нет мест";
                    }
                    break;

                case "MAZ":
                    if (maz.StartTrip((string)CityName.Content, endList.Text))
                    {
                        price.Content = $"Цена: {man.Price}";
                    }
                    else
                    {
                        price.Content = "Нет мест";
                    }
                    break;

                case "MERS":
                    if (mers.StartTrip((string)CityName.Content, endList.Text))
                    {
                        price.Content = $"Цена: {man.Price}";
                    }
                    else
                    {
                        price.Content = "Нет мест";
                    }
                    break;

            }

            //Новая станция
            switch (CityName.Content)
            {
                case "Гомель":
                    CityName.Content = "Речица"; break;
                case "Речица":
                    CityName.Content = "Светлогорск"; break;
                case "Светлогорск":
                    CityName.Content = "Жлобин"; break;
                case "Жлобин":
                    CityName.Content = "Бобруйск"; break;
                case "Бобруйск":
                    CityName.Content = "Гомель"; break;
            }

            man.NewStation((string)CityName.Content);
            maz.NewStation((string)CityName.Content);
            mers.NewStation((string)CityName.Content);

            man_info.Content = $"MAN\n{man.ShowInfo()}";
            maz_info.Content = $"MAZ\n{maz.ShowInfo()}";
            mers_info.Content = $"MERS\n{mers.ShowInfo()}";
        }

        private void bus_type_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
