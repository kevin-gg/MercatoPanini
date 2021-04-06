using System.Windows;

namespace MercatoPanini
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txtTotale.IsEnabled = false;
            double totale = 0;
            if (rdbNormale.IsChecked == true)
            {
                totale += 0.80;
            }
            else if (rdbIntegrale.IsChecked == true)
            {
                totale += 1.00;
            }
            else if (rdbCereali.IsChecked == true)
            {
                totale += 1.20;
            }

            if (rdbProsciutto.IsChecked == true)
            {
                totale += 0.30;
            }
            else if (rdbMortadella.IsChecked == true)
            {
                totale += 0.30;
            }
            else if (rdbHamburger.IsChecked == true)
            {
                totale += 1.70;
            }
            else if (rdbSalsiccia.IsChecked == true)
            {
                totale += 1.30;
            }

            if (chbCipolla.IsChecked == true)
            {
                totale += 0.20;
            }
            if (chbFormaggio.IsChecked == true)
            {
                totale += 0.20;
            }
            if (chbInsalata.IsChecked == true)
            {
                totale += 0.20;
            }
            if (chbPeperoni.IsChecked == true)
            {
                totale += 0.20;
            }

            txtTotale.Text = totale.ToString();
        }
    }
}
