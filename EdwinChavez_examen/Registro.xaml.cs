using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EdwinChavez_examen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro()
        {
            InitializeComponent();
        }

        public Registro(string user, string pass)
        {
            InitializeComponent();

            string usuario = lblUser.Text;
            lblUser.Text = usuario + user;


        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {

            string name = txtNombre.Text;
            string mon = txtMonto.Text;
            string men = txtMensual.Text;

            double dato1 = Convert.ToDouble(txtMonto.Text);
            double suma = (dato1 / 3);
            double suma1 = suma * 0.05;
            double suma2 = suma + suma1;
            txtMensual.Text = suma2.ToString();


            await Navigation.PushAsync(new Actividad(name, mon, men));
        }
    }

}