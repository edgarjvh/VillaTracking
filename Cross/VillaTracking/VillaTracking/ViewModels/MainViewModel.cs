using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.Windows.Input;
using VillaTracking.Services;

namespace VillaTracking.ViewModels
{
    class MainViewModel
    {
        NavigationService navigationService;

        public MainViewModel()
        {
            navigationService = new NavigationService();
            LoadMenu();
        }

        #region Properties
        public ObservableCollection<MenuItemViewModel> Menu { get; set; }
        #endregion

        #region Commands        

        public ICommand GoToCommand
        {
            get { return new RelayCommand<string>(GoTo); }
        }
        #endregion

        #region Methods
               
        private void GoTo(string pageName)
        {
            navigationService.Navigate(pageName);
        }


        private void LoadMenu()
        {
            Menu = new ObservableCollection<MenuItemViewModel>
            {
                new MenuItemViewModel()
                {
                    Icon = "menu_icon_home.png",
                    Title = "Inicio",
                    PageName = "MainPage"
                }
                
            };

        }

        #endregion
    }
}
