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

        public bool Depositar(double valor)
        {
            if (valor <= 0) return false;

            saldo += valor;
            return true;
        }

        public bool Sacar(double valor)
        {
            if (valor > saldo || valor <= 0) return false;

            saldo -= valor;
            return true;
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (Sacar(valor))
            {
                destino.Depositar(valor);
                return true;
            }

            return false;
        }
    }
}
