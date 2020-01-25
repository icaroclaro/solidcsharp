using System;
using System.Collections.Generic;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Fatura fatura = new Fatura("Icaro", 4000);
            List<Boleto> boletos = new List<Boleto>
            {
                new Boleto(1000),
                new Boleto(1000),
                new Boleto(1000),
                new Boleto(1000),
                new Boleto(1000)
            };

            ProcessadorDeBoletos processaBoletos = new ProcessadorDeBoletos();
            processaBoletos.Processa(boletos, fatura);;
            fatura.CalculaValorPago();

            Console.WriteLine($"Fatura paga = {fatura.Pago}");

        }
    }
}
