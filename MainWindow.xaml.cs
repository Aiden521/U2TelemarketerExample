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

namespace U2_01_J1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, RoutedEventArgs e)
        {
            // get four digits from input
            // arrays allow you to store more than one
            // value in the array
            int[] digits = new int[4]; // array
            //isTelemarketer
            bool isTelemarketer = false; // assume it is not

            for(int i = 0; i < 4; i++)
            {
                int.TryParse(txtInput.Text.Substring(i * 3, 1), out digits[i]);
                Console.WriteLine(digits[i]); // Troubleshooting
            }
            // check property 1
            if (digits[0] == 8 || digits[0] == 9)
            {
                Console.WriteLine("First digits is 8 or 9"); // Troubleshooting
                // check property 2
                if (digits[3] == 8 || digits[3] == 9)
                {
                    Console.WriteLine("Last digit is an 8 or 9");
                    // check property 3
                    if (digits[1] == digits[2])
                    {
                        Console.WriteLine("2nd and 3rd digits are the same");
                        // must be a telemarketer
                        isTelemarketer = true;
                    }

                }
            }
            if (isTelemarketer)
            {
                lblOutput.Content = "ignore";
            }
            else
            {
                lblOutput.Content = "answer";
            }
        }
    }
}
