using EstadosOrcamento;

public class Orcamento {

	public EstadoDeOrcamento EstadoDoOrcamento { get; set; } = new EmAprovacao();
	public double Valor { get; set; }

	public Orcamento(double valor) {
		Valor = valor;
	}

	public void AplicaDescontoExtra() {
		EstadoDoOrcamento.AplicaDesconto(this);
	}

	public void Aprovar() {
		EstadoDoOrcamento.Aprovar(this);
	}
	
	public void Reprovar() {
		EstadoDoOrcamento.Reprovar(this);
	}
	
	public void Finalizar() {
		EstadoDoOrcamento.Finalizar(this);
	}
}