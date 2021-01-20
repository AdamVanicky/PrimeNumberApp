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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PrimeNumberApp
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void UlohaJednaStart_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int max = 10;
                PrimeNumberCalculator pnc = new PrimeNumberCalculator();
                List<int> prime = new List<int>();
                int[] pri = prime.ToArray();
                switch (((ComboBoxItem)cbUlohaJedna.SelectedItem).Content.ToString())
                {
                    case "Menší než deset":
                        max = 10;
                        pnc = new PrimeNumberCalculator();
                        prime = pnc.Prime_Numbers_Lower_Than_Ten(max);
                        pri = prime.ToArray();
                        FirstOutput.Text = $"Menší než deset: ";
                        
                        break;
                    case "Obsahuje právě 2 jedničky":
                        max = 150;
                        pnc = new PrimeNumberCalculator();
                        prime = pnc.Prime_Numbers_With_Two_Ones_Together_Up_To_OneHundredFifty(max);
                        pri = prime.ToArray();
                        FirstOutput.Text = $"Obsahuje právě 2 jedničky: ";
                        break;
                    case "Dvojciferná prvočísla do třiceti":
                        max = 30;
                        pnc = new PrimeNumberCalculator();
                        prime = pnc.Two_Digit_Prime_Numbers_Up_To_Thirty(max);
                        pri = prime.ToArray();
                        FirstOutput.Text = $"Dvojciferná prvočísla do třiceti: ";
                        break;
                }
                for (int i = 0; i < pri.Length; i++)
                {
                    FirstOutput.Text += $"{pri[i]} ";
                    System.Threading.Thread.Sleep(1000);
                }
                FirstOutput.Text += "Úloha ukončena";
            }
            catch
            {
                throw new Exception("Vyberte kritérium");
            }
        }

        private void UlohaDvaStart_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int max;
                PrimeNumberCalculator pnc = new PrimeNumberCalculator();
                List<int> prime = new List<int>();
                int[] pri = prime.ToArray();
                switch (((ComboBoxItem)cbUlohaDva.SelectedItem).Content.ToString())
                {

                    case "Menší než deset":
                        max = 10;
                        pnc = new PrimeNumberCalculator();
                        prime = pnc.Prime_Numbers_Lower_Than_Ten(max);
                        pri = prime.ToArray();
                        SecondOutput.Text = $"Menší než deset: ";
                        break;
                    case "Obsahuje právě 2 jedničky":
                        max = 150;
                        pnc = new PrimeNumberCalculator();
                        prime = pnc.Prime_Numbers_With_Two_Ones_Together_Up_To_OneHundredFifty(max);
                        pri = prime.ToArray();
                        SecondOutput.Text = $"Obsahuje právě 2 jedničky: ";
                        break;
                    case "Dvojciferná prvočísla do třiceti":
                        max = 30;
                        pnc = new PrimeNumberCalculator();
                        prime = pnc.Two_Digit_Prime_Numbers_Up_To_Thirty(max);
                        pri = prime.ToArray();
                        SecondOutput.Text = $"Dvojciferná prvočísla do třiceti: ";
                        break;
                }
                for (int i = 0; i < pri.Length; i++)
                {
                    SecondOutput.Text += $"{pri[i]} ";
                    System.Threading.Thread.Sleep(1000);
                }
                SecondOutput.Text += "Úloha ukončena";
            }
            catch
            {
                throw new Exception("Vyberte kritérium");
            }
        }

        private void UlohaTriStart_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int max = 10;
                PrimeNumberCalculator pnc = new PrimeNumberCalculator();
                List<int> prime = new List<int>();
                int[] pri = prime.ToArray();
                switch (((ComboBoxItem)cbUlohaTri.SelectedItem).Content.ToString())
                {
                    case "Menší než deset":
                        max = 10;
                        pnc = new PrimeNumberCalculator();
                        prime = pnc.Prime_Numbers_Lower_Than_Ten(max);
                        pri = prime.ToArray();
                        ThirdOutput.Text = $"Menší než deset: ";
                        break;
                    case "Obsahuje právě 2 jedničky":
                        max = 150;
                        pnc = new PrimeNumberCalculator();
                        prime = pnc.Prime_Numbers_With_Two_Ones_Together_Up_To_OneHundredFifty(max);
                        pri = prime.ToArray();
                        ThirdOutput.Text = $"Obsahuje právě 2 jedničky: ";
                        break;
                    case "Dvojciferná prvočísla do třiceti":
                        max = 30;
                        pnc = new PrimeNumberCalculator();
                        prime = pnc.Two_Digit_Prime_Numbers_Up_To_Thirty(max);
                        pri = prime.ToArray();
                        ThirdOutput.Text = $"Dvojciferná prvočísla do třiceti: ";
                        break;
                }
                for (int i = 0; i < pri.Length; i++)
                {
                    ThirdOutput.Text += $"{pri[i]} ";
                    System.Threading.Thread.Sleep(1000);
                }
                ThirdOutput.Text += "Úloha ukončena";
            }
            catch
            {
                throw new Exception("Vyberte kritérium");
            }
        }
    }
}
