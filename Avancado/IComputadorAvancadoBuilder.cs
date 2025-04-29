using DesignPatterns.Builder.Avancado;

public interface IComputadorAvancadoBuilder
{
    IComputadorAvancadoBuilder ComMemoriaRAM(string memoriaRAM);
    IComputadorAvancadoBuilder ComArmazenamento(string armazenamento);
    IComputadorAvancadoBuilder ComPlacaVideo(string placaVideo);
    IComputadorAvancadoBuilder ComFonte(string fonte);
    IComputadorAvancadoBuilder ComPerifericos(List<string> perifericos);
    IComputadorAvancadoBuilder AdicionarPeriferico(string periferico);
    ComputadorAvancado Build();
}