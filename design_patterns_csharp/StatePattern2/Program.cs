Conta conta1 = new Conta();

conta1.Depositar(1000);
Console.WriteLine($"Saldo: {conta1.Saldo}");

conta1.Sacar(1000);
Console.WriteLine($"Saldo: {conta1.Saldo}");

conta1.Sacar(1000);
Console.WriteLine($"Saldo: {conta1.Saldo}");

conta1.Depositar(1000);
Console.WriteLine($"Saldo: {conta1.Saldo}");