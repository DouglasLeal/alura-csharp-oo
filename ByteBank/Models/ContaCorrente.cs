using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Models
{
    public class ContaCorrente
    {
        public int numero_agencia;
        public int conta;
        public string titular;
        public double saldo;

        public void Depositar(double valor)
        {
            saldo += valor;
        }
    }
}
