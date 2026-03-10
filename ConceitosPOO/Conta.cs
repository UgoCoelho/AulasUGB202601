using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitosPOO
{
    internal class Conta
    {
        private long _numero;
        public long Numero 
        { 
            get => _numero;
            set 
            {
                _numero = value;
            } 
        }

        private decimal _saldo;
        public decimal Saldo 
        { 
            get => _saldo;
            set
            {
                _saldo = value;
            } 
        }
        
        public Conta(long numero, decimal saldo)
        {
            _numero = numero;
            _saldo = saldo;
        }
    }
}
