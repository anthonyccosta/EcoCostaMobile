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
	public partial class CadastroClientes : ContentPage
	{
        protected Clientes clientes = new Clientes();
		public CadastroClientes ()
		{
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            
        }

        private void ButtoncadastrarCliente_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nomecliente.Text) ||
                string.IsNullOrEmpty(CPF.Text) ||
                string.IsNullOrEmpty(RG.Text) ||
                string.IsNullOrEmpty(datanascimento.Text) ||
                string.IsNullOrEmpty(TelefoneCelular.Text) ||
                string.IsNullOrEmpty(TelefoneResidencial.Text) ||
                string.IsNullOrEmpty(Email.Text) ||
                string.IsNullOrEmpty(Rua.Text) ||
                string.IsNullOrEmpty(Numero.Text) ||
                string.IsNullOrEmpty(Bairro.Text) ||
                string.IsNullOrEmpty(CEP.Text))
            {
                DisplayAlert("Erro", "Não deixe os campos em Branco", "OK");
            }
            else
            {
                bool resultadocadastro = clientes.Inserir(nomecliente.Text, CPF.Text, RG.Text, datanascimento.Text, pickersexo, TelefoneCelular.Text,
                                                          TelefoneResidencial.Text, Email.Text, Rua.Text, Bairro.Text, Numero.Text, pickerUF, CEP.Text);
                if (resultadocadastro == true)
                {
                    DisplayAlert("SUCESSO", "Clientes Cadastrado com Sucesso", "OK");
                    nomecliente.Text = "";
                    CPF.Text = "";
                    RG.Text = "";
                    datanascimento.Text = "";
                    TelefoneCelular.Text = "";
                    TelefoneResidencial.Text = "";
                    Email.Text = "";
                    Rua.Text = "";
                    Numero.Text = "";
                    Bairro.Text = "";
                    CEP.Text = "";

                    DisplayAlert("Atenção", "Para verificar se o clientes foi cadastrado com sucesso, vá até a tela de listagem.", "OK");
                }
                else
                {
                    DisplayAlert("ERRO", "Houve um erro", "OK");
                }
            }
        }

        private void Buttonatualizarcliente_Clicked(object sender, EventArgs e)
        {

        }

        private void ButtonListar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListClientes());
        }
    }
}