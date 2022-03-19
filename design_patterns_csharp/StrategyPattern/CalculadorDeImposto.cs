public class CalculadorDeImposto {
	public CalculadorDeImposto() {
	}

	public double CalcularImposto(Orcamento orcamento, Imposto imposto) {
		return imposto.Calcula(orcamento);
	}
}