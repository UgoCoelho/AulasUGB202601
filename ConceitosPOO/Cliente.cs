using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitosPOO
{
    public class Cliente
    {
        
        private string _nome;
        
        public string Nome 
        {
            get
            {
                return _nome;
            }
            set
            {
                if (value.Length > 0)
                    _nome = value;
                else
                    throw new Exception("O nome não pode estar vazio!");
            }
        }

        private string _cpf;

        public string Cpf
        {
            get
            {
                return _cpf;
            }
            set
            {
                if (value.Length == 11)
                {
                    string cpfFormatado = Convert.ToUInt64(value)
                        .ToString(@"000\.000\.000\-00");

                    Console.WriteLine($"CPF do cliente: {cpfFormatado}");
                }
                else
                {
                    Console.WriteLine("CPF inválido!");
                }
            }
        }
    }
}
