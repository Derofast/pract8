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
            int sumF = 0;
            int st = (int)Math.Pow(10, n - 1);
            int en = (int)Math.Pow(10, n) - 1;

            for (int i = st; i <= en; i++)
            {
                sumF += i;
            }
            lab.Content += $"FOR: {sumF}\n";

            int sumW = 0;
            int iW = st;

            while (iW <= en)
            {
                sumW += iW;
                iW++;
            }
            lab.Content += $"WHILE: {sumW}";

            int sumD = 0;
            int iD = st;

            //popa
        }
    }
}
