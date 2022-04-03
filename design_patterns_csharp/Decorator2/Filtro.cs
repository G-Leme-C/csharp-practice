public abstract class Filtro {

    private Filtro _proximoFiltro;
    public Filtro(Filtro proximoFiltro) { _proximoFiltro = proximoFiltro; }
    public Filtro() { }

    public abstract IList<Conta> Filtra(IList<Conta> contas);

    public IList<Conta> FiltraProximoFiltro(IList<Conta> contas) {
        if(_proximoFiltro != null)
            return _proximoFiltro.Filtra(contas);
        
        return new List<Conta>();
    }
}