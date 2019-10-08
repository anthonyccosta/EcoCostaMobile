using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace EcoCostaMobile.ClassesCOD
{
    public class Clientes
    {
        public object ID { get; private set; }

        public List<Clientes> SelectAll()
        {
            try
            {
                var itens = ((App)Application.Current).conexao.Query<Clientes>("SELECT * FROM Clientes");
                return itens;
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao Inserir\nDetalhes:" + ex.Message);
            }
        }

        public bool Inserir(string Nome, string CPF, string RG, string DataNascimento, string Sexo, string TelefoneCelular, string TelefoneResidencial, string Email, string Rua, string Bairro, string Numero, string Uf, string CEP)
        {
            try
            {
                var query = $"INSERT INTO Clientes (Nome, CPF, RG, DataNascimento, Sexo, TelefoneCelular, TelefoneResidencial, Email, Rua, Bairro, Numero, Uf, CEP) VALUES ('{Nome}', {CPF}, {RG}, '{DataNascimento}', '{Sexo}', '{TelefoneCelular}', '{TelefoneResidencial}', '{Email}', '{Rua}', '{Bairro}', '{Numero}', '{Uf}', '{CEP}')";
                ((App)Application.Current).conexao.Execute(query);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao Atualizar\nDetalhes:" + ex.Message);
            }
        }

        //public bool Update(string Nome, string CPF, string RG, string DataNascimento, string Sexo, string TelefoneCelular, string TelefoneResidencial, string Email, string Rua, string Bairro, string Numero, string Uf,string CEP, int id)
        //{
        //    try
        //    {
        //        var query = $"UPDATE CLientes SET Nome = '{Nome}', CPF = {CPF}, RG = {RG}, DataNascimento = '{DataNascimento}', Sexo = '{Sexo}', TelefoneCelular = '{TelefoneCelular}', TelefoneResidencial = '{TelefoneResidencial}', Email = '{Email}', Rua = '{Rua}', Bairro = '{Bairro}', Numero = '{Numero}', UF = '{Uf}', CEP = '{CEP}' WHERE ID = {id}";
        //        ((App)Application.Current).conexao.Execute(query);

        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Houve um erro ao Atualizar\nDetalhes:" + ex.Message);
        //    }
        //}

        public bool DeleteAll()
        {
            try
            {
                var query = $"DELETE FROM Clientes";
                ((App)Application.Current).conexao.Execute(query);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao Deletar\nDetalhes:" + ex.Message);
            }
        }

        public bool DeleteItem(int id)
        {
            try
            {
                var query = $"DELETE FROM Clientes WHERE ID = {id}";
                ((App)Application.Current).conexao.Execute(query);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao Deletar\nDetalhes:" + ex.Message);
            }
        }
    }    
}
