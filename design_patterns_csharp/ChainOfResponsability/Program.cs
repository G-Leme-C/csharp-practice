Orcamento orcamento = new Orcamento();
orcamento.AdicionarItem(new Item("CANETA", 100));
orcamento.AdicionarItem(new Item("LAPIS", 100));

CalculadorDeDesconto calculador = new CalculadorDeDesconto();
var desconto = calculador.CalcularDesconto(orcamento);

Console.WriteLine($"Valor orcamento: {orcamento.Valor}");
Console.WriteLine($"Desconto: {desconto}");