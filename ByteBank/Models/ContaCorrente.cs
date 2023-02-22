using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Models
{
    public class ContaCorrente
    {
        private int _numeroAgencia;
        public int NumeroAgencia 
        { 
            get { return _numeroAgencia; } 
            set { if(value > 0) _numeroAgencia = value; } 
        }

        //private string _conta;
        public string? Conta { get; set; }

        public Cliente? Titular { get; set; }
        private double _saldo = 100;

        public bool Depositar(double valor)
        {
            if (valor <= 0) return false;

            _saldo += valor;
            return true;
        }

        public bool Sacar(double valor)
        {
            if (valor > _saldo || valor <= 0) return false;

            _saldo -= valor;
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

        public void SetSaldo(double valor)
        {
            if (valor < 0) return;

            _saldo = valor;
        }

        public double GetSaldo()
        {
            return _saldo;
        }

        public override string ToString()
        {
            return $"Titular: {Titular?.Nome} | Saldo: {_saldo} | Agência: {NumeroAgencia} | Conta: {Conta}";
        }
    }
}
