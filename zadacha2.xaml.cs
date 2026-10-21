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
    /// Логика взаимодействия для zadacha2.xaml
    /// </summary>
    public partial class zadacha2 : Window
    {
        public zadacha2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int n = Convert.ToInt32(chN.Text);
            int sum = 0;
            int st = (int)Math.Pow(10, n - 1);
            int en = (int)Math.Pow(10, n) - 1;

            for (int i = st; i <= en; i++)
            {
                sum += i;
            }
            lab.Content = $"FOR: {sum}\n";

            sum = 0;
            int iw = st;

            while (iw <= en)
            {
                sum += iw;
                iw++;
            }
            lab.Content += $"WHILE: {sum}\n";

            sum = 0;
            iw = st;
            do
            {
                sum += iw;
                iw++;
            }
            while (iw <= en);
            lab.Content += $"WHILE: {sum}";

        }
    }
}
