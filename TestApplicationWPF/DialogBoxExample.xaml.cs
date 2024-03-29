﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for DialogBoxExample.xaml
    /// </summary>
    public partial class DialogBoxExample : Window
    {
        public DialogBoxExample()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text file (*.txt)| *.txt | c# file(*.cs) |*.cs";
            saveFileDialog.InitialDirectory=Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments );
            if(saveFileDialog.ShowDialog()==true )
            {
                File.WriteAllText(saveFileDialog.FileName, t1.Text);
            }
        }
    }
}
