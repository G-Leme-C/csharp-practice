List<Conta> contas = new List<Conta>() {
    new Conta(80, DateTime.Now.AddDays(-100)),
    new Conta(1000, DateTime.Now.AddDays(-90)),
    new Conta(10000, DateTime.Now.AddDays(-20)),
    new Conta(600000, DateTime.Now.AddDays(-35)),
    new Conta(1000000, DateTime.Now.AddDays(-1))
};

foreach(var conta in contas) {
    Console.WriteLine($"{conta.DataCriacaoConta.ToString("dd/MM/yyyy hh:mm")} | {conta.Saldo}");
}

Console.WriteLine("\n__________________________________________________\n");

Filtro filtrosFraude = new FiltroMenorQue100(new FiltroMaiorQue500Mil(new FiltroContasCriadasMesCorrente()));

var contasFiltradas = filtrosFraude.Filtra(contas);

foreach(var conta in contasFiltradas) {
    Console.WriteLine($"{conta.DataCriacaoConta.ToString("dd/MM/yyyy hh:mm")} | {conta.Saldo}");
}
