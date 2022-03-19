public class Conta {
    public string NomeTitular { get; set; }
    public double Saldo { get; set; }

    public Conta(string nomeTitular, double saldo)
    {
        this.NomeTitular = nomeTitular;
        this.Saldo = saldo;
    }
}