using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TareaSemana3JGuilcapi
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;

            //Condicion
            if (user == "estudiante2020" && pass == "uisrael2020")
            {
                await Navigation.PushAsync( new Pagina2(user, pass));
            }
            else
            {
                await DisplayAlert("Alerta", "Usuario incorrecto", "OK");
            }
        }
    }
}
