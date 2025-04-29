namespace DesignPatterns.Builder.Avancado;

public class ComputadorAvancado
{
    // Propriedades (todas readonly para imutabilidade)
    public string PlacaMae { get; }
    public string Processador { get; }
    public string MemoriaRAM { get; }
    public string Armazenamento { get; }
    public string PlacaVideo { get; }
    public string Fonte { get; }
    public List<string> Perifericos { get; }

    // Construtor interno (só o Builder pode criar)
    internal ComputadorAvancado(
        string placaMae, string processador, string memoriaRAM,
        string armazenamento, string placaVideo, string fonte,
        List<string> perifericos)
    {
        PlacaMae = placaMae;
        Processador = processador;
        MemoriaRAM = memoriaRAM;
        Armazenamento = armazenamento;
        PlacaVideo = placaVideo;
        Fonte = fonte;
        Perifericos = perifericos ?? [];
    }

    public void MostrarConfiguracoes()
    {
        Console.WriteLine($"Placa Mãe: {PlacaMae}");
        Console.WriteLine($"Processador: {Processador}");
        Console.WriteLine($"Memória RAM: {MemoriaRAM ?? "**** Não instalada"}");
        Console.WriteLine($"Armazenamento: {Armazenamento ?? "**** Não instalado"}");
        Console.WriteLine($"Placa de Vídeo: {PlacaVideo ?? "**** Não instalada"}");
        Console.WriteLine($"Fonte: {Fonte ?? "**** Não instalada"}");

        if (Perifericos.Count > 0)
        {
            Console.WriteLine("Periféricos:");
            foreach (var item in Perifericos)
                Console.WriteLine($" - {item}");
        }
    }
}