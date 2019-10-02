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
            else if (entrylogin.Text == "adm" && entrysenha.Text == "adm")
            {
                Navigation.PushAsync(new Menu());
            }
        }
    }
}
