public class RealizadorDeInvestimento {
    public double RealizarInvestimento(ContaBancaria conta, Investimento investimento) {
        return investimento.CalcularLucro(conta.Saldo);
    }
}