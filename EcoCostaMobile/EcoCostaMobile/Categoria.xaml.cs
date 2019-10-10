using EcoCostaMobile.ClassesCOD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoCostaMobile.Listagens;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EcoCostaMobile
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Categoria : ContentPage
	{
        protected categoriA usuario = new categoriA();
        public Categoria ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void ButtonListar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListarCategoria());
        }

        private void Buttoncadastrarcategoria_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(categoria.Text))
            {
                DisplayAlert("Erro", "Atenção! Não deixe os campos em branco", "OK");
            }
            else
            {
                bool resultadoInsert = usuario.InserirCategoria(categoria.Text);
                if (resultadoInsert == true)
                {
                    DisplayAlert("SUCESSO", "Categoria Cadastrada com Sucesso", "OK");
                    categoria.Text = "";
                }
                else
                {
                    DisplayAlert("Ops", "Houve um erro", "OK");
                }
            }
        }

        private void Buttonatualizarcategoria_Clicked(object sender, EventArgs e)
        {

        }
    }
}