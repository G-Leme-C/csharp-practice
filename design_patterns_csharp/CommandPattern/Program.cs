Pedido pedido1 = new Pedido("Mauricio", 150.0);
Pedido pedido2 = new Pedido("Marcelo", 250.0);

FilaDeTrabalho fila = new FilaDeTrabalho();

fila.Adiciona(new PagaPedidoComando(pedido1));
fila.Adiciona(new PagaPedidoComando(pedido2));
fila.Adiciona(new FinalizaPedidoComando(pedido1));

fila.Processa();