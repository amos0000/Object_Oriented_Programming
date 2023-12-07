using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows;

namespace WpfStudentApp
{
    [Serializable]
    public class Opiskelija
    {
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public string OpiskelijaID { get; set; }
        public string Sähköposti { get; set; }
        public string Puhelinnumero { get; set; }
    }

    public partial class MainWindow : Window
    {
        private List<Opiskelija> opiskelijat = new List<Opiskelija>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, RoutedEventArgs e)
        {
            Opiskelija uusiOpiskelija = new Opiskelija
            {
                Etunimi = txtFirstName.Text,
                Sukunimi = txtLastName.Text,
                OpiskelijaID = txtStudentID.Text,
                Sähköposti = txtEmail.Text,
                Puhelinnumero = txtPhoneNumber.Text
            };

            if (!OnkoUniikkiID(uusiOpiskelija.OpiskelijaID))
            {
                MessageBox.Show("OpiskelijaID ei ole uniikki. Syötä uniikki OpiskelijaID.", "Virhe", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            opiskelijat.Add(uusiOpiskelija);
            PäivitäOpiskelijatTextBlock();
            TyhjennäTekstikentät();
        }

        private void btnSaveToFile_Click(object sender, RoutedEventArgs e)
        {
            TallennaTiedostoon(opiskelijat, "opiskelijat.dat");
        }

        private void btnLoadFromFile_Click(object sender, RoutedEventArgs e)
        {
            opiskelijat = LataaTiedostosta<List<Opiskelija>>("opiskelijat.dat");
            PäivitäOpiskelijatTextBlock();
        }

        private bool OnkoUniikkiID(string opiskelijaID)
        {
            foreach (var opiskelija in opiskelijat)
            {
                if (opiskelija.OpiskelijaID == opiskelijaID)
                {
                    return false;
                }
            }
            return true;
        }

        private void PäivitäOpiskelijatTextBlock()
        {
            txtStudentsList.Text = "";
            foreach (var opiskelija in opiskelijat)
            {
                txtStudentsList.Text += $"{opiskelija.Etunimi} {opiskelija.Sukunimi}, ID: {opiskelija.OpiskelijaID}, Email: {opiskelija.Sähköposti}, Phone: {opiskelija.Puhelinnumero}\n";
            }
        }

        private void TyhjennäTekstikentät()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtStudentID.Text = "";
            txtEmail.Text = "";
            txtPhoneNumber.Text = "";
        }

        private void TallennaTiedostoon<T>(T data, string tiedostonimi)
        {
            try
            {
                using (FileStream fs = new FileStream(tiedostonimi, FileMode.Create))
                {
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, data);
                }
                MessageBox.Show("Tiedot tallennettu onnistuneesti.", "Tiedoston Tallennus", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Virhe tiedoston tallentamisessa: {ex.Message}", "Virhe", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private T LataaTiedostosta<T>(string tiedostonimi)
        {
            try
            {
                using (FileStream fs = new FileStream(tiedostonimi, FileMode.Open))
                {
                    IFormatter formatter = new BinaryFormatter();
                    return (T)formatter.Deserialize(fs);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Virhe tiedoston lataamisessa: {ex.Message}", "Virhe", MessageBoxButton.OK, MessageBoxImage.Error);
                return default(T);
            }
        }
    }
}
