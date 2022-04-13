Conta c1 = new Conta (1);
Conta c2 = new Conta (2);

c1.Depositar(1000.00);
c1.Sacar(50.00);
Console.WriteLine(c1.Codigo);
Console.WriteLine(c1.Saldo);

c2.Depositar(200.00);
c2.Sacar(50.00);
Console.WriteLine(c2.Codigo);
Console.WriteLine(c2.Saldo);

c2.Transferir(100.00, c1);
Console.WriteLine("O novo saldo de c1 é:" + c1.Saldo);
Console.WriteLine("O novo saldo de c2 é:" + c2.Saldo);