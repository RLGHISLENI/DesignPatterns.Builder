namespace DesignPatterns.Builder.Avancado;

// Diretor (opcional - para configurações pré-definidas)
public class ComputadorDirector
{
    private readonly IComputadorAvancadoBuilder _builder;

    public ComputadorDirector(IComputadorAvancadoBuilder builder)
    {
        _builder = builder;
    }

    public void ConstruirComputadorEscritorio()
    {
        _builder
            .ComMemoriaRAM("8GB DDR4")
            .ComArmazenamento("256GB SSD")
            .ComFonte("300W");
    }

    public void ConstruirComputadorGamer()
    {
        _builder
            .ComMemoriaRAM("32GB DDR4 3200MHz")
            .ComArmazenamento("1TB NVMe SSD")
            .ComPlacaVideo("RTX 3080 Ti")
            .ComFonte("850W Gold")
            .AdicionarPeriferico("Teclado Mecânico")
            .AdicionarPeriferico("Mouse Gamer");
    }

    public void ConstruirEstacaoTrabalho()
    {
        _builder
            .ComMemoriaRAM("64GB DDR4 ECC")
            .ComArmazenamento("2TB NVMe SSD + 4TB HDD")
            .ComPlacaVideo("NVIDIA Quadro RTX 5000")
            .ComFonte("1000W Platinum")
            .AdicionarPeriferico("Monitor 4K 32\"")
            .AdicionarPeriferico("Tablet Digitalizador");
    }
}