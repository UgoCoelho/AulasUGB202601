using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitosPOO
{
    public class Agencia
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

        private string _telefone;
        public string Telefone 
        {
            get => _telefone;
            set
            {
                _telefone = value;
            }
        }

        private int _numero;
        public int Numero
        {
            get => _numero;
            private set
            {
                _numero = value;
            }
        }
        public Agencia(int numero)
        {
            _numero = numero;
        }
    }
}
