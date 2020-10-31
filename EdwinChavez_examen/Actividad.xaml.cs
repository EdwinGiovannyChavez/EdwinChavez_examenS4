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
    public partial class Actividad : ContentPage
    {
        int mon = 1800;
        public Actividad()
        {
            
        }

        public Actividad(string name, string mon, string men)
             
        {
            InitializeComponent();
            string nombre = txtNombre.Text;
            txtNombre.Text = nombre + name;

            string monto = txtMonto.Text;
            txtMonto.Text = monto + mon;

            string mensual = txtMensual.Text;
            txtMensual.Text = mensual + men;
        }
    }
}