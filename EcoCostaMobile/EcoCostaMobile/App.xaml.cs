using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLitePCL;
using PCLExt.FileStorage.Folders;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace EcoCostaMobile
{
    public partial class App : Application
    {
        //conexao com o banco de dados
        public SQLite.SQLiteConnection conexao { get; private set; }
        public App()
        {
            //Local do banco
            var pasta = new LocalRootFolder();

            //crio o arquivo do banco, se ele existir abro ele

            var arquivo = pasta.CreateFile("Banco.db", PCLExt.FileStorage.CreationCollisionOption.OpenIfExists);

            //faço a Conexão
            conexao = new SQLite.SQLiteConnection(arquivo.Path);

            //criar tabela, se ela não existir

            conexao.Execute("CREATE TABLE IF NOT EXISTS Clientes (ID INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, " +
                                                                  "Nome TEXT(255) NOT NULL, " +
                                                                  "CPF BIGINTEGER(11) NOT NULL, " +
                                                                  "RG INTEGER(9) NOT NULL, " +
                                                                  "DataNascimento TEXT(8) NOT NULL, " +
                                                                  "Sexo TEXT(10) NOT NULL, " +
                                                                  "TelefoneCelular INTEGER(11) NOT NULL, " +
                                                                  "TelefoneResidencial INTEGER(11) NOT NULL, " +
                                                                  "Email TEXT(255) NOT NULL, " +
                                                                  "Rua TEXT(255) NOT NULL, " +
                                                                  "Bairro TEXT(100)  NOT NULL, " +
                                                                  "Numero INTEGER(5) NOT NULL, " +
                                                                  "UF TEXT(2) NOT NULL, " +
                                                                  "CEP INTEGER(20) NOT NULL)");

            conexao.Execute("CREATE TABLE IF NOT EXISTS Produtos (ID INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, " +
                                                                  "NomeProduto TEXT(255) NOT NULL, " +
                                                                  "Categoria TEXT(100) NOT NULL, " +                                                                  
                                                                  "DescricaoProduto TEXT(255)  NOT NULL, " +
                                                                  "Quantidade INTEGER(50) NOT NULL, " +
                                                                  "Fornecedores TEXT(255) NOT NULL, " +
                                                                  "Unidade INTEGER(5) NOT NULL, " +
                                                                  "Total INTEGER(5)  NOT NULL)");

            conexao.Execute("CREATE TABLE IF NOT EXISTS Categoria (ID INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, " +
                                                                   "categoria TEXT(100) NOT NULL)");

            conexao.Execute("CREATE TABLE IF NOT EXISTS Fornecedores (ID INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, " +
                                                                      "NomeFornecedor TEXT(255) NOT NULL, " +
                                                                      "CNPJ INTEGER(14) NOT NULL, " +
                                                                      "DataNascimento TEXT(8) NOT NULL, " +
                                                                      "Sexo TEXT(10) NOT NULL, " +
                                                                      "TelefoneCelular INTEGER(11) NOT NULL, " +
                                                                      "TelefoneResidencial iNTEGER(11) NOT NULL, " +
                                                                      "Email TEXT(255) NOT NULL, " +
                                                                      "Rua TEXT(255) NOT NULL, " +
                                                                      "Bairro TEXT(100) NOT NULL, " +
                                                                      "Numero INTEGER(5)  NOT NULL, " +
                                                                      "UF TEXT(2)  NOT NULL, " +
                                                                      "CEP INTEGER(20) NOT NULL)");

            conexao.Execute("CREATE TABLE IF NOT EXISTS Usuarios (ID INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, " +
                                                                  "Usuario TEXT(200) NOT NULL, " +
                                                                  "senha TEXT(100) NOT NULL, " +
                                                                  "confirmarsenha TEXT(100) NOT NULL, " +
                                                                  "Email TEXT(255) NOT NULL)");
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
