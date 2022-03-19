public class FormatadorDeConta {
    public string FormatarConta(Conta conta, Formato formato) {

        IFormatador formatador = new FormataXML(new FormataCSV(new FormataPipe(null)));

        return formatador.Formatar(conta, formato);
    }
}