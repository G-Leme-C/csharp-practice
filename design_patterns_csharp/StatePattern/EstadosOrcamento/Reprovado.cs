namespace EstadosOrcamento {
    public class Reprovado : EstadoDeOrcamento {
        public void AplicaDesconto(Orcamento orcamento) {
            throw new Exception("Não é possível dar desconto à um orçamento reprovado.");
        }

        
        public void Aprovar(Orcamento orcamento)
        {
            throw new Exception("Não é possível aprovar um orçamento já reprovado.");
        }

        public void Finalizar(Orcamento orcamento)
        {
            orcamento.EstadoDoOrcamento = new Finalizado();
        }

        public void Reprovar(Orcamento orcamento)
        {
            throw new Exception("Não é possível reprovar um orçamento já reprovado.");
        }
    }
}