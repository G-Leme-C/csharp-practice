public class ItemNotaFiscal {
    public string Descricao { get; set; }
    public double Valor { get; set; }
    public ItemNotaFiscal(string descricao, double valor)
    {
        Descricao = descricao;
        Valor = valor;
    }
}