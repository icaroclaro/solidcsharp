using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{

    public class Fatura
    {
        public string Cliente { get; private set; }
        public double Valor { get; set; }
        private List<Pagamento> pagamentos;
        public bool Pago { get; set; }

        public Fatura(string cliente, double valor)
        {
            this.Cliente = cliente;
            this.Valor = valor;
            this.pagamentos = new List<Pagamento>();
            this.Pago = false;
        }

       
        public void AdicionaPagamentos(Pagamento pagamento)
        {
            pagamentos.Add(pagamento);
        }

        public void CalculaValorPago()
        {
            double total = 0;
            foreach(Pagamento pagamento in this.pagamentos)
            {
                total = total + pagamento.Valor;
            }
            if(total >= this.Valor)
            {
                this.Pago = true;
            }
        }
    }
}
