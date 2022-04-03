namespace EstadosOrcamento {
    public class EmAprovacao : EstadoDeOrcamento {

        private bool _descontoAplicado = false;

        public void AplicaDesconto(Orcamento orcamento) {
            if(_descontoAplicado == false) {
                orcamento.Valor -= orcamento.Valor * 0.05;
                _descontoAplicado = true;
            } else {
                throw new Exception("Desconto de orçamento em aprovação já foi aplicado.");
            }
        }

        public void Aprovar(Orcamento orcamento)
        {
            orcamento.EstadoDoOrcamento = new Aprovado();
        }

        public void Finalizar(Orcamento orcamento)
        {
            throw new Exception("Não é possível finalizar um orçamento em aprovação.");
        }

        public void Reprovar(Orcamento orcamento)
        {
            orcamento.EstadoDoOrcamento = new Reprovado();
        }
    }
}