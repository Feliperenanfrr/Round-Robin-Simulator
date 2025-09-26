namespace RoundRobinSimulator;

public class Processo
{
    public int Id { get; set; }
    public int TempoTotal { get; set; }
    public int TempoRestante { get; set; }
    public int TempoEspera { get; set; }
    public int TempoRetorno { get; set; }
    public bool Finalizado { get; set; }

    public Processo(int id, int tempoTotal)
    {
        Id = id;
        TempoTotal = tempoTotal;
        TempoRestante = tempoTotal;
        TempoEspera = 0;
        TempoRetorno = 0;
        Finalizado = false;
    }

    public override string ToString()
    {
        return $"P{Id} (Total: {TempoTotal}, Restante: {TempoRestante})";
    }
}
