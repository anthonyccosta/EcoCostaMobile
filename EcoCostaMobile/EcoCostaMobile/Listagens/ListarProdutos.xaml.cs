using EcoCostaMobile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoCostaMobile.ClassesCOD;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EcoCostaMobile.Listagens
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListarProdutos : ContentPage
	{
        protected ProdutosS produtoss = new ProdutosS();
		public ListarProdutos ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
            CarregarInformacoes();
		}

        public void CarregarInformacoes()
        {
            var lista = produtoss.SelectAll();
            listviewProduto.ItemsSource = lista;
        }

        private void MenuItemAtualizarProduto_Clicked(object sender, EventArgs e)
        {

        }

        private async void MenuItemDeletarrProduto_Clicked(object sender, EventArgs e)
        {
            var resposta = await DisplayAlert("Confirmação", "Tem certeza de que deseja deletar este Produto?", "SIM", "NÃO");
            if (resposta == true)
            {
                try
                {
                    var mi = (MenuItem)sender;
                    var model = (Produtos)mi.CommandParameter;
                    var resultadoDeletaItem = produtoss.DeleteItem(model.ID);
                    if (resultadoDeletaItem == true)
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

        private void ButtonaddProduto_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new produtos());
        }

        private async void ButtondeletartudoProduto_Clicked(object sender, EventArgs e)
        {
            var resposta = await DisplayAlert("Confirmação", "Tem certeza de que deseja deletar tudo?", "SIM", "NÃO");
            if (resposta == true)
            {
                try
                {
                    var mi = (MenuItem)sender;
                    var model = (Produtos)mi.CommandParameter;
                    var resultadoDeletaItem = produtoss.DeleteAll();
                    if (resultadoDeletaItem == true)
                        await DisplayAlert("Sucesso", "Deletado", "OK");
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
    }
}