

Conta c1 = new Conta("Andreza", "1234", "4321", 200000);
Conta c2 = new Conta("Fulano", "789", "9874", 100);
Conta c3 = new Conta("Ciclano", "987", "4789", 1000);

List<Conta> contas = new List<Conta>() {
    c1, c2, c3
};

IRelatorio relatorioSimples = new RelatorioSimples();
IRelatorio relatorioComplexo = new RelatorioComplexo();

Console.WriteLine("Relatório simples:");
relatorioSimples.ImprimirRelatorio(contas);

Console.WriteLine("");
Console.WriteLine("");

Console.WriteLine("Relatório Complexo:");
relatorioComplexo.ImprimirRelatorio(contas);