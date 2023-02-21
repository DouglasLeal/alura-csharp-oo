using ByteBank.Models;

var c1 = new ContaCorrente();
var c2 = new ContaCorrente();

c1.titular = "Douglas";
c1.numero_agencia = 10;
c1.conta = 1001;
c1.saldo = 100;

c2.titular = "Ana";
c2.numero_agencia = 10;
c2.conta = 1002;
c2.saldo = 100;

Console.WriteLine($"Titular: {c1.titular} | Saldo: {c1.saldo}");

c1.Depositar(100);

Console.WriteLine($"Titular: {c1.titular} | Saldo: {c1.saldo}");

c1.Transferir(50, c2);

Console.WriteLine($"Titular: {c1.titular} | Saldo: {c1.saldo}");

Console.WriteLine($"Titular: {c2.titular} | Saldo: {c2.saldo}");