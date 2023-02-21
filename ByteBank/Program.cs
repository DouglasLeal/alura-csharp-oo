using ByteBank.Models;

var c1 = new ContaCorrente();

c1.titular = "Douglas";
c1.numero_agencia = 10;
c1.conta = 1001;
c1.saldo = 100;

Console.WriteLine($"Titular: {c1.titular} | Saldo: {c1.saldo}");

c1.Depositar(100);

Console.WriteLine($"Titular: {c1.titular} | Saldo: {c1.saldo}");