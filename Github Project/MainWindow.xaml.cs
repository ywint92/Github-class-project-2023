﻿using System;
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

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            string addAddsubtract1 = txtAddSubtractnum1.Text;
            string addAddsubtract2 = txtAddsubtractnum2.Text;
            MessageBox.Show(addAddsubtract1);
        }
    }
}
