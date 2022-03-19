public class DescontoValorCompra : Desconto
{
    public Desconto ProximoDesconto { get; set; }

    public double CalcularDesconto(Orcamento orcamento)
    {
        if(orcamento.Valor > 500)
            return orcamento.Valor * 0.07;
        
        return ProximoDesconto.CalcularDesconto(orcamento);
    }
}