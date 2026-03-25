using ConceitosPOO;



namespace TestConceitosPOO2
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
            decimal saldoContaOrigem = 1000;
            decimal saldoContaDestino = 500;
            decimal valorTransferencia = 250;
            decimal saldoEsperadoContaOrigem = 750;
            decimal saldoEsperadoContaDestino = 750;
            Conta contaOrigem = new Conta(111, saldoContaOrigem);
            Conta contaDestino = new Conta(222, saldoContaDestino);

            //ação
            contaOrigem.Transferencia(valorTransferencia, contaDestino);

            //verificação
            Assert.AreEqual(saldoEsperadoContaOrigem, contaOrigem.Saldo);
            Assert.AreEqual(saldoEsperadoContaDestino, contaDestino.Saldo);
        }

        [TestMethod]
        public void TestSaqueNegativo()
        {
            // cenário
            decimal saldoInicial = 1000;
            decimal valorSaque = -1;

            Conta conta = new Conta(111, saldoInicial);

            // verificação
            Assert.ThrowsException<ArgumentException>(() => conta.Saque(valorSaque));
        }
    }
}
