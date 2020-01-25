using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverAndCoupling
{
    class GeradorDeNotaFiscal
    {
        private IList<IAcaoAposGerarNota> acoes;

        public GeradorDeNotaFiscal(IList<IAcaoAposGerarNota> acoes)
        {
            this.acoes = acoes;
        }

        public NotaFiscal Gera(Fatura fatura)
        {

            double valor = fatura.ValorMensal;

            NotaFiscal nf = new NotaFiscal(valor, ImpostoSimplesSobreO(valor));

            foreach(IAcaoAposGerarNota acao in acoes)
            {
                acao.Executar(nf);
            }

            return nf;
        }

        private double ImpostoSimplesSobreO(double valor)
        {
            return valor * 0.06;
        }
    }








}
