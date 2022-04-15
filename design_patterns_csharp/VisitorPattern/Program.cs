IExpressao esquerda = new Multiplicacao(new Numero(2), new Numero(5));
IExpressao direita = new Divisao(new Numero(20), new Numero(2));

IExpressao conta = new Soma(esquerda, direita);

Console.WriteLine(conta.Avalia());

ImpressoraVisitor impressora = new ImpressoraVisitor();
conta.AceitaVisitor(impressora);

Console.WriteLine("\n\n");

ImpressoraPreFixoVisitor impressoraPreFixo = new ImpressoraPreFixoVisitor();
conta.AceitaVisitor(impressoraPreFixo);
