﻿using EcoCostaMobile.Listagens;
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
	public partial class Menu : MasterDetailPage
	{
		public Menu ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
            Detail = new NavigationPage(new telaprincipal());
        }

        private void Paginaclientes_Tapped(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new CadastroClientes());
            IsPresented = false;
        }

        private void Paginaprodutos_Tapped(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new produtos());
            IsPresented = false; //fechar o menu ao abrir a pagina desejada
        }

        private void Paginafornecedores_Tapped(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Fornecedores());
            IsPresented = false;
        }

        private void Paginacategoria_Tapped(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Categoria());
            IsPresented = false;
        }

        private void Paginasobre_Tapped(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Sobre());
            IsPresented = false;
        }

        private void Paginausuarios_Tapped(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new ListarUsers());
            IsPresented = false;
        }
    }
}