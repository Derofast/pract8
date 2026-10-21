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
    /// Логика взаимодействия для zadacha1.xaml
    /// </summary>
    public partial class zadacha1 : Window
    {
        public zadacha1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int k = Convert.ToInt32(chK.Text);

                lab.Items.Add("FOR:");
                lab.Items.Add(" m \t n \t a \t b \t c ");
                for (int n= 2; n < k; n++)
                {
                    int m = n + 1;
                    double a = Math.Pow(m, 2) - Math.Pow(n, 2);
                    int b = 2 * m * n;
                    double c = Math.Pow(m, 2) + Math.Pow(n, 2);
                    lab.Items.Add($" {m} \t {n} \t {a} \t {b} \t {c} ");
                }

                lab.Items.Add("WHILE:");
                lab.Items.Add(" m \t n \t a \t b \t c ");

                int nw = 2;

                while (nw < k)
                {
                    int m = nw + 1;
                    double a = Math.Pow(m, 2) - Math.Pow(nw, 2);
                    int b = 2 * m * nw;
                    double c = Math.Pow(m, 2) + Math.Pow(nw, 2);
                    lab.Items.Add($" {m} \t {nw} \t {a} \t {b} \t {c} ");
                    nw++;
                }

                lab.Items.Add("DO WHILE:");
                lab.Items.Add(" m \t n \t a \t b \t c ");

                nw = 2;

                do
                {
                    int m = nw + 1;
                    double a = Math.Pow(m, 2) - Math.Pow(nw, 2);
                    int b = 2 * m * nw;
                    double c = Math.Pow(m, 2) + Math.Pow(nw, 2);
                    lab.Items.Add($" {m} \t {nw} \t {a} \t {b} \t {c} ");
                    nw++;
                }
                while (nw < k);

            
        }

    }
}
