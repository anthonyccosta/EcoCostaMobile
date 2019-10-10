using EcoCostaMobile.ClassesCOD;
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
	public partial class newUSer : ContentPage
	{
        protected novoUSER usuario = new novoUSER();
		public newUSer ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
		}

        private void Buttonfinalizar_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Nomeusuario.Text)  ||
                string.IsNullOrEmpty(senhaUsuario.Text) ||
                string.IsNullOrEmpty(confirmarsenhaUsuario.Text) ||
                string.IsNullOrEmpty(emailUsuario.Text))
            {
                DisplayAlert("Erro", "Atenção! Não deixe os camps em branco", "OK");
            }
            else
            {
                bool resultadoInsert = usuario.Inserir(Nomeusuario.Text, senhaUsuario.Text, confirmarsenhaUsuario.Text, emailUsuario.Text);
                if (resultadoInsert == true)
                {
                    DisplayAlert("SUCESSO", "Usuario Cadastrado com Sucesso", "OK");
                    Nomeusuario.Text = "";
                    senhaUsuario.Text = "";
                    confirmarsenhaUsuario.Text = "";
                    emailUsuario.Text = "";

                    Navigation.PushAsync(new MainPage());
                }
                else
                {
                    DisplayAlert("Ops", "Houve um erro", "OK");
                }
            }
        }
    }
}