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
    public partial class ListClientes : ContentPage
    {
        protected Clientes cadastrocliente = new Clientes();
        public ListClientes()
        {
            InitializeComponent();
            CarregarInformacoes();
        }

        private void CarregarInformacoes()
        {
            var lista = cadastrocliente.SelectAll();
            listviewClientes.ItemsSource = lista;
        }

        private void MenuItemAtualizar_Clicked(object sender, EventArgs e)
        {
            //var mi = (MenuItem)sender;
            //var model = (Clientes)mi.CommandParameter;

            //bool resultadoUpdate = Clientes.Update(model.ID);
            //if (resultadoUpdate == true)
            //    DisplayAlert("SUCESSO", "Atualizado", "OK");
            //else
            //    DisplayAlert("ERRO", "Nâo foi possivel a atualização", "OK");
            //CarregarInformacoes();
        }

        private async void MenuItemDeletar_Clicked(object sender, EventArgs e)
        {
            var resposta = await DisplayAlert("Confirmação", "Tem certeza de que deseja deletar este Cliente?", "SIM", "NÃO");
            if (resposta == true)
            {
                try
                {
                    var mi = (MenuItem)sender;
                    var model = (clientes)mi.CommandParameter;
                    var resultadoDeletaItem = cadastrocliente.DeleteItem(model.ID);
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

        private void ButtonAdicionar_Clicked(object sender, EventArgs e)
        {
            
        }

        private async void ButtonApagartudo_Clicked(object sender, EventArgs e)
        {
            var respostaConfirmacao = await DisplayAlert("Confirmação", "Tem certeza que deseja deletar tudo?", "SIM", "NÂO");
            if (respostaConfirmacao == true)
            {
                try
                {
                    var resultadoDeleteAll = cadastrocliente.DeleteAll();
                    if (resultadoDeleteAll == true)
                        await DisplayAlert("Sucesso", "Deletado", "OK");
                    else
                        await DisplayAlert("ERRo", "Houve um erro", "OK");
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