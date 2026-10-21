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
    /// Логика взаимодействия для zadacha1.xaml
    /// </summary>
    public partial class zadacha1 : Window
    {
        public zadacha1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int k = Convert.ToInt32(chK.Text);

            if (cb.SelectedIndex == 0)
            {
                lab.Content = "FOR:\n";
                lab.Content += " m \t n \t a \t b \t c \n";
                for (int n= 2; n < k; n++)
                {
                    int m = n + 1;
                    double a = Math.Pow(m, 2) - Math.Pow(n, 2);
                    int b = 2 * m * n;
                    double c = Math.Pow(m, 2) + Math.Pow(n, 2);
                    lab.Content += $" {m} \t {n} \t {a} \t {b} \t {c} \n";
                }
            }
            if (cb.SelectedIndex == 1)
            {
                lab.Content = "WHILE:\n";
                lab.Content += " m \t n \t a \t b \t c \n";

                int n = 2;

                while (n < k)
                {
                    int m = n + 1;
                    double a = Math.Pow(m, 2) - Math.Pow(n, 2);
                    int b = 2 * m * n;
                    double c = Math.Pow(m, 2) + Math.Pow(n, 2);
                    lab.Content += $" {m} \t {n} \t {a} \t {b} \t {c} \n";
                    n++;
                }
            }
            if (cb.SelectedIndex == 2)
            {
                lab.Content = "DO WHILE:\n";
                lab.Content += " m \t n \t a \t b \t c \n";

                int n = 2;

                do
                {
                    int m = n + 1;
                    double a = Math.Pow(m, 2) - Math.Pow(n, 2);
                    int b = 2 * m * n;
                    double c = Math.Pow(m, 2) + Math.Pow(n, 2);
                    lab.Content += $" {m} \t {n} \t {a} \t {b} \t {c} \n";
                    n++;
                }
                while (n < k);

            }
        }

    }
}
