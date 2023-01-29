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

namespace Github_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // This is a comment
            // I like your shirt
            // I like yours too
            
        }

        // string = words
        // int = whole numbers
        // double = decimal numbers ( floating point )
        // bool = ( true or false )

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            string addAddsubtract1 = txtAddSubtractnum1.Text; // "5"
            string addAddsubtract2 = txtAddsubtractnum2.Text;
            // Display AddAddsubtract 1 AND AddAddSubtract 2 to your 3rd txt box
            // Add 2 numbers and display the result
            // Convert the string to a number
            // make a place to save a number, and then convert the number

            // Parse is how you convert a string to a number
            int num1 = int.Parse(addAddsubtract1); // 5
            int num2 = int.Parse(addAddsubtract2); // 4
            int addplus = num1 + num2;
            lblAddSubtract.Content = "+";

            string multiplyDivide1 = txtMultiplydividenum1.Text;
            string multiplyDivide2 = txtMultiplydividenum2.Text;
            // Display multiplyDivivde 1 AND multiDivide 2 to your 3rd txt box
            // Multiply 2 numbers and display the result
            // Convert the string to a number
            // make a place to save a number, and then convert the number

            //Parse is how you convert a string to a number
            int num1 = int.Parse(multiplyDivide1); // 5
            int num2 = int.Parse(multiplyDivide2); // 4
            int multidivide = num1 * num2;
            lblMultiplyDivide.Content = "*";


            txtsubtractnum3.Text = addplus.ToString();
            txtmultiplynum3.Text = multidivide.ToString();

        }
    }
}
