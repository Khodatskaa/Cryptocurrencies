using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Cryptocurrencies.Views
{
    public partial class SearchView : Window
    {
        public SearchView()
        {
            InitializeComponent();

            if (string.IsNullOrWhiteSpace(SearchTextBox.Text))
            {
                SearchTextBox.Text = "Enter cryptocurrency name";
                SearchTextBox.Foreground = Brushes.Gray;
            }
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox != null && textBox.Text == "Enter cryptocurrency name")
            {
                textBox.Text = string.Empty;
                textBox.Foreground = Brushes.Black;
            }
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox != null && string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Enter cryptocurrency name";
                textBox.Foreground = Brushes.Gray;
            }
        }
    }
}
