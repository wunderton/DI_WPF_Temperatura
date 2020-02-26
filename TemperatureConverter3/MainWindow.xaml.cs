using System;
using System.Collections.Generic;
using System.Linq;
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

namespace TemperatureConverter3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Declare the varibles.
        private double inputTemp;
        private double celTemp;
        private double farenTemp;
        int choice1;
        int choice2;

        public MainWindow()
        {
            InitializeComponent();
        }
   
         private void convertButton_Click(object sender, RoutedEventArgs e)
         {
             // To do...
             // Get the first temp that the user wants to convert.
             try
             {
                 inputTemp = double.Parse(inputBox.Text);

                 // Need to start a switch for the 3 choices.
                 int get1 = getChoice1();
                 int get2 = getChoice2();


                 switch (get1)
                 {
                     case 1:
                         if (get2 == 1)
                         {
                             resultBox.Text = celToCel(inputTemp).ToString() + "°C";
                         }
                         else if (get2 == 2)
                         {
                             resultBox.Text = celToFaren(inputTemp).ToString() + "°F";
                         }

                         break;

                     case 2:
                        if (get2 == 1)
                        {
                            resultBox.Text = farenToCel(inputTemp).ToString() + "°C";
                        }
                        else if (get2 == 2)
                        {
                            resultBox.Text = farenToFaren(inputTemp).ToString() + "°F";
                        }
                         break;

                     default:
                         resultBox.Text = "Imposible convertir.";
                         break;
                 }
             }
             catch (FormatException fEx)
             {
                 resultBox.Text = fEx.Message;
             }
         }

         public int getChoice1()
         {
             if (fromCelButton.IsChecked == true)
             {
                 choice1 = 1;
             }
             else if (fromFarenButton.IsChecked == true)
             {
                 choice1 = 2;
             }

             return choice1;
        }

         public int getChoice2()
         {
             if (toCelButton.IsChecked == true)
             {
                 choice2 = 1;
             }
             else if (toFarenButton.IsChecked == true)
             {
                 choice2 = 2;
             }
             return choice2;
         }

        public double celToCel(double firstTemp)
        {
            // To do..
            return firstTemp;
        }

        public double celToFaren(double firstTemp)
        {
            inputTemp = firstTemp;
            farenTemp = (inputTemp * 1.8) + 32;
            return farenTemp;
        }

 
        public double farenToCel(double firstTemp)
        {
            inputTemp = firstTemp;
            celTemp = (inputTemp - 32) * 5 / 9;
            return celTemp;
        }

        public double farenToFaren(double firstTemp)
        {
            return firstTemp;
        }
    }
}
