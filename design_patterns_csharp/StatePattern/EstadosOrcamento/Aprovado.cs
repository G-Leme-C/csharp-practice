namespace EstadosOrcamento {
    public class Aprovado : EstadoDeOrcamento {

        private bool _descontoAplicado;

        public void AplicaDesconto(Orcamento orcamento) {
            if(_descontoAplicado == false) {
                orcamento.Valor -= orcamento.Valor * 0.02;
                _descontoAplicado = true;
            } else {
                throw new Exception("Desconto de orçamento aprovado já foi aplicado.");
            }
        }

        
        public void Aprovar(Orcamento orcamento)
        {
            throw new Exception("Não é possível aprovar um orçamento já aprovado.");
        }

        public void Finalizar(Orcamento orcamento)
        {
            orcamento.EstadoDoOrcamento = new Finalizado();
        }

        public void Reprovar(Orcamento orcamento)
        {
            throw new Exception("Não é possível reprovar um orçamento já aprovado.");
        }
    }
}