using System;
using System.Collections.Generic;
using System.Text;

namespace Solid
{
    public class CalculadoraDeSalario
    {
        public double Calcula(Funcionario funcionario)
        {
            if (funcionario.Cargo is Desenvolvedor)
            {
                DezOuVintePorcento dez = new DezOuVintePorcento();
                return dez.Calcula(funcionario);
            }

            if (funcionario.Cargo is Dba || funcionario.Cargo is Tester)
            {
                QuinzeOuVinteCincoPorcento quinze = new QuinzeOuVinteCincoPorcento();
                return quinze.Calcula(funcionario);
            }

            throw new Exception("funcionario invalido");
        }

    }
}
