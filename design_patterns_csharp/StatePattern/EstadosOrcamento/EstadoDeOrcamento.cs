namespace EstadosOrcamento
{
    public interface EstadoDeOrcamento {
        public void AplicaDesconto(Orcamento orcamento);

        public void Aprovar(Orcamento orcamento);
        public void Reprovar(Orcamento orcamento);
        public void Finalizar(Orcamento orcamento);
    }
}