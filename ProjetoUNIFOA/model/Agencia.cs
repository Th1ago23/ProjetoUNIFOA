using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Model
{
    public class Agencia
    {
        private int _numero;
        private string _nome, _telefone;
        private Banco _banco;

        public Agencia(int numero, string nome, string telefone, Banco banco)
        {
            _numero = numero;
            _nome = nome;
            _telefone = telefone;
            _banco = banco;
        }

        public int Numero { get => _numero; }
        public string Nome
        {
            get => _nome;
            set => _nome = value;
        }
        public string Telefone
        {
            get => _telefone;
            private set
            {
                _telefone = value;
            }
        }

        public Banco Banco
        {
            get => _banco;
            private set
            {
                _banco = value;
            }
        }

    }
}
