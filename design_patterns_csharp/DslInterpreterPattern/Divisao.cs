class Divisao : IExpressao
{
    private IExpressao esquerda;
    private IExpressao direita;

    public Divisao(IExpressao esquerda, IExpressao direita)
    {
        this.esquerda = esquerda;
        this.direita = direita;
    }

    public int Avalia()
    {
        var vlEsquerda = esquerda.Avalia();
        var vlDireita = direita.Avalia();
        return vlEsquerda / vlDireita;
    }
}