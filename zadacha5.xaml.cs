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
    /// Логика взаимодействия для zadacha5.xaml
    /// </summary>
    public partial class zadacha5 : Window
    {
        public zadacha5()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int b = Convert.ToInt32(chN.Text);
            if (b >= 100)
            {
                int count = 0;
                double sum = 0.0;
                for (int i = 100; i < b; i++)
                {
                    sum += i;
                    count++;
                }
                lab.Content = $"FOR: Ср. арифметическое суммы = {sum/count}\n";

                count = 0;
                sum = 0.0;
                int iw = 100;
                while (iw < b)
                {
                    sum += iw;
                    count++;
                    iw++;
                }
                lab.Content += $"WHILE: Ср. арифметическое суммы = {sum/count}\n";

                count = 0;
                sum = 0.0;
                iw = 100;
                do
                {
                    sum += iw;
                    count++;
                    iw++;

                }
                while (iw < b);
                lab.Content += $"DO WHILE: Ср. арифметическое суммы = {sum/count}\n";

            }
        }
    }
}
