Conta conta1 = new Conta("nome titular", 1000);

Requisicao req1 = new Requisicao(Formato.XML);
Requisicao req2 = new Requisicao(Formato.CSV);
Requisicao req3 = new Requisicao(Formato.PIPE);

FormatadorDeConta formatador = new FormatadorDeConta();

Console.WriteLine(formatador.FormatarConta(conta1, req1.Formato));
Console.WriteLine(formatador.FormatarConta(conta1, req2.Formato));
Console.WriteLine(formatador.FormatarConta(conta1, req3.Formato));
