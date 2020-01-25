using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitutive
{
    class ContaEstudante : ContaComum
    {
        public int Milhas { get; private set; }

        public override void Deposita(double valor)
        {
            base.Deposita(valor);
            this.Milhas += (int)valor;
            throw new ArgumentException();
        }
    }
}
