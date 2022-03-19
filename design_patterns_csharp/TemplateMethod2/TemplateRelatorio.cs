public abstract class TemplateRelatorio : IRelatorio {

    public void ImprimirRelatorio(List<Conta> contas) {

        ImprimirCabecalho();

        ImprimirListaContas(contas);

        ImprimirRodape();

    }

    public abstract void ImprimirCabecalho();
    public abstract void ImprimirRodape();
    public abstract void ImprimirListaContas(List<Conta> contas);
}