using System;
using System.Collections.Generic;
using System.Text;

namespace EcoCostaMobile.Models
{
    public class clientes
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public double CPF { get; set; }
        public int RG { get; set; }
        public string DataNascimento { get; set; }
        public string Sexo { get; set; }
        public int TelefoneCelular { get; set; }
        public int TelefoneResidencial { get; set; }
        public string Email { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }
        public string UF { get; set; }
        public int CEP { get; set; }
    }
}
