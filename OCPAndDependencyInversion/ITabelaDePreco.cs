using System;
using System.Collections.Generic;
using System.Text;

namespace OCPAndDependencyInversion
{
    public interface ITabelaDePreco
    {
        double DescontoPara(double valor);
    }
}
