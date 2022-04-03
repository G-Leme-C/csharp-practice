public class Conta {

    public EstadoDeConta Estado { get; set; } = new Positivo();
    public decimal Saldo { get; private set; }   

    public void Depositar(decimal valor) {
        Saldo += (valor * Estado.PercentualDeposito());

        if(Saldo > 0)
            Estado = new Positivo();
    }

    public void Sacar(decimal valor) {
        if(Estado.PermiteSaque()) {
            Saldo -= valor;
            if(Saldo < 0)
                Estado = new Negativo();
        }
    }
}