public class IHIT : TemplateImpostoCondicional
{
    public override bool DeveUsarTaxacaoMaxima(Orcamento orcamento)
    {
        return Tem2ItensComMesmoNome(orcamento);
    }

    private bool Tem2ItensComMesmoNome(Orcamento orcamento) {
        foreach(var item in orcamento.Itens) {
            var count = orcamento.Itens.Count(i => i.Nome == item.Nome);

            if(count >= 2) return true;
        }

        return false;
    }

    public override double MaximaTaxacao(Orcamento orcamento)
    {
        return (orcamento.Valor * 0.13) + 100;
    }

    public override double MinimaTaxacao(Orcamento orcamento)
    {
        return (orcamento.Valor * 0.01) * orcamento.Itens.Count;
    }
}