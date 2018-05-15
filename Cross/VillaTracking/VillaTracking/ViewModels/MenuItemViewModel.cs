using GalaSoft.MvvmLight.Command;
using System.Windows.Input;
using VillaTracking.Services;

namespace VillaTracking.ViewModels
{
    class MenuItemViewModel
    {
        NavigationService navigationService;

        public MenuItemViewModel()
        {
            navigationService = new NavigationService();
        }

        public string Icon { get; set; }
        public string Title { get; set; }
        public string PageName { get; set; }
        public ICommand NavigateCommand
        {
            get { return new RelayCommand(() => navigationService.Navigate(PageName)); }
        }
    }
}
