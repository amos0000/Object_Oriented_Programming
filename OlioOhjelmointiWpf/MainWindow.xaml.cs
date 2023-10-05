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
using System.Xml;

namespace OlioOhjelmointiWpf
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender,
            RoutedEventArgs e)
        {
            Car myCar1 = new Car();
            Car myCar2 = new Car();

            int maxSpeed = int.Parse(maxSpeedTextBox.Text);

            myCar1.Color = carColorTextBox.Text;
            myCar1.MaxSpeed = maxSpeed;

            myCar1.Model = carModelTextBox.Text;

            myCar1.Make = carMakeTextBox.Text;

                        
            myCar1.StartEngine();
            ShowCarInfo(myCar1);

            MessageBox.Show("Auton tiedot asetettu käyttäjän antaman syötteen perusteella.");

            myCar2.Color = "Punainen";
            myCar2.MaxSpeed = 300;             
   
            myCar2.SetMaxSpeed(116);
            
            myCar2.Model = "Corvette";
            myCar2.Make = "Chervolet";
                        
            myCar2.StartEngine();
            ShowCarInfo(myCar2);

            MessageBox.Show("Auton tiedot asetettu metodin kautta.");
        }

        public void ShowCarInfo(Car c)
        {
            string message = "Merkki: " + c.Make + "\r\n" + "Malli: " + c.Model + "\r\n" +
                "Väri: " + c.Color + "\r\n" +
                "Huippunopeus: " + c.MaxSpeed;
            
            MessageBox.Show(message);
        }

        
    }
}
