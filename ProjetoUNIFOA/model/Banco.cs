﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Model
{
    public class Banco
    {
        private int _numero;
        private string _nome;


        public Banco(int numero, string nome)
        {
            _nome = nome;
            _numero = numero;
        }
    }
}
