using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PapelariaAris.Model
{
    internal class clientesirismoon
    {
        public int CodCliente { get;set; }
        public string NomeCompleto { get; set; }
        public float CPF { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int CEP { get; set; }
        public string Estado { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public int NumeroDaCasa { get; set; }

        public clientesirismoon(string CodCliente, string NomeCompleto, float CPF, string Email, string senha,
            int CEP, string Estado, string Bairro, string Rua, int NumeroDaCasa);
            


    }
}
