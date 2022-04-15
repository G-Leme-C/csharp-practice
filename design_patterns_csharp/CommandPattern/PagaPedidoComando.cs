
public class PagaPedidoComando : IComando 
{
    private Pedido pedido;

    public PagaPedidoComando(Pedido pedido)
    {
        this.pedido = pedido;
    }

    public void Executa() 
    {
        Console.WriteLine($"Pagando pedido do cliente {pedido.Cliente}");
        pedido.Paga();
    }
}