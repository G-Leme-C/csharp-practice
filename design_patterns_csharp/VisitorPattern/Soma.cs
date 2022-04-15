public class Soma : IExpressao 
{

    public IExpressao Esquerda { get; private set; }
    public IExpressao Direita { get; private set; }

    public Soma(IExpressao esquerda, IExpressao direita) 
    {
        this.Esquerda = esquerda;
        this.Direita = direita;
    }

    public void AceitaVisitor(IVisitor impressora)
    {
        impressora.ImprimeSoma(this);
    }

    public int Avalia() 
    {
        int resultadoDaEsquerda = Esquerda.Avalia();
        int resultadoDaDireita = Direita.Avalia();
        return resultadoDaEsquerda + resultadoDaDireita;
    }
}