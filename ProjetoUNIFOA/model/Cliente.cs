using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Model
{
    public class Cliente
    {
        private string _nome;
        private string _cpf;
        private DateTime _dataNascimento;



        public string Nome
        {
            get => _nome;
            set => _nome = value;
        }

        public string CPF
        {
            get => _cpf;
            set
            {
                if (value.Length == 11 && long.TryParse(value, out _))
                {
                    _cpf = value;
                }
                else
                {
                    throw new ArgumentException("CPF deve conter 11 dígitos.");
                }
            }
        }

        public DateTime DataNascimento
        {
            get => _dataNascimento;
            set
            {
                if ((DateTime.Now.Year - value.Year) >= 18)
                {
                    _dataNascimento = value;
                }
                else
                {
                    throw new ArgumentException("O cliente deve ter mais de 18 anos.");
                }
            }
        }



        public Cliente(string nome, string cpf, DateTime dataNascimento)
        {
            Nome = nome;
            CPF = cpf;
            DataNascimento = dataNascimento;
        }

        public int Idade
        {
            get { return DateTime.Now.Year - DataNascimento.Year; }
        }

        public string ConverterParaRomano()
        {
            int idade = Idade;
            string romano = "";
            if (idade > 0)
            {
                if (idade >= 1000)
                {
                    romano += "M";
                    idade -= 1000;
                }
                if (idade >= 900)
                {
                    romano += "CM";
                    idade -= 900;
                }
                if (idade >= 500)
                {
                    romano += "D";
                    idade -= 500;
                }
                if (idade >= 400)
                {
                    romano += "CD";
                    idade -= 400;
                }
                while (idade >= 100)
                {
                    romano += "C";
                    idade -= 100;
                }
                if (idade >= 90)
                {
                    romano += "XC";
                    idade -= 90;
                }
                if (idade >= 50)
                {
                    romano += "L";
                    idade -= 50;
                }
                if (idade >= 40)
                {
                    romano += "XL";
                    idade -= 40;
                }
                while (idade >= 10)
                {
                    romano += "X";
                    idade -= 10;
                }
                if (idade >= 9)
                {
                    romano += "IX";
                    idade -= 9;
                }
                if (idade >= 5)
                {
                    romano += "V";
                    idade -= 5;
                }
                if (idade >= 4)
                {
                    romano += "IV";
                    idade -= 4;
                }
                while (idade >= 1)
                {
                    romano += "I";
                    idade -= 1;
                }
                return romano;
            }
            else
            {
                return "Idade inválida";

            }
        }
    }
}
