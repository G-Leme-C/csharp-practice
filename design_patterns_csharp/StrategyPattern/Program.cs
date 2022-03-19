// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Orcamento orcamento = new Orcamento(2000);

CalculadorDeImposto calculador = new CalculadorDeImposto();

Console.WriteLine("Orçamento: " + orcamento.Valor);
Console.WriteLine($"Imposto {nameof(ICMS)}: {calculador.CalcularImposto(orcamento, new ICMS())}");
Console.WriteLine($"Imposto {nameof(ICCC)}: {calculador.CalcularImposto(orcamento, new ICCC())}");
Console.WriteLine($"Imposto {nameof(ISS)}: {calculador.CalcularImposto(orcamento, new ISS())}");
