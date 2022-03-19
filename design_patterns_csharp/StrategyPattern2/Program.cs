ContaBancaria conta = new ContaBancaria() {
    Saldo = 1000
};

Investimento investimento = new InvestimentoConservador();
Investimento investimentoModerado = new InvestimentoModerado();
Investimento investimentoArrojado = new InvestimentoArrojado();

RealizadorDeInvestimento investidor = new RealizadorDeInvestimento();

Console.WriteLine($"Valor investido: {conta.Saldo}");

Console.WriteLine($"Conservador: {investidor.RealizarInvestimento(conta, investimento)}");
Console.WriteLine($"Moderado: {investidor.RealizarInvestimento(conta, investimentoModerado)}");
Console.WriteLine($"Arrojado: {investidor.RealizarInvestimento(conta, investimentoArrojado)}");