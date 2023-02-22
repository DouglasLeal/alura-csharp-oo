using ByteBank.Models;

var c1 = new ContaCorrente();
var c2 = new ContaCorrente();

c1.titular = new Cliente() { nome = "Douglas" };
c1.numero_agencia = 10;
c1.conta = 1001;

c2.titular = new Cliente() { nome = "Ana" };
c2.numero_agencia = 10;
c2.conta = 1002;

Console.WriteLine(c1.ToString());

c1.Depositar(100);

Console.WriteLine(c1.ToString());

c1.Transferir(50, c2);

Console.WriteLine(c1.ToString());

Console.WriteLine(c2.ToString());