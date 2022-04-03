public class Positivo : EstadoDeConta {

    public bool PermiteSaque() {
        return true;
    }
    public decimal PercentualDeposito() {
        return 0.98m;
    }

}