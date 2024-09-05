using System.Collections.Generic;
using System.Threading.Tasks;
using Cryptocurrencies.Models;
using Cryptocurrencies.Services;
using OxyPlot;

namespace Cryptocurrencies.ViewModels
{
    public class DetailsViewModel : BaseViewModel
    {
        private readonly DataService _dataService;
        private Cryptocurrency _cryptocurrency;
        private List<Market> _markets;
        private PlotModel _priceChart;

        public DetailsViewModel()
        {
            _dataService = new DataService();
        }

        public Cryptocurrency Cryptocurrency
        {
            get => _cryptocurrency;
            set
            {
                _cryptocurrency = value;
                OnPropertyChanged();
            }
        }

        public List<Market> Markets
        {
            get => _markets;
            set
            {
                _markets = value;
                OnPropertyChanged();
            }
        }

        public PlotModel PriceChart
        {
            get => _priceChart;
            set
            {
                _priceChart = value;
                OnPropertyChanged();
            }
        }

        public async Task LoadCryptocurrencyDetails(string cryptoId)
        {
            Cryptocurrency = await _dataService.GetCryptocurrencyDetailsAsync(cryptoId);
            Markets = await _dataService.GetMarketsForCryptocurrencyAsync(cryptoId);
            PriceChart = ChartService.GeneratePriceChart(new List<Cryptocurrency> { Cryptocurrency });
        }
    }
}
