using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitutive
{
    class ContaComum
    {
        public double Saldo { get; private set; }

        public ContaComum()
        {
            this.Saldo = 0;
        }

        public virtual void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        public void Saca(double valor)
        {
            if (valor <= this.Saldo)
            {
                this.Saldo -= valor;
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public void somaInvestimento()
        {
            this.Saldo += this.Saldo * 0.01;
        }
    }
}
