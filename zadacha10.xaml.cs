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
    /// Логика взаимодействия для zadacha10.xaml
    /// </summary>
    public partial class zadacha10 : Window
    {
        public zadacha10()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int n = Convert.ToInt32(chN.Text);

            double ras = 0;
            double path = 0;
            
            for (int i= 1; i <= n; i++)
            {
                double step = 1.0 / i;
                path += step;
                if (i % 2 != 0)
                {
                    ras += step;
                }
                else
                {
                    ras -= step;
                }
            }
            double rasM = ras * 1000;
            double pathM = path * 1000;
            lab.Content = $"FOR: Расстояние от дома {rasM} метров, Общий пройденый путь {pathM} метров\n";

            ras = 0;
            path = 0;
            int iw = 1;
            while (iw <= n)
            {
                double step = 1.0 / iw;
                path += step;
                if (iw % 2 != 0)
                {
                    ras += step;
                }
                else
                {
                    ras -= step;
                }
                iw++;
            }
            rasM = ras * 1000;
            pathM = path * 1000;
            lab.Content += $"WHILE: Расстояние от дома {rasM} метров, Общий пройденый путь {pathM} метров\n";

            ras = 0;
            path = 0;
            iw = 1;
            do
            {
                double step = 1.0 / iw;
                path += step;
                if (iw % 2 != 0)
                {
                    ras += step;
                }
                else
                {
                    ras -= step;
                }
                iw++;
            }
            while (iw <= n);
            rasM = ras * 1000;
            pathM = path * 1000;
            lab.Content += $"DO WHILE: Расстояние от дома {rasM} метров, Общий пройденый путь {pathM} метров";
        }
    }
}
