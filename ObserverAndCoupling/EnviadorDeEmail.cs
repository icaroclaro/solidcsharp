using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverAndCoupling
{
    public class EnviadorDeEmail : IAcaoAposGerarNota
    {
        public void Executar(NotaFiscal nf)
        {
            Console.WriteLine("Enviando email");
        }
    }

}
