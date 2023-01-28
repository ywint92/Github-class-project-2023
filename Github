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

            //  create an array "ints
            int[] grade = new int[5];


            // creat an array "intialized"
            string[] name = { "Tyler", "Will", "John", "Ty", "kira" };
            int sum = 0;
            // intialize a variable; condition; incrementer
            // true / false
            int numofElements = name.Length;
            //comparison Operator
            // start, end, change
            for(int i = 0; i < numofElements; i++)
            {

                Console.WriteLine($"{name[i]} - " );
                // int.Parse(string to convert)
                string usersInput = Console.ReadLine();
                grade[i] = int.Parse(usersInput);
            }
            for (int i = 0; i < name.Length; i++)
            {

                Console.WriteLine($"{name[i]} - {grade[i]}");
                sum = sum + grade[i];
            }




        }
    }
}

