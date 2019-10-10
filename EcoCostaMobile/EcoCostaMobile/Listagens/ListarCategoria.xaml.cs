using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using EcoCostaMobile.ClassesCOD;
using EcoCostaMobile.Models;

namespace EcoCostaMobile.Listagens
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListarCategoria : ContentPage
	{
        protected categoriA users = new categoriA();
        public ListarCategoria ()
		{
			InitializeComponent ();
            CarregarInformacoes();
		}

        public void CarregarInformacoes()
        {
            var lista = users.SelectAll();
            listviewCategorias.ItemsSource = lista;
        }

        private void MenuatualizarUnicaCategoria_Clicked(object sender, EventArgs e)
        {

        }

        private async void MenudeletarUnicaCategoria_Clicked(object sender, EventArgs e)
        {
            var resposta = await DisplayAlert("Confirmação", "Tem certeza de que deseja deletar esta Categoria?", "SIM", "NÃO");
            if (resposta == true)
            {
                try
                {
                    var mi = (MenuItem)sender;
                    var model = (CategoriA)mi.CommandParameter;
                    var resultadoDeleteItemCategoria = users.DeleteItemCategoria(model.ID);
                    if (resultadoDeleteItemCategoria == true)
                        await DisplayAlert("Sucesso", "Item Deletado", "OK");
                    else
                        await DisplayAlert("ERRO", "Houve um Erro", "OK");
                }
                catch (Exception ex)
                {
                    await DisplayAlert("ERRO", ex.Message, "OK");
                }
            }
            CarregarInformacoes();
        }

        private void ButtonaddCategoria_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Categoria());
        }

        private async void ButtondeletartodaCategoria_Clicked(object sender, EventArgs e)
        {
            var resposta = await DisplayAlert("Confirmação", "Tem certeza de que deseja deletar tudo?", "SIM", "NÃO");
            if (resposta == true)
            {
                try
                {
                    var DeletartodasCategorias = users.DeletartodasCategorias();

                    if (DeletartodasCategorias == true)
                    {
                        await DisplayAlert("Sucesso", "Deletado", "OK");
                    }
                    else
                    {
                        await DisplayAlert("ERRO", "Houve um Erro", "OK");
                    }
                }
                catch (Exception ex)
                {
                    await DisplayAlert("ERRO", ex.Message, "OK");
                }
            }
            CarregarInformacoes();
        }
    }
}