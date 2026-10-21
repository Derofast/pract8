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
    /// Логика взаимодействия для zadacha4.xaml
    /// </summary>
    public partial class zadacha4 : Window
    {
        public zadacha4()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int k = Convert.ToInt32(chK.Text);

                lab.Items.Add("FOR:");
                for (double v = 50.0; v <= 1000; v += 50)
                {
                    double cost = (v / 1000.0) * k;
                    lab.Items.Add($"Вес {v} | Цена {cost}");
                }
      
                lab.Items.Add("WHILE:");
                double w = 50.0;
                while (w <= 1000.0)
                {
                    double cost = (w / 1000.0) * k;
                    lab.Items.Add($"Вес {w} | Цена {cost}");
                    w += 50;
                }

                lab.Items.Add("DO WHILE:");
                w = 50.0;
                do
                {
                    double cost = (w / 1000.0) * k;
                    lab.Items.Add($"Вес {w} | Цена {cost}");
                    w += 50;
                }
                while (w <= 1000);

        }
    }
}
