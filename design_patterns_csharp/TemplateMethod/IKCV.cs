public class IKCV : TemplateImpostoCondicional
{
    public override bool DeveUsarTaxacaoMaxima(Orcamento orcamento)
    {
        return (orcamento.Valor >= 500) && TemItemMaiorQue100Reais(orcamento);
    }

    private bool TemItemMaiorQue100Reais(Orcamento orcamento) {
        return orcamento.Itens.Any(i => i.Valor > 100);
    }

    public override double MaximaTaxacao(Orcamento orcamento)
    {
        return orcamento.Valor * 0.1;
    }

    public override double MinimaTaxacao(Orcamento orcamento)
    {
        return orcamento.Valor * 0.06;
    }
}