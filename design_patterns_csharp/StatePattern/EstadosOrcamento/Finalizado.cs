namespace EstadosOrcamento {
    public class Finalizado : EstadoDeOrcamento {
        public void AplicaDesconto(Orcamento orcamento) {
            throw new Exception("Não é possível dar desconto à um orçamento Finalizado.");
        }

        
        public void Aprovar(Orcamento orcamento)
        {
            throw new Exception("Não é possível alterar o estado de um orçamento já finalizado.");
        }

        public void Finalizar(Orcamento orcamento)
        {
            throw new Exception("Não é possível alterar o estado de um orçamento já finalizado.");
        }

        public void Reprovar(Orcamento orcamento)
        {
            throw new Exception("Não é possível alterar o estado de um orçamento já finalizado.");
        }
    }
}