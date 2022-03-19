Orcamento orcamento = new Orcamento();

orcamento.AdicionarItem(new Item("Caneta", 500));

CalculadorDeImposto calculador = new CalculadorDeImposto();

Console.WriteLine("Orçamento: " + orcamento.Valor);
Console.WriteLine($"Imposto {nameof(ICPP)}: {calculador.CalcularImposto(orcamento, new ICPP())}");
Console.WriteLine($"Imposto {nameof(IKCV)}: {calculador.CalcularImposto(orcamento, new ICPP())}");
Console.WriteLine($"Imposto {nameof(IHIT)}: {calculador.CalcularImposto(orcamento, new IHIT())}");

