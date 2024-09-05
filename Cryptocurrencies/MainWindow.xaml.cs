using Cryptocurrencies.Views;
using System.Windows;

namespace Cryptocurrencies
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenSearchView(object sender, RoutedEventArgs e)
        {
            SearchView searchView = new SearchView();
            searchView.Show();
            this.Close();  
        }
    }
}
