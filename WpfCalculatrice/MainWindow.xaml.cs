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

namespace WpfCalculatrice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Addition addition;
        public MainWindow()
        {
            //constructeur de la clase
            InitializeComponent();
            addition = new Addition(0,0);
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            double dblNumber1;
            double dblNumber2;

            if(double.TryParse(tbxNombre1.Text,out dblNumber1))
            {
                if (double.TryParse(tbxNombre2.Text, out dblNumber2))
                {
                    addition.setVal1(dblNumber1);
                    addition.setVal2(dblNumber2);
                    lblReponse.Content = addition.Additionne();
                }
                else
                {
                    MessageBox.Show("Veuillez controler le format des nombres saisis!","Conversion",MessageBoxButton.OK,MessageBoxImage.Warning);
                }
            }
        }

        private void btnSub_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMult_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDiv1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void tbxNombre1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
