NotaFiscalBuilder notaFiscalBuilder = new NotaFiscalBuilder();

var nf = notaFiscalBuilder
    .ComRazaoSocial("Fulano de Tal LTDA")
    .ComCNPJ("01.563.557/0001-01")
    .NaData(new DateTime(2022, 04, 03, 16, 45, 00))
    .ComObservacoes("Observações")
    .ComItem(new ItemNotaFiscal("PEÇA 1", 100))
    .ComItem(new ItemNotaFiscal("PEÇA 2", 200))
    .AdicionarAcaoAposNF(new EnviaNFEmailAcao())
    .AdicionarAcaoAposNF(new SalvaNFBdAcao())
    .AdicionarAcaoAposNF(new EnviaNFSMSAcao())
    .AdicionarAcaoAposNF(new Multiplicador(5))
    .ToNotaFiscal();