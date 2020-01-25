using System;

namespace OCPAndDependencyInversion
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadoraDePrecos calculadoraDePreco = new CalculadoraDePrecos(new Frete(), new TabelaDePrecoPadrao());
            Compra compra = new Compra();
            compra.Cidade = "SAO PAULO";
            compra.Valor = 5000;
            double valor = calculadoraDePreco.Calcula(compra);

            Console.WriteLine($"Valor total para a cidade {compra.Cidade} é: {valor}");
        }
    }
}
