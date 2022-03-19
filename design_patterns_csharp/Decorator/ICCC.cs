public class ICCC : Imposto {

	public ICCC(Imposto outroImposto) : base(outroImposto) { }
	public ICCC() { }

	public override double Calcula(Orcamento orcamento) {
		double imposto = 0;

		if(orcamento.Valor < 1000) {
			imposto = orcamento.Valor * 0.05;
		}
		else if(orcamento.Valor >= 1000 && orcamento.Valor <= 3000) {
			imposto = orcamento.Valor * 0.07;
		}
		else {
			imposto = (orcamento.Valor * 0.08) + 30;
		}

		return imposto + CalculaOutroImposto(orcamento);
	}
}