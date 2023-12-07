using System;
using System.Windows;

namespace WpfCalculator
{
    public partial class MainWindow : Window
    {
        private double result = 0.0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonSum_Click(object sender, RoutedEventArgs e)
        {
            PerformOperation('+');
        }

        private void ButtonSubtract_Click(object sender, RoutedEventArgs e)
        {
            PerformOperation('-');
        }

        private void ButtonDivide_Click(object sender, RoutedEventArgs e)
        {
            PerformOperation('/');
        }

        private void ButtonMultiply_Click(object sender, RoutedEventArgs e)
        {
            PerformOperation('*');
        }

        private void ButtonReset_Click(object sender, RoutedEventArgs e)
        {
            result = 0.0;
            textBoxResult.Text = result.ToString();
            textBoxNumber.Text = string.Empty;
        }

        private void PerformOperation(char operation)
        {
            if (double.TryParse(textBoxNumber.Text, out double number))
            {
                switch (operation)
                {
                    case '+':
                        result += number;
                        break;
                    case '-':
                        result -= number;
                        break;
                    case '*':
                        result *= number;
                        break;
                    case '/':
                        if (number != 0)
                        {
                            result /= number;
                        }
                        else
                        {//akaja ei voi olla nolla
                            MessageBox.Show("jakaja ei voi olla nolla!", "virhe", MessageBoxButton.OK, MessageBoxImage.Error);
                            return;
                        }
                        break;
                }

                textBoxResult.Text = result.ToString();
                textBoxNumber.Text = string.Empty;
            }
            else
            {//ei kelvollinen luku
                MessageBox.Show("syötä kelvollinen numero!", "virhe", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
