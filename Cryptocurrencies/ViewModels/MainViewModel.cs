using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Cryptocurrencies.Helpers;
using Cryptocurrencies.Models;
using Cryptocurrencies.Services;

namespace Cryptocurrencies.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private readonly DataService _dataService;
        private ObservableCollection<Cryptocurrency> _cryptocurrencies;

        public MainViewModel()
        {
            _dataService = new DataService();
            LoadDataCommand = new RelayCommand(async _ => await LoadData());
        }

        public ObservableCollection<Cryptocurrency> Cryptocurrencies
        {
            get => _cryptocurrencies;
            set
            {
                _cryptocurrencies = value;
                OnPropertyChanged();
            }
        }

        public RelayCommand LoadDataCommand { get; }

        private async Task LoadData()
        {
            var cryptocurrencies = await _dataService.GetTopCryptocurrenciesAsync();
            Cryptocurrencies = new ObservableCollection<Cryptocurrency>(cryptocurrencies);
        }
    }
}
