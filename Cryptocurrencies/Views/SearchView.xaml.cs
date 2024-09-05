using System.Windows;
using System.Windows.Controls;

namespace Cryptocurrencies.Views
{
    public partial class SearchView : Window
    {
        public SearchView()
        {
            InitializeComponent();
            SearchTextBox.Text = "Enter cryptocurrency name";
            SearchTextBox.Foreground = System.Windows.Media.Brushes.Gray;
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (SearchTextBox.Text == "Enter cryptocurrency name")
            {
                SearchTextBox.Text = "";
                SearchTextBox.Foreground = System.Windows.Media.Brushes.Black;
            }
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SearchTextBox.Text))
            {
                SearchTextBox.Text = "Enter cryptocurrency name";
                SearchTextBox.Foreground = System.Windows.Media.Brushes.Gray;
            }
        }

        private void BackToMainWindow(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close(); 
        }
    }
}
