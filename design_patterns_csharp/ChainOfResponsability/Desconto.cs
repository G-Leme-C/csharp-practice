public interface Desconto {
    public Desconto ProximoDesconto { get; set; }
    public double CalcularDesconto(Orcamento orcamento); 
}
