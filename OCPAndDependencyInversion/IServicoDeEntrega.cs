using System;
using System.Collections.Generic;
using System.Text;

namespace OCPAndDependencyInversion
{
    public interface IServicoDeEntrega
    {
        double Para(string cidade);
    }
}
