using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Model
{
    public class Conta
    {
        private long _numero;
        private decimal _saldo;
        private Cliente _cliente;
        private Agencia _agencia;

        public long Numero
        {
            get => _numero;
            private set
            {
                _numero = value;
            }
        }

        public decimal Saldo
        {
            get => _saldo;

        }

        public Cliente Cliente
        {
            get => _cliente;
            private set
            {
                _cliente = value;
            }
        }

        public Agencia Agencia
        {
            get => _agencia;
            private set
            {
                _agencia = value;
            }
        }

        public Conta(long numero, decimal saldo, Cliente cliente, Agencia agencia)
        {
            _numero = numero;

            if (saldo > 10m)
            {
                _saldo = saldo;
            }
            else
            {
                throw new Exception($"Não foi possivel criar a conta. O cliente {cliente.Nome} deve ter saldo maior que R$10,00 para abrir a conta.");
            }

            if (cliente != null)
            {
                _cliente = cliente;
            }
            else
            {
                throw new Exception($"Não foi possivel criar a conta. A conta deve estar vinculada a um cliente");
            }

            _agencia = agencia;
        }


        public void consulta()
        {
            Console.WriteLine($"{_saldo}");
        }
        // crie o código de teste para testar o método de depósito e saque da conta

        public decimal Saque(decimal valor)
        {
            if (_saldo - (valor + 0.10m) >= 0)
            {
                _saldo -= valor + 0.10m;
                return _saldo;
            }
            else
            {
                throw new ArgumentException("Valor do saque ultrapassa o saldo");
            }

        }
        public void Deposito(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor do depósito deve ser positivo.");
            }
            if (valor > 0)
            {
                _saldo += valor;
                Console.WriteLine($"Deposito realizado com sucesso. Saldo atual {_saldo}");
            }

        }

        public void Transferencia(decimal valor, Conta conta)
        {
            if (_saldo - valor >= 0)
            {
                _saldo -= valor;
                conta.Deposito(valor);

                Console.WriteLine($"Transferência realizada com sucesso.");
                Console.WriteLine($"Saldo da conta destino: {conta.Saldo:C}");
                Console.WriteLine($"Saldo da conta atual: {_saldo:C}");
            }
            else
            {
                //Console.WriteLine("Saldo insuficiente para transferência");
                throw new ArgumentException("Saldo insuficiente para transferência");
            }
        }

    }
}
