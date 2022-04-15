public class Pedido 
{
    public String Cliente { get; private set; }
    public double Valor  { get; private set; }
    public Status Status  { get; private set; }
    public DateTime DataFinalizacao { get; private set; }

    public Pedido(String cliente, double valor) 
    {
        this.Cliente = cliente;
        this.Valor = valor;
        this.Status = Status.Novo;
    }

    public void Paga() 
    {
        this.Status = Status.Pago;
    }

    public void Finaliza() 
    {
        DataFinalizacao = DateTime.Now;
        Status = Status.Entregue;
    }
}

public enum Status 
{
    Novo,
    Processado,
    Pago,
    ItemSeparado,
    Entregue
}