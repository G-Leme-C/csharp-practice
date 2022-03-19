public class IMA : Imposto
{
    public IMA(Imposto outroImposto) : base(outroImposto) { }
    public IMA() { }

    public override double Calcula(Orcamento orcamento)
    {
        return orcamento.Valor * 0.2;
    }
}