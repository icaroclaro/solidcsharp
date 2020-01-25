using System;
using System.Collections.Generic;
using System.Text;

namespace OCPAndDependencyInversion
{
    public class CalculadoraDePrecos
    {
        private IServicoDeEntrega servicoDeEntrega;
        private ITabelaDePreco tabelaDePreco;
        public CalculadoraDePrecos(IServicoDeEntrega servicoDeEntrega, ITabelaDePreco tabelaDePreco)
        {
            this.servicoDeEntrega = servicoDeEntrega;
            this.tabelaDePreco = tabelaDePreco;

        }

        public double Calcula(Compra produto)
        {
            double desconto = tabelaDePreco.DescontoPara(produto.Valor);
            double frete = servicoDeEntrega.Para(produto.Cidade);

            return produto.Valor * (1 - desconto) + frete;
        }
    }
}
