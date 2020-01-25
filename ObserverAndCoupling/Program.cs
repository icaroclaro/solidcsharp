using System;
using System.Collections.Generic;

namespace ObserverAndCoupling
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IAcaoAposGerarNota> listaDeAcoes = new List<IAcaoAposGerarNota>();
            listaDeAcoes.Add(new EnviadorDeEmail());
            listaDeAcoes.Add(new NotaFiscalDao());

            GeradorDeNotaFiscal geradorNF = new GeradorDeNotaFiscal(listaDeAcoes);
            geradorNF.Gera(new Fatura(100, "Ícaro"));

            Console.WriteLine("FIM");
        }
    }
}
