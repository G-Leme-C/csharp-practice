public class ICMS : Imposto {
	public ICMS(Imposto outroImposto) : base(outroImposto) { }
	public ICMS() { }

	public override double Calcula(Orcamento orcamento) {
		return ((orcamento.Valor * 0.05) + 50) + CalculaOutroImposto(orcamento);
	}


}