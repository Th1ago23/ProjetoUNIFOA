using SistemaFinanceiro.Model;
using static System.Net.Mime.MediaTypeNames;
Banco banco1 = new Banco(1, "Caixa");

Agencia agencia1 = new Agencia(123, "PablinInvest", "24988998899", banco1);

Cliente cliente1 = new Cliente("João", "12345678901", new DateTime(1990, 5, 20));
Cliente cliente2 = new Cliente("Cayque", "10987654321", new DateTime(1985, 8, 15));

Conta conta1 = new Conta(123456, 1235.42m, cliente1, agencia1);
Conta conta2 = new Conta(654321, 2341.42m, cliente2, agencia1);

Console.WriteLine("Trabalho POO\n");
Console.WriteLine($"Saldo total da conta 1 é : R${conta1.Saldo}");
Console.WriteLine($"Saldo total da conta 1 é : R${conta2.Saldo}");

// Cálculo do saldo total
decimal saldoTotal = conta1.Saldo + conta2.Saldo;

// Identificação da conta com maior saldo
Conta contaMaiorSaldo = (conta1.Saldo > conta2.Saldo) ? conta1 : conta2;

// Saldo inicial total geral
conta1.Transferencia(100m, conta2);

decimal saldoInicialTotalGeral = conta1.Saldo + conta2.Saldo;

// Exibição dos resultados
Console.WriteLine($"Saldo total das duas contas: R${saldoTotal}");
Console.WriteLine($"Número da conta com maior saldo: {contaMaiorSaldo.Numero}");
Console.WriteLine($"Saldo inicial total geral: R${saldoInicialTotalGeral:C}");

// Clientes
Console.WriteLine($"Cliente: {cliente1.Nome}, CPF: {cliente1.CPF}, Data de Nascimento: {cliente1.DataNascimento.ToShortDateString()}");
Console.WriteLine($"Cliente: {cliente2.Nome}, CPF: {cliente2.CPF}, Data de Nascimento: {cliente2.DataNascimento.ToShortDateString()}");

Console.WriteLine($"Idade em romano do cliente {cliente1.Nome} é {cliente1.ConverterParaRomano()}");