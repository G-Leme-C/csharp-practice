public interface IFormatador 
{
    public IFormatador ProximoFormatador { get; set; }
    public string Formatar(Conta conta, Formato formato);
}