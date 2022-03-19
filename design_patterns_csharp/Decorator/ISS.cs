public class ISS : Imposto {

	public ISS(Imposto outroImposto) : base(outroImposto) { }
	public ISS() { }

	public override double Calcula(Orcamento orcamento) {
		return (orcamento.Valor * 0.06) + CalculaOutroImposto(orcamento);
	}
}