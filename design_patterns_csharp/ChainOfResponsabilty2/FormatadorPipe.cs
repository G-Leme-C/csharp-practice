public class FormataPipe : IFormatador
{
    public IFormatador ProximoFormatador { get; set; }

    public FormataPipe(IFormatador proximoFormato)
    {
        ProximoFormatador = proximoFormato;
    }

    public string Formatar(Conta conta, Formato formato)
    {
        if(formato == Formato.PIPE) {
            return $"{conta.NomeTitular}|{conta.Saldo}|";
        }

        return ProximoFormatador.Formatar(conta, formato);
    }
}