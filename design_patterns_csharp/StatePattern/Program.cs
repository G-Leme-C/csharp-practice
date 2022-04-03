using EstadosOrcamento;

Orcamento orcamento = new Orcamento(100);

orcamento.AplicaDescontoExtra();
Console.WriteLine($"Desconto Em Aprovação: {orcamento.Valor}");
try {
    orcamento.AplicaDescontoExtra();
} catch(Exception e) {
    Console.WriteLine(e.Message);
}


orcamento.Aprovar();
orcamento.AplicaDescontoExtra();
Console.WriteLine($"Desconto Aprovado: {orcamento.Valor}");
try {
    orcamento.AplicaDescontoExtra();
} catch(Exception e) {
    Console.WriteLine(e.Message);
}



