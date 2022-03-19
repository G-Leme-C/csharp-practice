public class CalculadorDeDesconto {
    public double CalcularDesconto(Orcamento orcamento) {
        
        Desconto desconto1 = new DescontoMaisDeCincoItens();
        Desconto desconto2 = new DescontoValorCompra();
        Desconto desconto3 = new DescontoVendaCasada();

        Desconto semDesconto = new SemDesconto();
        desconto1.ProximoDesconto = desconto2;
        desconto2.ProximoDesconto = desconto3;
        desconto3.ProximoDesconto = semDesconto;

        return desconto1.CalcularDesconto(orcamento);
    }
}