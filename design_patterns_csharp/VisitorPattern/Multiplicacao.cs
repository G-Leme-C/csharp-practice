public class Multiplicacao : IExpressao 
{

    public IExpressao Esquerda { get; private set; }
    public IExpressao Direita { get; private set; }

    public Multiplicacao(IExpressao esquerda, IExpressao direita) 
    {
        this.Esquerda = esquerda;
        this.Direita = direita;
    }

    public void AceitaVisitor(IVisitor impressora)
    {
        impressora.ImprimeMultiplicacao(this);
    }

    public int Avalia() 
    {
        int resultadoDaEsquerda = Esquerda.Avalia();
        int resultadoDaDireita = Direita.Avalia();
        return resultadoDaEsquerda * resultadoDaDireita;
    }
}