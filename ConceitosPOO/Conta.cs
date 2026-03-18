using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitosPOO
{
    public class Conta
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

        public void Deposito(decimal valor)
        {
            if (valor > 0)
            {
                this.Saldo += valor;
            }
            else
            {
                throw new ArgumentException("valor invalido para deposito! favor entrar com um valor acima de R$00,00");
            }
        }

        public void Saque(decimal valor)
        {
            {
                if (valor > 0)
                {
                    this.Saldo -= valor;
                }
                else
                {
                    throw new ArgumentException("valor invalido para saque! favor entrar com um valor acima de R$00,00");
                }
            }
        }
        public void Transferencia( decimal valor, Conta contadois)
        {
            if (valor > 0)
            {
                this.Saldo -= valor;
                contadois.Saldo += valor;
            }
            else
            {
                throw new ArgumentException("valor invalido para saque! favor entrar com um valor acima de R$00,00");
            }
        }
    }
}
