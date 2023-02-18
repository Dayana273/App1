using App1.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PagePrincipal : ContentPage
    {
        public PagePrincipal()
        {
            InitializeComponent();
        }

        private void btprocesar_Clicked(object sender, EventArgs e)
        {
            var emple = new Empleado
            {
                id = 1,
                nombres = txtnombre.Text,
                apeliidos = txtApellido.Text,
                foto = null
            };
            //esto es para llamar una segunda pagina y pasar un parametro a una segunda pantalla//
            var seconpage = new PageResultado();
            seconpage.BindingContext = emple; //paso de parametros a la pantalla
            Navigation.PushAsync(seconpage);
        }
    }
}