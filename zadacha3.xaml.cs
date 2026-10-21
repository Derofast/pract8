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

                lab.Items.Add("FOR:");
                lab.Items.Add(" x \t t \t y ");
                for (int x = 4; x <= 28; x++)
                {
                    int t = x + 2;
                    double y = 2 * Math.Pow(t, 2) + 5.5 * t - 2;
                    lab.Items.Add($" {x} \t {t} \t {y} ");
                }

                lab.Items.Add("WHILE:");
                lab.Items.Add(" x \t t \t y ");
                int xw = 4;
                while (xw <= 28)
                {
                    int t = xw + 2;
                    double y = 2 * Math.Pow(t, 2) + 5.5 * t - 2;
                    lab.Items.Add($" {xw} \t {t} \t {y} ");
                    xw++;
                }

                lab.Items.Add("DO WHILE:");
                lab.Items.Add(" m \t n \t a \t b \t c ");
                xw = 4;
                do
                {
                    int t = xw + 2;
                    double y = 2 * Math.Pow(t, 2) + 5.5 * t - 2;
                    lab.Items.Add($" {xw} \t {t} \t {y} ");
                    xw++;
                }
                while (xw <= 28);

            
        }
    }
}
