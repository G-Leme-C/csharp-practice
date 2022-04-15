public class ImpressoraPreFixoVisitor : IVisitor
{
    public void ImprimeSoma(Soma soma) {
        Console.Write("(");
        Console.Write(" + ");
        soma.Esquerda.AceitaVisitor(this);
        soma.Direita.AceitaVisitor(this);
        Console.Write(")");
    }

    public void ImprimeSubtracao(Subtracao subtracao) {
        Console.Write("(");
        Console.Write(" - ");
        subtracao.Esquerda.AceitaVisitor(this);
        subtracao.Direita.AceitaVisitor(this);
        Console.Write(")");
    }

    public void ImprimeDivisao(Divisao divisao) {
        Console.Write("(");
        Console.Write(" / ");
        divisao.Esquerda.AceitaVisitor(this);
        divisao.Direita.AceitaVisitor(this);
        Console.Write(")");
    }

    public void ImprimeMultiplicacao(Multiplicacao multiplicacao) {

        Console.Write("(");
        Console.Write(" * ");
        multiplicacao.Esquerda.AceitaVisitor(this);
        multiplicacao.Direita.AceitaVisitor(this);
        Console.Write(")");
    }

    public void ImprimeNumero(Numero numero) {
        Console.Write(numero.Valor);
    }

}