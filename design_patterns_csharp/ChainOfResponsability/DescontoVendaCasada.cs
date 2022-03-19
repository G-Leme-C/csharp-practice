public class DescontoVendaCasada : Desconto
{
    public Desconto ProximoDesconto { get; set; }

    public double CalcularDesconto(Orcamento orcamento)
    {
        var lapis = orcamento.Itens.Count(i => i.Nome.ToLower().Contains("lapis"));
        var caneta = orcamento.Itens.Count(i => i.Nome.ToLower().Contains("caneta"));

        if(caneta == 1 && lapis == 1)
            return orcamento.Valor * 0.05;

        return ProximoDesconto.CalcularDesconto(orcamento);
    }
}