public class InvestimentoModerado : Investimento
{
    public double CalcularLucro(double valorInvestido)
    {
        bool escolhido = new Random().Next(101) > 50;
        if(escolhido)
            return 0.025 * valorInvestido;
        else
            return 0.007 * valorInvestido;
    }
}