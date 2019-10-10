using System;
using System.Collections.Generic;
using System.Text;
using EcoCostaMobile.Models;
using Xamarin.Forms;

namespace EcoCostaMobile.ClassesCOD
{
    public class categoriA
    {
        public List<CategoriA> SelectAll()
        {
            try
            {
                var itens = ((App)Application.Current).conexao.Query<CategoriA>("SELECT * FROM Categoria");
                return itens;
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao Listar\nDetalhes:" + ex.Message);
            }
        }

        public bool InserirCategoria(string categoriaa)
        {
            try
            {
                var query = $"INSERT INTO Categoria (categoria) VALUES ('{categoriaa}')";
                ((App)Application.Current).conexao.Execute(query);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao Inserir\nDetalhes:" + ex.Message);
            }
        }

        public bool UpdateCategoria(string categoria, int id)
        {
            try
            {
                var query = $"UPDATE Categoria SET Categoria = '{categoria}', WHERE ID = {id}";
                ((App)Application.Current).conexao.Execute(query);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao Atualizar\nDetalhes:" + ex.Message);
            }
        }

        public bool DeletartodasCategorias()
        {
            try
            {
                var query = $"DELETE FROM Categoria";
                ((App)Application.Current).conexao.Execute(query);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao Deletar\nDetalhes:" + ex.Message);
            }
        }

        public bool DeleteItemCategoria(int id)
        {
            try
            {
                var query = $"DELETE FROM Categoria WHERE ID = {id}";
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
