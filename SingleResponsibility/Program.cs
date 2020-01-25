using System;

namespace Solid
{
    class Program
    {
        static void Main(string[] args)
        {
            Desenvolvedor desenvolvedor = new Desenvolvedor(new DezOuVintePorcento());
            Funcionario funcionario = new Funcionario(desenvolvedor, 4000);

            CalculadoraDeSalario calculaSalario = new CalculadoraDeSalario();

            double salario = calculaSalario.Calcula(funcionario);
            Console.WriteLine(salario);
            Console.ReadLine();
        }
    }
}
