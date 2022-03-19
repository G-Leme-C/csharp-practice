public class InvestimentoConservador : Investimento
{
    public double CalcularLucro(double valorInvestido)
    {
        return valorInvestido * 0.008;
    }
}