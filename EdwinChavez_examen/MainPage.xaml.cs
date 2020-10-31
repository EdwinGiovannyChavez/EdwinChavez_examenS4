using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EdwinChavez_examen
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnRegistro_Clicked(object sender, EventArgs e)
        {
            string user = txtUsers.Text;
            string pass = txtPassword.Text;
            if (txtUsers.Text == "estudiante2020" && txtPassword.Text == "uisrael2020")
            {
                await Navigation.PushAsync(new Registro(user, pass));
                DisplayAlert("Acceso", txtUsers.Text, "Salir");
            }
            else
            {
                DisplayAlert("Usuario o Contraseña incorrectas", txtPassword.Text, "Salir");
            }

        }
    }
}
