using SistemaFinanceiro.Model;

namespace TesteSistemaFinanceiro


{
    [TestClass]
    public class ContaTeste
    {
        [TestMethod]
        public void DepositarTeste()
        {
            decimal saldoInicial = 1000;
            decimal valorDeposito = 1000;
            decimal valorFinal = 2000;

            Conta conta1 = new Conta(123, saldoInicial);

            conta1.Deposito(valorDeposito);

            Assert.AreEqual(valorFinal, conta1.Saldo);
        }

        [TestMethod]
        public void SacarTeste()
        {
            var conta1 = new Conta(123, 100);

            conta1.Saque(100);

            Assert.AreEqual(0, conta1.Saldo);
        }

        [TestMethod]
        public void ValorSaqueMaiorSaldo()
        {
            //cenario
            decimal saldoInicial = 1000;
            decimal valorSaque = 1500;
            Conta conta1 = new Conta(123, saldoInicial);

            //verificação
            Assert.ThrowsException<ArgumentException>(() => conta1.Saque(valorSaque));
        }
    }
}