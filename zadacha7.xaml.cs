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
    /// Логика взаимодействия для zadacha7.xaml
    /// </summary>
    public partial class zadacha7 : Window
    {
        public zadacha7()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int n = Convert.ToInt32(chN.Text);

            double d = 0.0;

            for (int i = 1; i <= n; i++)
            {
                d += 1.0 / i;

            }
            lab.Content = $"FOR: Сумма = {d}\n";

            int iw = 1;
            d = 0.0;

            while (iw <= n)
            {
                d += 1.0 / iw;
                iw++;
            }
            lab.Content += $"WHILE: Сумма = {d}\n";

            iw = 1;
            d = 0.0;

            do
            {
                d += 1.0 / iw;
                iw++;

            }
            while (iw <= n);
            lab.Content += $"DO WHILE: Сумма = {d}";
        }
    }
}
