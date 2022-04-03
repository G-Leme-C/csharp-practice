public class FiltroContasCriadasMesCorrente : Filtro
{
    public FiltroContasCriadasMesCorrente(Filtro outroFiltro) : base(outroFiltro) { }
    public FiltroContasCriadasMesCorrente() { }

    public override IList<Conta> Filtra(IList<Conta> contas)
    {
        var contasFiltradas = contas
            .Where(c => c.DataCriacaoConta.Month == DateTime.Now.Month)
            .ToList();

        foreach(var conta in contasFiltradas) {
            contas.Remove(conta);
        }

        contasFiltradas.AddRange(FiltraProximoFiltro(contas));
        return contasFiltradas;
    }
}