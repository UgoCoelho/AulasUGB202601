using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConceitosPOO
{
    public class Cliente
    {
        
        private string _nome;
        
        public string Nome 
        {
            get => _nome;
            set
            {
                _nome = value;
            }
        }

        private string _cpf;

        public string Cpf
        {
            get=> _cpf;
           
            set
            {
                _cpf = value;
            }
        }
        public Cliente(string nome, string cpf)
        {
            _nome = nome;
            _cpf = cpf;
        }
    }
}
