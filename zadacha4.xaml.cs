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
using System.Windows.Shapes;

namespace pract8
{
    /// <summary>
    /// Логика взаимодействия для zadacha4.xaml
    /// </summary>
    public partial class zadacha4 : Window
    {
        public zadacha4()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int k = Convert.ToInt32(chK.Text);

            if (cb.SelectedIndex == 0)
            {
                lab.Content = "FOR:\n";
                for (double w = 50.0; w <= 1000; w += 50)
                {
                    double cost = (w / 1000.0) * k;
                    lab.Content += $"Вес {w} | Цена {cost}\n";
                }
            }
            if (cb.SelectedIndex == 1)
            {
                lab.Content = "WHILE:\n";
                double w = 50.0;
                while (w <= 1000.0)
                {
                    double cost = (w / 1000.0) * k;
                    lab.Content += $"Вес {w} | Цена {cost}\n";
                    w += 50;
                }
            }
            if (cb.SelectedIndex == 2)
            {
                lab.Content = "DO WHILE:\n";
                double w = 50.0;
                do
                {
                    double cost = (w / 1000.0) * k;
                    lab.Content += $"Вес {w} | Цена {cost}\n";
                    w += 50;
                }
                while (w <= 1000);

            }
        }
    }
}
