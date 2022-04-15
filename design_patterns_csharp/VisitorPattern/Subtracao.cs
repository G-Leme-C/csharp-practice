public class Subtracao : IExpressao 
{

    public IExpressao Esquerda { get; private set; }
    public IExpressao Direita { get; private set; }

    public Subtracao(IExpressao esquerda, IExpressao direita) 
    {
        this.Esquerda = esquerda;
        this.Direita = direita;

    }

    public void AceitaVisitor(IVisitor impressora)
    {
        impressora.ImprimeSubtracao(this);
    }

    public int Avalia() 
    {
        int resultadoDaEsquerda = Esquerda.Avalia();
        int resultadoDaDireita = Direita.Avalia();
        return resultadoDaEsquerda - resultadoDaDireita;
    }
}
