using EcoCostaMobile.ClassesCOD;
using EcoCostaMobile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EcoCostaMobile.Listagens
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Listarfornecedores : ContentPage
	{
        protected FornecedorR fornecedor = new FornecedorR();
        public Listarfornecedores ()
		{
			InitializeComponent ();
		}

        public void CarregarInformacoes()
        {
            var lista = fornecedor.SelectAll();
            listviewFornecedor.ItemsSource = lista;
        }

        private void MenuItemAtualizarFornecedor_Clicked(object sender, EventArgs e)
        {

        }

        private async void MenuItemDeletarFornecedor_Clicked(object sender, EventArgs e)
        {
            var resposta = await DisplayAlert("Confirmação", "Tem certeza de que deseja deletar este Fornecedor?", "SIM", "NÃO");
            if (resposta == true)
            {
                try
                {
                    var mi = (MenuItem)sender;
                    var model = (FornecedoreS)mi.CommandParameter;
                    var resultadoDeletaItemFornecedor = fornecedor.DeleteItemFornecedor(model.ID);
                    if (resultadoDeletaItemFornecedor == true)
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

        private void ButtonaddFornecedor_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Fornecedores());
        }

        private async void ButtondeletartudoFornecedor_Clicked(object sender, EventArgs e)
        {
            var resposta = await DisplayAlert("Confirmação", "Tem certeza de que deseja deletar tudo?", "SIM", "NÃO");
            if (resposta == true)
            {
                try
                {
                    var resultadoDeletaAll = fornecedor.DeleteAllFornecedores();

                    if (resultadoDeletaAll == true)
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