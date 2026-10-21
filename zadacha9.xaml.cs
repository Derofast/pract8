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
    /// Логика взаимодействия для zadacha9.xaml
    /// </summary>
    public partial class zadacha9 : Window
    {
        public zadacha9()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int n = Convert.ToInt32(chN.Text);

            if (n >= 1 && n <= 100)
            {

                int x = 2;
                double d = 0;

                for (int i= 1; i <= n; i++)
                {
                    d += Math.Pow(x, i) / i;

                }
                lab.Content = $"FOR: Сумма = {d}\n";

                int iw = 0;
                d = 0;

                while (iw < n)
                {
                    d += Math.Pow(x, (iw+1)) / (iw+1);
                    iw++;
                }
                lab.Content += $"WHILE: Сумма = {d}\n";

                iw = 1;
                d = 0;

                do
                {
                    d += Math.Pow(x, iw) / iw;
                    iw++;

                }
                while (iw <= n);

                lab.Content += $"DO WHILE: Сумма = {d}";

            }
        }
    }
}
