public class Conta {
    public double Saldo { get; set; }
    public DateTime DataCriacaoConta { get; set; }

    public Conta(double saldo, DateTime dataCriacaoConta)
    {
        Saldo = saldo;
        DataCriacaoConta = dataCriacaoConta;
    }
}