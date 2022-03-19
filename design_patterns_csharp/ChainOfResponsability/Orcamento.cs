public class Orcamento {
    public double Valor { get; private set; }
    public List<Item> Itens { get; private set; }
    public Orcamento()
    {
        Valor = 0;
        Itens = new List<Item>();
    }

    public void AdicionarItem(Item item) {
        Itens.Add(item);
        Valor += item.Valor;
    }
}