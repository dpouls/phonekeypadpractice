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

namespace PhoneKeyPadGame
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

        private void BtnNumber_Click(object sender, RoutedEventArgs e)
        {
            Button selectedBtn = (Button)sender; 
            if (LblResults.Content.ToString().Length >= 10)
            {
                LblResults.Content = selectedBtn.Content;
            }
            else
            {
                LblResults.Content += selectedBtn.Content.ToString();
            }
        }
    }
}
