public class FiltroMaiorQue500Mil : Filtro
{
    public FiltroMaiorQue500Mil(Filtro outroFiltro) : base(outroFiltro) { }
    public FiltroMaiorQue500Mil() { }

    public override IList<Conta> Filtra(IList<Conta> contas)
    {
        var contasFiltradas = contas
            .Where(c => c.Saldo >= 500000)
            .ToList();

        foreach(var conta in contasFiltradas) {
            contas.Remove(conta);
        }

        contasFiltradas.AddRange(FiltraProximoFiltro(contas));
        return contasFiltradas;
    }
}