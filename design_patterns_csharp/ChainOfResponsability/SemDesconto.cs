public class SemDesconto : Desconto
{
    public Desconto ProximoDesconto { get; set; }

    public double CalcularDesconto(Orcamento orcamento)
    {
        return 0;
    }
}