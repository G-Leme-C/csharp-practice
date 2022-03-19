public abstract class TemplateImpostoCondicional : Imposto
{
    public double Calcula(Orcamento orcamento)
    {
        if(DeveUsarTaxacaoMaxima(orcamento))
            return MaximaTaxacao(orcamento);
        
        return MinimaTaxacao(orcamento);
    }

    public abstract bool DeveUsarTaxacaoMaxima(Orcamento orcamento);
    public abstract double MaximaTaxacao(Orcamento orcamento);
    public abstract double MinimaTaxacao(Orcamento orcamento);
}