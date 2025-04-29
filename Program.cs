using DesignPatterns.Builder.Avancado;
using DesignPatterns.Builder.Simples;

Console.WriteLine("================================================");
Console.WriteLine("=== Exemplo de Uso do Padrão Builder Simples ===");
Console.WriteLine("================================================");

Console.WriteLine("\n---------[ Simples: Computador Básico ]---------\n");

var computadorBasico = new ComputadorSimples
    .ComputadorSimplesBuilder("ASUS Prime B450M", "AMD Ryzen 5 3600")
    .Build();

computadorBasico.MostrarConfiguracoes();

Console.WriteLine("\n-----[ Simples: Computador Gamer Completo ]-----\n");
var computadorGamer = new ComputadorSimples
    .ComputadorSimplesBuilder("ASUS ROG Strix Z490", "Intel Core i7 10700K")
    .ComMemoriaRAM("32GB DDR4 3200MHz")
    .ComArmazenamento("1TB SSD NVMe")
    .ComPlacaVideo("NVIDIA RTX 3080")
    .ComFonte("Corsair RM850x 850W")
    .Build();

computadorGamer.MostrarConfiguracoes();

Console.WriteLine();
Console.WriteLine("=================================================");
Console.WriteLine("=== Exemplo de Uso do Padrão Builder Avançado ===");
Console.WriteLine("=================================================");
Console.WriteLine();

// Método 1: Usando apenas o Builder
Console.WriteLine("--------[ Construção Direta com Builder ]--------\n");

var builder1 = new ComputadorAvancadoBuilder("ASUS ROG Strix Z690", "Intel Core i9-12900K");
var pcGamer = builder1
    .ComMemoriaRAM("32GB DDR5")
    .ComArmazenamento("2TB NVMe SSD")
    .ComPlacaVideo("RTX 4090")
    .ComFonte("1200W Platinum")
    .AdicionarPeriferico("Monitor OLED 4K 240Hz")
    .AdicionarPeriferico("Headset 7.1")
    .Build();
pcGamer.MostrarConfiguracoes();

// Método 2: Usando o Diretor para configurações padrão
Console.WriteLine("\n-----------[ Construção com Director ]-----------\n");
var builder2 = new ComputadorAvancadoBuilder("Gigabyte B660", "Intel Core i5-12400");
var director = new ComputadorDirector(builder2);

director.ConstruirComputadorEscritorio();
var pcEscritorio = builder2.Build();
pcEscritorio.MostrarConfiguracoes();

// Método 3: Combinando Director com customização
Console.WriteLine("\n----[ Construção Híbrida (Director + Custom) ]---\n");
var builder3 = new ComputadorAvancadoBuilder("MSI MPG X570", "AMD Ryzen 9 5950X");
director = new ComputadorDirector(builder3);

director.ConstruirEstacaoTrabalho();
var estacaoTrabalho = builder3
    .AdicionarPeriferico("Webcam 4K")
    .AdicionarPeriferico("Microfone Studio")
    .Build();
estacaoTrabalho.MostrarConfiguracoes();

// Método 4: Tratamento de erros
Console.WriteLine("\n#########< Tratamento de Erros >#########\n");
try
{
    var builder4 = new ComputadorAvancadoBuilder("ASRock B550", "AMD Ryzen 7 5800X");
    var pcInvalido = builder4
        .ComPlacaVideo("RTX 3070")
        // Esqueceu de adicionar a fonte
        .Build();
}
catch (InvalidOperationException ex)
{
    Console.WriteLine($"Erro na construção: {ex.Message}");
}
Console.ReadKey();




