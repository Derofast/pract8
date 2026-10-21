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
    /// Логика взаимодействия для zadacha6.xaml
    /// </summary>
    public partial class zadacha6 : Window
    {
        public zadacha6()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int n = Convert.ToInt32(chN.Text);
            if (n >= 1 && n <= 100)
            {
                double sum = 0;
                for (int i = 1; i <= n; i++)
                {
                    sum += Math.Pow(i, 2);
                }
                lab.Content = $"FOR: Сумма квадратов = {sum}\n";

                sum = 0;
                int iw = 1;
                while (iw <= n)
                {
                    sum += Math.Pow(iw, 2);
                    iw++;
                }
                lab.Content += $"WHILE: Сумма квадратов = {sum}\n";


                sum = 0;
                iw = 1;
                do
                {
                    sum += Math.Pow(iw, 2);
                    iw++;

                }
                while (iw <= n);
                lab.Content += $"DO WHILE: Сумма квадратов = {sum}\n";

            }
        }
    }
}
