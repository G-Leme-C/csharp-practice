public abstract class Imposto {
	private Imposto _outroImposto;
	public Imposto(Imposto outroImposto)
	{
		_outroImposto = outroImposto;
	}
	public Imposto() { }

	public abstract double Calcula(Orcamento orcamento);

	protected double CalculaOutroImposto(Orcamento orcamento)
    {
        if(_outroImposto != null)
			return _outroImposto.Calcula(orcamento);
		else
			return 0;
    }
	
}