using System;
using System.Windows;

namespace WindowAreaCalculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double width = Convert.ToDouble(txtWidth.Text);
                double height = Convert.ToDouble(txtHeight.Text);
                double frameWidth = Convert.ToDouble(txtFrameWidth.Text);

                double perimeter = 2 * (width + height);
                double glassArea = width * height;
                double totalArea = (width + 2 * frameWidth) * (height + 2 * frameWidth);

                string result = $"Karmin piiri: {perimeter} cm\n" +
                                $"Lasin pinta-ala: {glassArea:F2} cm^2\n" +
                                $"Ikkunan pinta-ala: {totalArea:F2} cm^2";

                txtResults.Text = result;
            }
            catch (FormatException)
            {
                MessageBox.Show("Virheellinen syöte. Syötä arvot numeroina.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Virhe: {ex.Message}");
            }
        }
    }
}
