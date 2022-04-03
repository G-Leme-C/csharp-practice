public class NotaFiscalBuilder {
    private string RazaoSocial { get; set; }   
    private string CNPJ { get; set; }   
    private double ValorBruto { get; set; }
    private double ValorImpostos { get; set; }
    private DateTime DataDeEmissao { get; set; } = DateTime.Now;
    private string Observacoes { get; set; }
    private List<ItemNotaFiscal> ItensNF { get; set; } = new List<ItemNotaFiscal>();


    private List<AcaoNotaFiscal> acoesNotaFiscal = new List<AcaoNotaFiscal>();

    public NotaFiscalBuilder AdicionarAcaoAposNF(AcaoNotaFiscal acao) {
        acoesNotaFiscal.Add(acao);

        return this;
    }

    private void ExecutaAcoes(NotaFiscal nota) {
        foreach(AcaoNotaFiscal acao in acoesNotaFiscal) {
            acao.Executa(nota);
        }
    }

    public NotaFiscalBuilder ComRazaoSocial(string razaoSocial) {
        this.RazaoSocial = razaoSocial;

        return this;
    }
    public NotaFiscalBuilder ComCNPJ(string cnpj) {
        this.CNPJ = cnpj;

        return this;
    }
    public NotaFiscalBuilder ComItem(ItemNotaFiscal item) {
        ItensNF.Add(item);

        ValorBruto += item.Valor;
        ValorImpostos += (item.Valor * 0.05);

        return this;
    }
    public NotaFiscalBuilder NaData(DateTime data) {
        DataDeEmissao = data;
        
        return this;
    }
    public NotaFiscalBuilder ComObservacoes(string observacoes) {
        this.Observacoes = observacoes;

        return this;
    }
    public NotaFiscal ToNotaFiscal() {
        var nf = new NotaFiscal(this.RazaoSocial, this.CNPJ, this.ValorBruto, this.ValorImpostos, this.DataDeEmissao,
            this.Observacoes, this.ItensNF);

        ExecutaAcoes(nf);

        return nf;
    }


}