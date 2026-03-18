using ConceitosPOO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;


namespace TestConceitosPOO
{
    [TestClass]
    public class TesteConta
    {
        [TestMethod]
        public void TestDeposito()
        {
            //cenario
            decimal saldoInicial = 1000;
            decimal valorDeposito = 500;
            decimal saldoEsperado = 1500;
            Conta conta = new Conta(111, saldoInicial);

            //ação
            conta.Deposito(valorDeposito);

            //verificação
            Assert.AreEqual(saldoEsperado, conta.Saldo);
        }

        [TestMethod]
        public void TestSaque()
        {
            //cenario
            decimal saldoInicial = 1000;
            decimal valorSaque = 500;
            decimal saldoEsperado = 500;
            Conta conta = new Conta(111, saldoInicial);

            //ação
            conta.Saque(valorSaque);

            //verificação
            Assert.AreEqual(saldoEsperado, conta.Saldo);
        }

        [TestMethod]
        public void TestTransferencia()
        {
            //cenario
            decimal saldoContaUm = 1000;
            decimal saldoContaDois = 500;
            decimal valorTransferencia = 250;
            decimal saldoEsperadoContaUm = 750;
            decimal saldoEsperadoContaDois = 750;
            Conta contaum = new Conta(111, saldoContaUm);
            Conta contadois = new Conta(222, saldoContaDois);

            //ação
            contaum.Transferencia(valorTransferencia, contadois);

            //verificação
            Assert.AreEqual(saldoEsperadoContaUm, contaum.Saldo);
            Assert.AreEqual(saldoEsperadoContaDois, contadois.Saldo);
        }
    }
}
