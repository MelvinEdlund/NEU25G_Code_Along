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

namespace L044_Controls
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

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (button is null) return;
            button.IsEnabled = (textBox.Text.Length > 0);
            
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            textBox2.Text += textBox.Text +Environment.NewLine;
            textBox.Text = string.Empty;
        }
    }
}