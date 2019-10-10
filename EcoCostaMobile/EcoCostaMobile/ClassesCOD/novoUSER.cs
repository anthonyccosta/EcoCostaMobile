using System;
using System.Collections.Generic;
using System.Text;
using EcoCostaMobile.Models;
using Xamarin.Forms;

namespace EcoCostaMobile.ClassesCOD
{
    public class novoUSER
    {
        public List<Usuarios> SelectAll()
        {
            try
            {
                var itens = ((App)Application.Current).conexao.Query<Usuarios>("SELECT * FROM Usuarios");
                return itens;
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao Listar\nDetalhes:" + ex.Message);
            }
        }

        public bool Inserir(string User, string senha, string confirmarSenha, string email)
        {
            try
            {
                var query = $"INSERT INTO Usuarios (Usuario, senha, confirmarsenha, Email ) VALUES ('{User}', '{senha}', '{confirmarSenha}', '{email}')";
                ((App)Application.Current).conexao.Execute(query);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao Inserir\nDetalhes:" + ex.Message);
            }
        }

        public bool Update(string User, string senha, string confirmarSenha, string email, int id)
        {
            try
            {
                var query = $"UPDATE Usuarios SET Usuario = '{User}', senha = '{senha}', confirmarsenha = '{confirmarSenha}', Eamil = '{email}', WHERE ID = {id}";
                ((App)Application.Current).conexao.Execute(query);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao Atualizar\nDetalhes:" + ex.Message);
            }
        }

        public bool DeleteAllUSers()
        {
            try
            {
                var query = $"DELETE FROM Usuarios";
                ((App)Application.Current).conexao.Execute(query);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao Deletar\nDetalhes:" + ex.Message);
            }
        }

        public bool DeleteItemUser(int id)
        {
            try
            {
                var query = $"DELETE FROM Usuarios WHERE ID = {id}";
                ((App)Application.Current).conexao.Execute(query);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao Deletar\nDetalhes:" + ex.Message);
            }
        }

        public bool Login(string usuario, string senha)
        {           
            {
                var query = $"SELECT count (*) FROM Usuarios WHERE Usuarios = '{usuario}' AND senha = '{senha}'";
                return true;
            }
        }
    }
}
