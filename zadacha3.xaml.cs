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
    /// Логика взаимодействия для zadacha3.xaml
    /// </summary>
    public partial class zadacha3 : Window
    {
        public zadacha3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (cb.SelectedIndex == 0)
            {
                lab.Content = "FOR:\n";
                lab.Content += " x \t t \t y \n";
                for (int x = 4; x <= 28; x++)
                {
                    int t = x + 2;
                    double y = 2 * Math.Pow(t, 2) + 5.5 * t - 2;
                    lab.Content += $" {x} \t {t} \t {y} \n";
                }
            }
            if (cb.SelectedIndex == 1)
            {
                lab.Content = "WHILE:\n";
                lab.Content += " x \t t \t y \n";
                int x = 4;
                while (x <= 28)
                {
                    int t = x + 2;
                    double y = 2 * Math.Pow(t, 2) + 5.5 * t - 2;
                    lab.Content += $" {x} \t {t} \t {y} \n";
                    x++;
                }
            }
            if (cb.SelectedIndex == 2)
            {
                lab.Content = "DO WHILE:\n";
                lab.Content += " m \t n \t a \t b \t c \n";
                int x = 4;
                do
                {
                    int t = x + 2;
                    double y = 2 * Math.Pow(t, 2) + 5.5 * t - 2;
                    lab.Content += $" {x} \t {t} \t {y} \n";
                    x++;
                }
                while (x <= 28);

            }
        }
    }
}
