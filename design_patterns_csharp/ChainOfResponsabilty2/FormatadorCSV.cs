public class FormataCSV : IFormatador
{
    public IFormatador ProximoFormatador { get; set; }

    public FormataCSV(IFormatador proximoFormato)
    {
        ProximoFormatador = proximoFormato;
    }

    public string Formatar(Conta conta, Formato formato)
    {
        if(formato == Formato.CSV) {
            return $"{conta.NomeTitular};{conta.Saldo};";
        }

        return ProximoFormatador.Formatar(conta, formato);
    }
}