using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ShoppingCartApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BuyButton_Click(object sender, RoutedEventArgs e)
        {
            // Ostetaan tuotteet eli poistetaan ne kärrystä
            foreach (var checkBox in FindVisualChildren<CheckBox>(this))
            {
                if (checkBox.IsChecked == true)
                {
                    checkBox.IsChecked = false;
                }
            }

            // Tyhjennetään näkymä
            stockPanel.Children.Clear();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            // Lisätään tuote kärryyn, kun CheckBox valitaan
            CheckBox checkBox = sender as CheckBox;
            if (checkBox != null && checkBox.IsChecked == true)
            {
                TextBlock textBlock = new TextBlock();
                textBlock.Text = checkBox.Content.ToString();
                stockPanel.Children.Add(textBlock);
            }
        }

        // Etsii kaikki annetun tyyppiset kontrollit
        private static System.Collections.Generic.IEnumerable<T> FindVisualChildren<T>(DependencyObject depObj) where T : DependencyObject
        {
            if (depObj != null)
            {
                for (int i = 0; i < VisualTreeHelper.GetChildrenCount(depObj); i++)
                {
                    DependencyObject child = VisualTreeHelper.GetChild(depObj, i);
                    if (child != null && child is T)
                    {
                        yield return (T)child;
                    }

                    foreach (T childOfChild in FindVisualChildren<T>(child))
                    {
                        yield return childOfChild;
                    }
                }
            }
        }
    }
}
