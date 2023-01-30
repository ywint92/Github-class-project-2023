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


         txtsubtractnum3.Text = addplus.ToString();
            

        }

        private void buttonAdd2_Click(object sender, RoutedEventArgs e)
        {

            string subtractAdd1 = txtsubtractnum1.Text;
            string subtractAdd2 = txtsubtractnum2.Text;
            //Display SubtractAddAdd 1 AND SubtractAddAdd 2 to your 3rd txt box
            // Subtract 2 numbers and display the result
            // Convert the string to number
            // make a place to save a number, and then convert the number

            //Parse is how you convert a string to a number
            int num2 = int.Parse(subtractAdd1); // 1
            int num1 = int.Parse(subtractAdd2); // 2
            int addsubtract = num1 - num2;
            lblsubtractAdd.Content = "-";

            txtsubtractnum3.Text = addsubtract.ToString();
                                                
        }

        private void buttonSubtract1_Click(object sender, RoutedEventArgs e)
        {

            string multiplyAdd1 = txtMultiplydivide1.Text;
            string multiplyAdd2 = txtMutilplydivide2.Text;
            //Display MultiplyAddAdd 1 AND  MultiplyAddAdd 2 to your 3rd txt box 
            // Multiply 2 numbers and display the result
            // Convert the string to number
            // make a place to save a number, and then convert the number

            //Parse is how you convert a string to a number
            int num1 = int.Parse(multiplyAdd1); // 5
            int num2 = int.Parse(multiplyAdd2); // 4
            int multiplyadd = num1 * num2;
            lblmultiplyAdd.Content = "*";


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string divideAdd1 = txtMultiplydivide1.Text;
            string divideAdd2 = txtMutilplydivide2.Text;
            // Display DivideAddAdd 1 AND DivideAddAdd 2 to your 3rd txt box
            // Divide 2 numbers and display the results 
            // Convert the string to number
            //  make a place to save a number, and then convert the number

            // Parse is how you convert a string to a number
            int num1 = int.Parse(divideAdd1); // 1
            int num2 = int.Parse(divideAdd2); // 2
            int divideAdd = num1 / num2;
            lbldivideAdd.Content = "/";

        }
    }
}
