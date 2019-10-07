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

            conexao.Execute("CREATE TABLE IF NOT EXISTS Clientes (ID INTENGER PRIMARY KEY AUTOINCREMENT, Nome(255) TEXT NOT NULL, CPF(11) INTENGER NOT NULL, RG(9) INTENGER NOT NULL, DataNascimento(8) TEXT NOT NULL, Sexo(10) TEXT NOT NULL, TelefoneCelular(11) INTENGER NOT NULL, TelefoneResidencial(11) INTENGER NOT NULL, Email(255) TEXT NOT NULL, Rua(255) TEXT NOT NULL, Bairro(100) TEXT NOT NULL, Numero(5) INTENGER NOT NULL, UF(2) TEXT NOT NULL, CEP(20) INTENGER NOT NULL)");
            conexao.Execute("CREATE TABLE IF NOT EXISTS Produtos (ID INTENGER PRIMARY KEY AUTOINCREMENT, NomeProduto(255) TEXT NOT NULL, Categoria(100) TEXT NOT NULL, DescricaoProduto(255) TEXT NOT NULL, Fornecedores(255) TEXT NOT NULL, Unidade(5) INTENGER NOT NULL, Total(5) INTENGER NOT NULL)");
            conexao.Execute("CREATE TABLE IF NOT EXISTS Categoria (ID INTENGER PRIMARY KEY AUTOINCREMENT, categoria(100) TEXT NOT NULL)");
            conexao.Execute("CREATE TABLE IF NOT EXISTS Fornecedores (ID INTENGER PRIMARY KEY AUTOINCREMENT, NomeFornecedor(255) TEXT NOT NULL, CNPJ(14) INTENGER NOT NULL, DataNascimento(8) TEXT NOT NULL, Sexo(10) TEXT NOT NULL, TelefoneCelular(11) INTENGER NOT NULL, TelefoneResidencial(11) iNTENGER NOT NULL, Email(255) TEXT NOT NULL, Rua(255) TEXT NOT NULL, Bairro(100) TEXT NOT NULL, Numero(5) INTENGER NOT NULL, UF(2) TEXT NOT NULL, CEP(20) INTENGER NOT NULL)");
            conexao.Execute("CREATE TABLE IF NOT EXISTS Usuarios (ID INTENGER PRIMARY KEY AUTOINCREMENT, Usuario(200) TEXT NOT NULL, senha(100) TEXT NOT NULL, confirmarsenha(100) TEXT NOT NULL, Email(255) TEXT NOT NULL)");
            InitializeComponent();

            MainPage = new MainPage();
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
