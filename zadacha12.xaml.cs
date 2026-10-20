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
    /// Логика взаимодействия для zadacha12.xaml
    /// </summary>
    public partial class zadacha12 : Window
    {
        public zadacha12()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int n = Convert.ToInt32(chN.Text);
            int startNum = n * (n - 1) + 1;

            long sum = 0;
            int Num = startNum;

            for (int i = 0; i < n; i++)
            {
                sum += Num;
                Num += 2;
            }
            lab.Content = $"FOR: {n}^3 = {sum}\n";


            sum = 0;
            Num = startNum;
            int count = 0;
            while (count < n)
            {
                sum += Num;
                Num += 2;
                count++;
            }
            lab.Content += $"WHILE: {n}^3 = {sum}\n";

            sum = 0;
            Num = startNum;
            count = 0;
            do
            {
                sum += Num;
                Num += 2;
                count++;
            }
            while (count < n);
            lab.Content += $"DO WHILE: {n}^3 = {sum}\n";
        }
    }
}
