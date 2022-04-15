public class ImpressoraVisitor : IVisitor
{
    public void ImprimeSoma(Soma soma) {
        Console.Write("(");
        soma.Esquerda.AceitaVisitor(this);
        Console.Write(" + ");
        soma.Direita.AceitaVisitor(this);
        Console.Write(")");
    }

    public void ImprimeSubtracao(Subtracao subtracao) {
        Console.Write("(");
        subtracao.Esquerda.AceitaVisitor(this);
        Console.Write(" - ");
        subtracao.Direita.AceitaVisitor(this);
        Console.Write(")");
    }

    public void ImprimeDivisao(Divisao divisao) {
        Console.Write("(");
        divisao.Esquerda.AceitaVisitor(this);
        Console.Write(" / ");
        divisao.Direita.AceitaVisitor(this);
        Console.Write(")");
    }

    public void ImprimeMultiplicacao(Multiplicacao multiplicacao) {

        Console.Write("(");
        multiplicacao.Esquerda.AceitaVisitor(this);
        Console.Write(" * ");
        multiplicacao.Direita.AceitaVisitor(this);
        Console.Write(")");
    }

    public void ImprimeNumero(Numero numero) {
        Console.Write(numero.Valor);
    }

}