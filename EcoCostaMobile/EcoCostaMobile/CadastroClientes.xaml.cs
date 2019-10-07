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
	public partial class CadastroClientes : ContentPage
	{
		public CadastroClientes ()
		{
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            
        }

        private void ButtoncadastrarCliente_Clicked(object sender, EventArgs e)
        {

        }

        private void Buttonatualizarcliente_Clicked(object sender, EventArgs e)
        {

        }

        private void Buttondeletarcliente_Clicked(object sender, EventArgs e)
        {

        }

        private void ButtonListar_Clicked(object sender, EventArgs e)
        {

        }

        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            labeldata.Text = "";
        }
    }
}