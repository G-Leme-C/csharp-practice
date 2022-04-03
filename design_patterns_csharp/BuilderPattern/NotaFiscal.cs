public class NotaFiscal {

    public string RazaoSocial { get; set; }   
    public string CNPJ { get; set; }   
    public double ValorBruto { get; set; }
    public double ValorImpostos { get; set; }
    public DateTime DataDeEmissao { get; set; }
    public string Observacoes { get; set; }
    public List<ItemNotaFiscal> ItensNF { get; set; }
    

    public NotaFiscal(string razaoSocial, string cNPJ, double valorBruto, double valorImpostos, DateTime dataDeEmissao, string observacoes, List<ItemNotaFiscal> itensNF)
    {
        RazaoSocial = razaoSocial;
        CNPJ = cNPJ;
        ValorBruto = valorBruto;
        ValorImpostos = valorImpostos;
        DataDeEmissao = dataDeEmissao;
        Observacoes = observacoes;
        ItensNF = itensNF;
    }
}

