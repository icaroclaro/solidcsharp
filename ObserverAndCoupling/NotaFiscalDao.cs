using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverAndCoupling
{
    class NotaFiscalDao : IAcaoAposGerarNota
    {
        public void Executar(NotaFiscal nf)
        {
            Console.WriteLine("Persistindo nota");
        }

    }
}
