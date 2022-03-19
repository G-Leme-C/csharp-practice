Orcamento orcamento = new Orcamento();
orcamento.AdicionarItem(new Item("Teste", 1000));
orcamento.AdicionarItem(new Item("Teste2", 2000));

CalculadorDeImposto calculador = new CalculadorDeImposto();

Console.WriteLine("Orçamento: " + orcamento.Valor);
// Console.WriteLine($"Imposto {nameof(ICMS)}: {calculador.CalcularImposto(orcamento, new ICMS())}");
// Console.WriteLine($"Imposto {nameof(ISS)}: {calculador.CalcularImposto(orcamento, new ISS())}");
// Console.WriteLine($"Imposto {nameof(ICMS)}+{nameof(ISS)}: {calculador.CalcularImposto(orcamento, new ICMS(new ISS()))}");
Console.WriteLine($"Imposto {nameof(ICMS)}+{nameof(IMA)}: {calculador.CalcularImposto(orcamento, new ICMS(new IMA()))}");
Console.WriteLine($"Imposto {nameof(IKCV)}: {calculador.CalcularImposto(orcamento, new IKCV())}");
Console.WriteLine($"Imposto {nameof(ICPP)}: {calculador.CalcularImposto(orcamento, new ICCC())}");
Console.WriteLine($"Imposto {nameof(IKCV)}+{nameof(ICPP)}: {calculador.CalcularImposto(orcamento, new IKCV(new ICCC()))}");