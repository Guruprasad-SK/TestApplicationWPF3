using Microsoft.Win32;
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

namespace TestApplicationWPF
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
        private void AllCheck_Checked(object sender, RoutedEventArgs e)
        {
            bool allState = (AllCheck.IsChecked == true);
            {
                first.IsChecked = allState;
                secondd.IsChecked = allState;
                third.IsChecked = allState;
            }
        }
        private void first_Checked(object sender, RoutedEventArgs e)
        {
            AllCheck.IsChecked = true;
            if ((first.IsChecked == true) && (secondd.IsChecked == true) && (third.IsChecked == true))
                AllCheck.IsChecked = true;
            if ((first.IsChecked == false) && (secondd.IsChecked == false) && (third.IsChecked == false))
                AllCheck.IsChecked = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog= new OpenFileDialog();    
            if(dialog.ShowDialog()==true)
            {
                Uri uri = new Uri(dialog.FileName);
                Img1.Source=new BitmapImage(uri);
            }
        }
    }
}