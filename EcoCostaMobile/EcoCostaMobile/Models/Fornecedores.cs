using System;
using System.Collections.Generic;
using System.Text;

namespace EcoCostaMobile.Models
{
    public class Fornecedores
    {
        public int ID { get; set; }
        public string NomeFornecedor { get; set; }
        public string CNPJ { get; set; }
        public string DataNascimento { get; set; }
        public string Sexo { get; set; }
        public string TelefoneCelular { get; set; }
        public string TelefoneResidencial { get; set; }
        public string Email { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Numero { get; set; }
        public string Uf { get; set; }
        public string CEP { get; set; }
    }
}
