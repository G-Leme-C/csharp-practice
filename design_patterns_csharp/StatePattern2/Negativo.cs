public class Negativo : EstadoDeConta {
    public bool PermiteSaque() {
        return false;
    }
    public decimal PercentualDeposito() {
        return 0.95m;
    }
}