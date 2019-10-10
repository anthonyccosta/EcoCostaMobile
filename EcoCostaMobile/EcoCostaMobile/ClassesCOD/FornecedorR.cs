using System;
using System.Collections.Generic;
using System.Text;
using EcoCostaMobile.Models;
using Xamarin.Forms;

namespace EcoCostaMobile.ClassesCOD
{
    public class FornecedorR
    {
        public List<Fornecedores> SelectAll()
        {
            try
            {
                var itens = ((App)Application.Current).conexao.Query<Fornecedores>("SELECT * FROM Fornecedores");
                return itens;
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao Listar\nDetalhes:" + ex.Message);
            }
        }

        public bool InserirFornecedor(string NomeFornecedor, string CNPJ, string DataNascimento, string Sexo, string TelefoneCelular, string TelefoneResidencial, string Email, string Rua, string Bairro, string Numero, string Uf, string CEP)
        {
            try
            {
                var query = $"INSERT INTO Fornecedores (NomeFornecedor, CNPJ, DataNascimento, Sexo, TelefoneCelular, TelefoneResidencial, Email, Rua, Bairro, Numero, UF, CEP) VALUES ('{NomeFornecedor}', '{CNPJ}', '{DataNascimento}', '{Sexo}', '{TelefoneCelular}', '{TelefoneResidencial}', '{Email}', '{Rua}', '{Bairro}', '{Numero}', '{Uf}', '{CEP}')";
                ((App)Application.Current).conexao.Execute(query);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao Inserir\nDetalhes:" + ex.Message);
            }
        }

        public bool Update(string NomeFornecedor, string CNPJ, string DataNascimento, string Sexo, string TelefoneCelular, string TelefoneResidencial, string Email, string Rua, string Bairro, string Numero, string Uf, string CEP, int id)
        {
            try
            {
                var query = $"UPDATE Fornecedor SET NomeFornecedor = '{NomeFornecedor}', CNPJ = '{CNPJ}', DataNascimento = '{DataNascimento}', Sexo = '{Sexo}', TelefoneCelular = '{TelefoneCelular}', TelefoneResidencial = '{TelefoneResidencial}', Email = '{Email}', Rua = '{Rua}', Bairro = '{Bairro}', Numero = '{Numero}', UF = '{Uf}', CEP = '{CEP}' WHERE ID = {id}";
                ((App)Application.Current).conexao.Execute(query);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao Atualizar\nDetalhes:" + ex.Message);
            }
        }

        public bool DeleteAllFornecedores()
        {
            try
            {
                var query = $"DELETE FROM Fornecedores";
                ((App)Application.Current).conexao.Execute(query);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao Deletar\nDetalhes:" + ex.Message);
            }
        }

        public bool DeleteItemFornecedor(int id)
        {
            try
            {
                var query = $"DELETE FROM Fornecedor WHERE ID = {id}";
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
