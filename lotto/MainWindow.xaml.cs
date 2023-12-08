using System;
using System.Collections.Generic;
using System.Windows;

namespace lotto
{
    public partial class MainWindow : Window
    {
        private List<string> arvotutRivit = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
            PopulatePelivalinta();
        }

        private void PopulatePelivalinta()
        {
            pelivalinta.Items.Add("Lotto");
            pelivalinta.Items.Add("Viking Lotto");
            pelivalinta.Items.Add("Eurojackpot");
        }

        private void TulostaButton_Click(object sender, RoutedEventArgs e)
        {
            arvotutRivit.Clear();
            arvotutRivitTextBox.Text = "";

            string valittuPeli = pelivalinta.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(valittuPeli))
            {
                MessageBox.Show("Valitse peli ennen tulostamista.");
                return;
            }

            int rivienMaara;
            if (!int.TryParse(rivienMaaraTextBox.Text, out rivienMaara))
            {
                MessageBox.Show("Syötä kelvollinen rivien määrä.");
                return;
            }

            for (int i = 0; i < rivienMaara; i++)
            {
                string arvottuRivi = ArvoRivi(valittuPeli);
                arvotutRivit.Add(arvottuRivi);
            }

            arvotutRivitTextBox.Text = string.Join(Environment.NewLine, arvotutRivit);
        }

        private string ArvoRivi(string peli)
        {
            Random random = new Random();
            string rivi = "";

            switch (peli)
            {
                case "Lotto":
                    for (int i = 0; i < 7; i++)
                    {
                        int numero = random.Next(1, 40);
                        rivi += numero + " ";
                    }
                    break;
                case "Viking Lotto":
                    for (int i = 0; i < 6; i++)
                    {
                        int numero = random.Next(1, 48);
                        rivi += numero + " ";
                    }
                    break;
                case "Eurojackpot":
                    for (int i = 0; i < 5; i++)
                    {
                        int numero = random.Next(1, 51);
                        rivi += numero + " ";
                    }
                    break;
            }

            return rivi.Trim();
        }

        private void TyhjennaButton_Click(object sender, RoutedEventArgs e)
        {
            arvotutRivit.Clear();
            arvotutRivitTextBox.Text = "";
        }
    }
}