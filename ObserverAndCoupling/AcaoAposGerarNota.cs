using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverAndCoupling
{
    interface IAcaoAposGerarNota
    {
        void Executar(NotaFiscal notafiscal);
    }
}
