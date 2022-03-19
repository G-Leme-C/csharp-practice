public class Conta {
    public string Titular { get; private set; } 
    public string Agencia { get; private set; }
    public string NumeroConta { get; private set; }
    public double Saldo { get; private set; }
    
    public Conta(string titular, string agencia, string numeroConta, double saldo)
    {
        Titular = titular;
        Agencia = agencia;
        NumeroConta = numeroConta;
        Saldo = saldo;
    }

    public void Depositar(double valor) {
        Saldo += valor;
    }

    public void Sacar(double valor) {
        Saldo -= valor;
    }

}