using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverAndCoupling
{
    class Fatura
    {
        public double ValorMensal { get; set; }
        public string Cliente { get; private set; }

        public Fatura(double valorMensal, string cliente)
        {
            this.ValorMensal = valorMensal;
            this.Cliente = cliente;
        }
    }
}
