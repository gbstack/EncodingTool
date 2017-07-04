using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

namespace EncodingTool
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

        private void encodeButton_Click(object sender, RoutedEventArgs e)
        {
            outputTextBox.Text = WebUtility.HtmlEncode(originalTextTextBox.Text);
        }

        private void decodeButton_Click(object sender, RoutedEventArgs e)
        {
            outputTextBox.Text = WebUtility.HtmlDecode(originalTextTextBox.Text);
        }
    }
}
