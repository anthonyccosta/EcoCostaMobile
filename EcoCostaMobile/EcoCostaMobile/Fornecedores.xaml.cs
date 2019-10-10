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
	public partial class Fornecedores : ContentPage
	{
        protected FornecedorR fornecedor = new FornecedorR();
        public Fornecedores ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void Buttoncadastrarfornecedor_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nomefornecedor.Text) ||
                string.IsNullOrEmpty(CNPJ.Text) ||
                string.IsNullOrEmpty(datanascimento.Text) ||
                string.IsNullOrEmpty(sexo.Text) ||
                string.IsNullOrEmpty(TelefoneCelular.Text) ||
                string.IsNullOrEmpty(TelefoneResidencial.Text) ||
                string.IsNullOrEmpty(email.Text) ||
                string.IsNullOrEmpty(rua.Text) ||
                string.IsNullOrEmpty(numero.Text) ||
                string.IsNullOrEmpty(Bairro.Text) ||
                string.IsNullOrEmpty(CEP.Text) ||
                string.IsNullOrEmpty(Estado.Text))
            {
                DisplayAlert("Erro", "Atenção! Não deixe os campos em branco", "OK");
            }
            else
            {
                bool resultadoInsert = fornecedor.InserirFornecedor(nomefornecedor.Text, CNPJ.Text, datanascimento.Text, sexo.Text, TelefoneCelular.Text, TelefoneResidencial.Text, email.Text, rua.Text, numero.Text, Bairro.Text, CEP.Text, Estado.Text);
                if (resultadoInsert == true)
                {
                    DisplayAlert("SUCESSO", "Fornecedor Cadastrado com Sucesso", "OK");
                    nomefornecedor.Text = "";
                    CNPJ.Text = "";
                    datanascimento.Text = "";
                    sexo.Text = "";
                    TelefoneCelular.Text = "";
                    TelefoneResidencial.Text = "";
                    email.Text = "";
                    rua.Text = "";
                    numero.Text = "";
                    Bairro.Text = "";
                    CEP.Text = "";
                    Estado.Text = "";
                }
                else
                {
                    DisplayAlert("Ops", "Houve um erro", "OK");
                }
            }
        }

        private void Buttonatualizarfornecedor_Clicked(object sender, EventArgs e)
        {

        }

        private void ButtonListar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Listarfornecedores());
        }
    }
}