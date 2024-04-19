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

namespace ProjectFlag
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

        private void ItalyButton_Click(object sender, RoutedEventArgs e)
        {
            this.LeftPart.Fill = new SolidColorBrush(Colors.Green);
            this.CenterPart.Fill = new SolidColorBrush(Colors.White);
            this.RightPart.Fill = new SolidColorBrush(Colors.Red);
        }

        private void FranceButton_Click(object sender, RoutedEventArgs e)
        {
            this.LeftPart.Fill = new SolidColorBrush(Colors.Blue);
            this.CenterPart.Fill = new SolidColorBrush(Colors.White);
            this.RightPart.Fill = new SolidColorBrush(Colors.Red);
        }

        private void RomaniaButton_Click(object sender, RoutedEventArgs e)
        {
            this.LeftPart.Fill = new SolidColorBrush(Colors.Blue);
            this.CenterPart.Fill = new SolidColorBrush(Colors.Yellow);
            this.RightPart.Fill = new SolidColorBrush(Colors.Red);
        }
    }
}
