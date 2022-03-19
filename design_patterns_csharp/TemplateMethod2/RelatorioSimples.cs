public class RelatorioSimples : TemplateRelatorio
{
    public override void ImprimirCabecalho()
    {
        Console.WriteLine("Banco Alura");
    }

    public override void ImprimirListaContas(List<Conta> contas)
    {
        foreach(var conta in contas) {
            Console.WriteLine($"{conta.Titular}|{conta.Saldo}");
        }
    }

    public override void ImprimirRodape()
    {
        Console.WriteLine("0800 000 999 12");
    }
}