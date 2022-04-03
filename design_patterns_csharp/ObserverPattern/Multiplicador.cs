public class Multiplicador : AcaoNotaFiscal {

    public double Fator { get; set; }
    
    public Multiplicador(double fator)
    {
        Fator = fator;
    }

    public void Executa(NotaFiscal notaFiscal) {
        Console.WriteLine($"Multiplicando valor da nota por {Fator}: {notaFiscal.ValorBruto * Fator}");
    }
}