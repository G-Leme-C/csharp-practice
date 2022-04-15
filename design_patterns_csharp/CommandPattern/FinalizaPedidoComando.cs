public class FinalizaPedidoComando : IComando 
{
    private Pedido pedido;

    public FinalizaPedidoComando(Pedido pedido) 
    {
        this.pedido = pedido;
    }

    public void Executa() 
    {
        Console.WriteLine($"Finalizando pedido do cliente {pedido.Cliente}");
        pedido.Finaliza();
    }
}