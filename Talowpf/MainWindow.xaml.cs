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

namespace Talowpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private float lampotila = 21;
        private bool keittoValot;
        private bool olohuoneenValot;
        private bool oviLukossa;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            keittoValot = !keittoValot;
            keittioValotCheckbox.IsChecked = keittoValot;
            /*if (keittoValot) 
            {
            keittioValotCheckbox.IsChecked = true;
                
            }
            else 
            {
            keittioValotCheckbox.IsChecked = false;
            }*/
        }

 

        private void olohuone(object sender, RoutedEventArgs e)
        {
            olohuoneenValot = !olohuoneenValot;
            olohuoneenValotCheckbox.IsChecked = olohuoneenValot;
        }

        private void lampotilaSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lampotila =(float)lampotilaSlider.Value;

            lampotilaText.Text = lampotila.ToString();

            
        }

        private void keittioValotCheckbox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void lukitseovi(object sender, RoutedEventArgs e)
        {
           
            oviLukossa = !oviLukossa;
            lukitseoviCheckbox.IsChecked= oviLukossa;
        }
    }   

}
