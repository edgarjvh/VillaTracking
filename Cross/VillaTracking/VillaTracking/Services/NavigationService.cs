using Xamarin.Forms;
using System.Threading.Tasks;
using VillaTracking.Pages;

namespace VillaTracking.Services
{
    class NavigationService
    {
        public async void Navigate(string pageName)
        {
            App.Master.IsPresented = false;

            switch (pageName)
            {
                case "pageLogin":
                    await App.Navigator.PopToRootAsync();
                    break;
                case "pageMain":
                    await Navigate(new pageMain());
                    break;
                default:
                    break;
            }
        }

        private static async Task Navigate<T>(T page) where T : Page
        {
            NavigationPage.SetHasBackButton(page, false);
            NavigationPage.SetBackButtonTitle(page, "Atras"); //iOS


            await App.Navigator.PushAsync(page);
        }
    }
}
