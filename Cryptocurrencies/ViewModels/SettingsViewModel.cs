namespace Cryptocurrencies.ViewModels
{
    public class SettingsViewModel : BaseViewModel
    {
        private bool _isDarkModeEnabled;

        public bool IsDarkModeEnabled
        {
            get => _isDarkModeEnabled;
            set
            {
                _isDarkModeEnabled = value;
                OnPropertyChanged();
            }
        }
    }
}