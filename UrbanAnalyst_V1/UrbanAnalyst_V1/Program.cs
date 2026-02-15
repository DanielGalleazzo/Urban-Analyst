using UrbanAnalyst_V1;
using System.Globalization;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Digite o nome do lugar:");
        string nome = Console.ReadLine();
        var (lat, lon) = await LocalizacaoService.BuscarCoordenadasPorNome(nome);
        Console.WriteLine($"Coordenadas encontradas: {lat}, {lon}");
        var endereco = await LocalizacaoService.MetodoLocalizador(lat, lon);
        Console.WriteLine($"Endereço completo:");
        Console.WriteLine(endereco);

    }
}
