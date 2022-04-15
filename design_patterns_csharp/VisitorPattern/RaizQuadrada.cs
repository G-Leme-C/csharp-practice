class RaizQuadrada : IExpressao
{
    private IExpressao valor;

    public RaizQuadrada(IExpressao valor)
    {
        this.valor = valor;
    }

    public void AceitaVisitor(IVisitor visitor)
    {
        throw new NotImplementedException();
    }

    public int Avalia()
    {
        return (int)Math.Sqrt(valor.Avalia());
    }
}