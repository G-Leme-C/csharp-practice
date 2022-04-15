IExpressao esquerda = new Multiplicacao(new Numero(2), new Numero(5));
IExpressao direita = new Divisao(new Numero(20), new Numero(2));

IExpressao conta = new Soma(esquerda, direita);

Console.WriteLine(conta.Avalia());