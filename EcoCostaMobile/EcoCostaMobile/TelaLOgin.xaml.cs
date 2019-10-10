using EcoCostaMobile.ClassesCOD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EcoCostaMobile
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void Buttonsemcadastro_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new newUSer());
        }

        private void Buttonlogin_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(entrylogin.Text) ||
                string.IsNullOrEmpty(entrysenha.Text))
            {
                DisplayAlert("Ops..", "Não deixe os campos em branco", "Ok");
            }
            else 
            {
                novoUSER user = new novoUSER();
                bool resultadologin = user.Login(entrylogin.Text, entrysenha.Text);

                if (resultadologin == true)
                {
                    Navigation.PushAsync(new Menu());
                }
                else
                {
                    DisplayAlert("Erro", "Usuario ou senha incorretos", "Tente Novamente");
                }
            }
        }
    }
}
