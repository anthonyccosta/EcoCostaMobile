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
	public partial class ListarUsers : ContentPage
	{
        protected novoUSER users = new novoUSER();
        public ListarUsers ()
		{
			InitializeComponent ();
            CarregarInformacoes();
		}

        public void CarregarInformacoes()
        {
            var lista = users.SelectAll();
            listviewUsers.ItemsSource = lista;
        }

        private void MenuatualizarUnicoUser_Clicked(object sender, EventArgs e)
        {

        }

        private async void MenudeletarUnicoUser_Clicked(object sender, EventArgs e)
        {
            var resposta = await DisplayAlert("Confirmação", "Tem certeza de que deseja deletar este Usuario?", "SIM", "NÃO");
            if (resposta == true)
            {
                try
                {
                    var mi = (MenuItem)sender;
                    var model = (Usuarios)mi.CommandParameter;
                    var resultadoDeletaItemUser = users.DeleteItemUser(model.ID);
                    if (resultadoDeletaItemUser == true)
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

        private void ButtonaddUsuario_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new newUSer());
        }

        private async void ButtondeletartudoUsuarios_Clicked(object sender, EventArgs e)
        {
            var resposta = await DisplayAlert("Confirmação", "Tem certeza de que deseja deletar tudo?", "SIM", "NÃO");
            if (resposta == true)
            {
                try
                {
                    var DeleteAllUSers = users.DeleteAllUSers();

                    if (DeleteAllUSers == true)
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