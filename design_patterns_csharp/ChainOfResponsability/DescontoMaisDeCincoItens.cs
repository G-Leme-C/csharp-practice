public class DescontoMaisDeCincoItens : Desconto
{
    public Desconto ProximoDesconto { get; set; }

    public double CalcularDesconto(Orcamento orcamento)
    {
        if(orcamento.Itens.Count > 5)
            return orcamento.Valor * 0.1;
        
        return ProximoDesconto.CalcularDesconto(orcamento);
    }
}