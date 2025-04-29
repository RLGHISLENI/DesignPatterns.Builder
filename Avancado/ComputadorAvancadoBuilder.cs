namespace DesignPatterns.Builder.Avancado;

public class ComputadorAvancadoBuilder : IComputadorAvancadoBuilder
{
    private readonly string _placaMae;
    private readonly string _processador;
    private readonly List<string> _perifericos = [];

    private string? _memoriaRAM;
    private string? _armazenamento;
    private string? _placaVideo;
    private string? _fonte;

    // Construtor com parâmetros obrigatórios
    public ComputadorAvancadoBuilder(string placaMae, string processador)
    {
        if (string.IsNullOrEmpty(placaMae) || string.IsNullOrEmpty(processador))
            throw new ArgumentException("Placa-mãe e processador são obrigatórios");

        _placaMae = placaMae;
        _processador = processador;
    }

    // Métodos de construção
    public IComputadorAvancadoBuilder ComMemoriaRAM(string memoriaRAM)
    {
        _memoriaRAM = memoriaRAM;
        return this;
    }

    public IComputadorAvancadoBuilder ComArmazenamento(string armazenamento)
    {
        _armazenamento = armazenamento;
        return this;
    }

    public IComputadorAvancadoBuilder ComPlacaVideo(string placaVideo)
    {
        _placaVideo = placaVideo;
        return this;
    }

    public IComputadorAvancadoBuilder ComFonte(string fonte)
    {
        _fonte = fonte;
        return this;
    }

    public IComputadorAvancadoBuilder ComPerifericos(List<string> perifericos)
    {
        if (perifericos != null)
            _perifericos.AddRange(perifericos);
        return this;
    }

    public IComputadorAvancadoBuilder AdicionarPeriferico(string periferico)
    {
        if (!string.IsNullOrEmpty(periferico))
            _perifericos.Add(periferico);
        return this;
    }

    // Método de construção final
    public ComputadorAvancado Build()
    {
        // Validações podem ser adicionadas aqui  
        if (string.IsNullOrEmpty(_fonte) && !string.IsNullOrEmpty(_placaVideo))
            throw new InvalidOperationException("Computadores com placa de vídeo dedicada requerem fonte específica");

        // Garantir que os valores nulos sejam substituídos por valores padrão para evitar erros de referência nula  
        return new ComputadorAvancado(
            _placaMae,
            _processador,
            _memoriaRAM ?? string.Empty,
            _armazenamento ?? string.Empty, 
            _placaVideo ?? string.Empty,
            _fonte ?? string.Empty, 
            _perifericos ?? []
        );
    }
}
