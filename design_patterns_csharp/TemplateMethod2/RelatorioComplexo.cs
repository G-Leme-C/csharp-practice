public class RelatorioComplexo : TemplateRelatorio
{
    public override void ImprimirCabecalho()
    {
        Console.WriteLine("Banco Alura | Av. Alura 1999, São Paulo - SP | Telefone: 0800 000 999 12");
    }

    public override void ImprimirListaContas(List<Conta> contas)
    {
        foreach(var conta in contas) {
            Console.WriteLine($"{conta.Titular}|{conta.Agencia}|{conta.NumeroConta}|{conta.Saldo}");
        }
    }

    public override void ImprimirRodape()
    {
        Console.WriteLine($"Contato: alura@alura.com.br | {DateTime.Now}");
    }
}