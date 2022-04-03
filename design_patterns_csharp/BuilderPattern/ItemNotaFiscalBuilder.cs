public class ItemNotaFiscalBuilder {

    private string Descricao { get; set; }
    private double Valor { get; set; }

    public ItemNotaFiscalBuilder ComDescricao(string descricao) {
        Descricao = descricao;

        return this;
    }

    public ItemNotaFiscalBuilder ComValor(double valor) {
        Valor = valor;

        return this;
    }

    public ItemNotaFiscal ToItemNotaFiscal() {
        return new ItemNotaFiscal(Descricao, Valor);
    }
}
