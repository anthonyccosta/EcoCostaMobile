using System;
using System.Collections.Generic;
using System.Text;

namespace EcoCostaMobile.Models
{
    public class Usuarios
    {
        public int ID { get; set; }
        public string Usuario { get; set; }
        public string senha { get; set; }
        public string confirmarsenha { get; set; }
        public string Email { get; set; }
    }
}
