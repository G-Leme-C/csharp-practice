public class InvestimentoArrojado : Investimento
{
    public double CalcularLucro(double valorInvestido)
    {
        int escolhido = new Random().Next(101);

        if(escolhido <= 20)
            return valorInvestido * 0.05;
        else if(escolhido > 20 && escolhido <= 50)
            return valorInvestido * 0.03;
        else
            return valorInvestido * 0.006;
    }
}