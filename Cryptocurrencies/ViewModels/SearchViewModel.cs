using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Cryptocurrencies.Helpers;
using Cryptocurrencies.Models;
using Cryptocurrencies.Services;

namespace Cryptocurrencies.ViewModels
{
    public class SearchViewModel : BaseViewModel
    {
        private readonly DataService _dataService;
        private ObservableCollection<Cryptocurrency> _searchResults;
        private string _searchText;

        public SearchViewModel()
        {
            _dataService = new DataService();
            SearchCommand = new RelayCommand(async _ => await Search());
        }

        public ObservableCollection<Cryptocurrency> SearchResults
        {
            get => _searchResults;
            set
            {
                _searchResults = value;
                OnPropertyChanged();
            }
        }

        public string SearchText
        {
            get => _searchText;
            set
            {
                _searchText = value;
                OnPropertyChanged();
            }
        }

        public RelayCommand SearchCommand { get; }

        private async Task Search()
        {
            var allCryptocurrencies = await _dataService.GetTopCryptocurrenciesAsync();
            var filtered = allCryptocurrencies.Where(c => c.Name.Contains(SearchText));
            SearchResults = new ObservableCollection<Cryptocurrency>(filtered);
        }
    }
}
