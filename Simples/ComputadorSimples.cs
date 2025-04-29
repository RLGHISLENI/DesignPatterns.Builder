namespace DesignPatterns.Builder.Simples;

public sealed class ComputadorSimples
{
    // Propriedades obrigatórias
    public string PlacaMae { get; }
    public string Processador { get; }

    // Propriedades opcionais
    public string? MemoriaRAM { get; set; } 
    public string? Armazenamento { get; set; } 
    public string? PlacaVideo { get; set; }
    public string? Fonte { get; set; }

    // Construtor privado para forçar o uso do Builder
    private ComputadorSimples(string placaMae, string processador)
    {
        PlacaMae = placaMae;
        Processador = processador;
    }

    // Método para exibir as configurações
    public void MostrarConfiguracoes()
    {
        Console.WriteLine($"Placa Mãe: {PlacaMae}");
        Console.WriteLine($"Processador: {Processador}");
        Console.WriteLine($"Memória RAM: {MemoriaRAM ?? "Não instalada"}");
        Console.WriteLine($"Armazenamento: {Armazenamento ?? "Não instalado"}");
        Console.WriteLine($"Placa de Vídeo: {PlacaVideo ?? "Não instalada"}");
        Console.WriteLine($"Fonte: {Fonte ?? "Não instalada"}");
    }

    // Classe Builder Simple interna
    internal class ComputadorSimplesBuilder
    {
        // Propriedades do Builder (espelho da classe Computador)
        private readonly string _placaMae;
        private readonly string _processador;

        private string? _memoriaRAM;
        private string? _armazenamento;
        private string? _placaVideo;
        private string? _fonte;

        // Construtor do Builder com parâmetros obrigatórios
        public ComputadorSimplesBuilder(string placaMae, string processador)
        {
            _placaMae = placaMae;
            _processador = processador;
        }

        // Métodos para configurar as propriedades opcionais
        public ComputadorSimplesBuilder ComMemoriaRAM(string memoriaRAM)
        {
            _memoriaRAM = memoriaRAM;
            return this; // Retorna o próprio builder para encadeamento
        }

        public ComputadorSimplesBuilder ComArmazenamento(string armazenamento)
        {
            _armazenamento = armazenamento;
            return this;
        }

        public ComputadorSimplesBuilder ComPlacaVideo(string placaVideo)
        {
            _placaVideo = placaVideo;
            return this;
        }

        public ComputadorSimplesBuilder ComFonte(string fonte)
        {
            _fonte = fonte;
            return this;
        }

        // Método Build que cria a instância final do Computador
        public ComputadorSimples Build()
        {
            var computador = new ComputadorSimples(_placaMae, _processador)
            {
                MemoriaRAM = _memoriaRAM,
                Armazenamento = _armazenamento,
                PlacaVideo = _placaVideo,
                Fonte = _fonte
            };

            return computador;
        }
    }
}
