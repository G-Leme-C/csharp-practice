public class FiltroMenorQue100 : Filtro
{
    public FiltroMenorQue100(Filtro outroFiltro) : base(outroFiltro) { }
    public FiltroMenorQue100() { }

    public override IList<Conta> Filtra(IList<Conta> contas)
    {
        var contasFiltradas = contas
            .Where(c => c.Saldo <= 100)
            .ToList();

        foreach(var conta in contasFiltradas) {
            contas.Remove(conta);
        }

        return contas;
    }
}