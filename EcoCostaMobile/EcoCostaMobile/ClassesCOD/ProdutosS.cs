using EcoCostaMobile.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace EcoCostaMobile.ClassesCOD
{
    public class ProdutosS
    {
        public List<Produtos> SelectAll()
        {
            try
            {
                var itens = ((App)Application.Current).conexao.Query<Produtos>("SELECT * FROM Produtos");
                return itens;
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao Listar\nDetalhes:" + ex.Message);
            }
        }

        public bool Inserir(string NomeProduto, string Categoria, string DescricaoProduto, string Quantidade, string Fornecedores, string Unidade, string Total)
        {
            try
            {
                var query = $"INSERT INTO Produtos (NomeProduto, Categoria, DescricaoProduto, Quantidade, Fornecedores, Unidade, Total) VALUES ('{NomeProduto}', '{Categoria}', '{DescricaoProduto}', {Quantidade}, '{Fornecedores}', {Unidade}, {Total})";
                ((App)Application.Current).conexao.Execute(query);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao Inserir\nDetalhes:" + ex.Message);
            }
        }

        public bool Update(string Produto, string Categoria, string Descricao, string Quantidade, string Fornecedores, string Unidade, string Total, int id)
        {
            try
            {
                var query = $"UPDATE Produtos SET NomeProduto = '{Produto}', Categoria = '{Categoria}', DescricaoProduto = '{Descricao}', Quantidade = {Quantidade}, Fornecedores = '{Fornecedores}', Unidade = {Unidade}, Total = {Total} WHERE ID = {id}";
                ((App)Application.Current).conexao.Execute(query);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao Atualizar\nDetalhes:" + ex.Message);
            }
        }

        public bool DeleteAll()
        {
            try
            {
                var query = $"DELETE FROM Produtos";
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
                var query = $"DELETE FROM Produtos WHERE ID = {id}";
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
