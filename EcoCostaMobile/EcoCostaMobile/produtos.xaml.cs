using EcoCostaMobile.ClassesCOD;
using EcoCostaMobile.Listagens;
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
	public partial class produtos : ContentPage
	{
        protected ProdutosS produtosS = new ProdutosS();
		public produtos ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void ButtonListar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListarProdutos());
        }

        private void Buttonfinalizar_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(escolherprodutos.Text) ||
                string.IsNullOrEmpty(categoriaproduto.Text) ||
                string.IsNullOrEmpty(descricaoproduto.Text) ||
                string.IsNullOrEmpty(quantidadeproduto.Text) ||
                string.IsNullOrEmpty(fornecedor.Text) ||
                string.IsNullOrEmpty(quantidadeunicaproduto.Text) ||
                string.IsNullOrEmpty(quantidadebrutaprodutos.Text))
            {
                DisplayAlert("Erro", "Não deixe os campos em branco", "OK");
            }
            else
            {
                bool resultadocadastro = produtosS.Inserir(escolherprodutos.Text, categoriaproduto.Text, descricaoproduto.Text, quantidadeproduto.Text, fornecedor.Text, quantidadeunicaproduto.Text,
                                                          quantidadebrutaprodutos.Text);
                if (resultadocadastro == true)
                {
                    DisplayAlert("SUCESSO", "Clientes Cadastrado com Sucesso", "OK");
                    escolherprodutos.Text = "";
                    categoriaproduto.Text = "";
                    descricaoproduto.Text = "";
                    quantidadeproduto.Text = "";
                    fornecedor.Text = "";
                    quantidadeunicaproduto.Text = "";
                    quantidadebrutaprodutos.Text = "";

                    DisplayAlert("Atenção", "Para verificar se o clientes foi cadastrado com sucesso, vá até a tela de listagem.", "OK");
                }
                else
                {
                    DisplayAlert("ERRO", "Houve um erro", "OK");
                }
            }           
        }
    }
}