using System;
using System.Collections.Generic;
using System.Text;

namespace EcoCostaMobile.Models
{
    public class Produtos
    {
        public int ID { get; set; }
        public string NomeProduto { get; set; }
        public string Categoria { get; set; }
        public string DescricaoProduto { get; set; }
        public int Quantidade { get; set; }
        public string Fornecedores { get; set; }
        public int Unidade { get; set; }
        public int Total { get; set; }
    }
}
