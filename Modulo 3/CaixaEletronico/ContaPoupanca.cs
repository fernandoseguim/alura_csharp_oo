﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class ContaPoupanca : Conta, ITributavel
    {
        public ContaPoupanca(Cliente titular, int numero) : base(titular, numero)
        {
        }

        public double CalculaTributo()
        {
            return this.Saldo * 0.03;
        }

        public override void Saca(double valor)
        {
            if (valor > this.Saldo)
            {
                throw new SaldoInsuficienteExecption();
            }
            if (valor < 0)
            {
                throw new ArgumentException();
            }
            else
            {
                this.Saldo -= valor;
            }
        }

    }
}
