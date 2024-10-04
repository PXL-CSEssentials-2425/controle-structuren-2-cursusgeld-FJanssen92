using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Cursusgeld
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int year;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void testButton_Click(object sender, RoutedEventArgs e)
        {
            

            bool isValid = int.TryParse(yearTextBox.Text, out year);

            if (isValid)
            {
                numericLabel.Content = "Is numeriek";
            }
            else
            {
                numericLabel.Content = "Geef een correct jaartal!";
            }


        }

        private void yearTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            numericLabel.Content = "";
            leapyearLabel.Content = "";
        }

        private void calcButton_Click(object sender, RoutedEventArgs e)
        {
            double lessonPrice = 1.5;
            double hours = double.Parse(hoursTextBox.Text);
            double price = lessonPrice * hours;

            if (DateTime.IsLeapYear(year))
            {
                leapyearLabel.Content = "Is een schrikkeljaar";
                priceTextBox.Text = Convert.ToString(price + lessonPrice);
            }
            else
            {
                leapyearLabel.Content = "Is geen schrikkeljaar";
                priceTextBox.Text = Convert.ToString(price);
            }

            
        }
    }
}
