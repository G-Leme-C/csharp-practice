public class Divisao : IExpressao
{
    public IExpressao Esquerda { get; private set; }
    public IExpressao Direita { get; private set; }

    public Divisao(IExpressao esquerda, IExpressao direita)
    {
        this.Esquerda = esquerda;
        this.Direita = direita;
    }

    public void AceitaVisitor(IVisitor impressora)
    {
        impressora.ImprimeDivisao(this);
    }

    public int Avalia()
    {
        var vlEsquerda = Esquerda.Avalia();
        var vlDireita = Direita.Avalia();
        return vlEsquerda / vlDireita;
    }
}