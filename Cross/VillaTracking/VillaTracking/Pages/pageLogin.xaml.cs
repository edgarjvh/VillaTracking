using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;
using VillaTracking.Models;
using VillaTracking.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VillaTracking.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class pageLogin : ContentPage
	{

        NavigationService navigationService;

		public pageLogin ()
		{
			InitializeComponent ();
            navigationService = new NavigationService();
            btnAccess.Clicked += BtnAccess_Clicked;
		}

        private async void BtnAccess_Clicked(object sender, EventArgs e)
        {
            try
            {
                var username = txtUsername.Text;
                var password = txtPassword.Text;

                if (string.IsNullOrEmpty(username))
                {
                    await DisplayAlert("Mensaje", "Debe insertar el nombre de usuario", "Aceptar");
                    return;
                }

                if (string.IsNullOrEmpty(password))
                {
                    await DisplayAlert("Mensaje", "Debe insertar su contraseña", "Aceptar");
                    return;
                }

                aiLoading.IsRunning = true;
                txtUsername.IsEnabled = false;
                txtPassword.IsEnabled = false;
                btnAccess.IsEnabled = false;

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://webapi.villatracking.com");
                string url = string.Format("/api/user/{0}/{1}",username, password);
                var response = await client.GetAsync(url);

                var result = response.Content.ReadAsStringAsync().Result;
                string s = result.Replace(@"\", string.Empty);
                string final = s.Trim().Substring(1, (s.Length) - 2);

                aiLoading.IsRunning = false;
                txtUsername.IsEnabled = true;
                txtPassword.IsEnabled = true;
                btnAccess.IsEnabled = true;

                switch (response.StatusCode)
                {                
                    case System.Net.HttpStatusCode.NoContent:
                        await DisplayAlert("Mensaje", "Usuario o contraseña incorrecta", "Aceptar");
                        break;
                    case System.Net.HttpStatusCode.OK:
                        var user = JsonConvert.DeserializeObject<User>(final);

                        await App.Navigator.PushAsync(new MasterPage());

                        break;
                    default:
                        await DisplayAlert("Mensaje", "Ocurrió un error, por favor vuelva a intentarlo", "Aceptar");
                        break;
                }
            }
            catch (Exception ex)
            {
                aiLoading.IsRunning = false;
                txtUsername.IsEnabled = true;
                txtPassword.IsEnabled = true;
                btnAccess.IsEnabled = true;
                await DisplayAlert("Error", ex.Message, "Aceptar");
            }
        }
    }
}