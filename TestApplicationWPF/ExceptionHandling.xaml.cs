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
using System.Windows.Shapes;

namespace TestApplicationWPF
{
    /// <summary>
    /// Interaction logic for ExceptionHandling.xaml
    /// </summary>
    public partial class ExceptionHandling : Window
    {
        public ExceptionHandling()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string s = null;
            try
            {
                s.Trim();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Exception occur " + ex.Message, "Simple Exception", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }
    }
}
