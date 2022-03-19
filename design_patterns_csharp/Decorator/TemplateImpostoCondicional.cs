public abstract class TemplateImpostoCondicional : Imposto
{
    public TemplateImpostoCondicional(Imposto outroImposto) : base(outroImposto) { }
    public TemplateImpostoCondicional() { }

    public override double Calcula(Orcamento orcamento)
    {
        double taxacao = 0;
        
        if(DeveUsarTaxacaoMaxima(orcamento)) {
            taxacao = MaximaTaxacao(orcamento);
        }
        else {
            taxacao = MinimaTaxacao(orcamento);
        }
            
        return taxacao + CalculaOutroImposto(orcamento);
    }

    public abstract bool DeveUsarTaxacaoMaxima(Orcamento orcamento);
    public abstract double MaximaTaxacao(Orcamento orcamento);
    public abstract double MinimaTaxacao(Orcamento orcamento);
}