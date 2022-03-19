public class FormataXML : IFormatador
{
    public IFormatador ProximoFormatador { get; set; }

    public FormataXML(IFormatador proximoFormato)
    {
        this.ProximoFormatador = proximoFormato;
    }

    public string Formatar(Conta conta, Formato formato)
    {
        if(formato == Formato.XML) {
            return $"<conta><nome>{conta.NomeTitular}</nome><saldo>{conta.Saldo}</saldo></conta>";
        }

        return ProximoFormatador.Formatar(conta, formato);
    }
}