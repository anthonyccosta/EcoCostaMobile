using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EcoCostaMobile
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Sobre : ContentPage
	{
		public Sobre ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void Buttonsitesenac_Clicked(object sender, EventArgs e)
        {
            string url = "https://www.sp.senac.br/botucatu";

            ////Escolher Navegador
            //Device.OpenUri(new Uri(url));

            var navegador = new WebView();
            navegador.Source = url;

            NavigationPage.SetHasNavigationBar(this, false); //não mostrar o menu
            Content = navegador;
        }

        private void Buttonecocosta_Clicked(object sender, EventArgs e)
        {
            string url = "";

            ////Escolher Navegador
            //Device.OpenUri(new Uri(url));

            var navegador = new WebView();
            navegador.Source = url;

            NavigationPage.SetHasNavigationBar(this, false); //não mostrar o menu
            Content = navegador;
        }
    }
}