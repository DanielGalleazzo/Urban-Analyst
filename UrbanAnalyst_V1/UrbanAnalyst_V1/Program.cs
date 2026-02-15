using UrbanAnalyst_V1;
using System.Globalization;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Digite o nome do local:");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite a latitude ");
        string latText = Console.ReadLine();
        Console.WriteLine("Digite a longitude");
        string lonText = Console.ReadLine();

        if (
            double.TryParse(latText, NumberStyles.Any, CultureInfo.InvariantCulture, out double lat) &&
            double.TryParse(lonText, NumberStyles.Any, CultureInfo.InvariantCulture, out double lon)
        )
        {
            Console.WriteLine("Buscando localização real...");
            var lugar = await LocalizacaoService.MetodoLocalizador(lat, lon);
            Console.WriteLine($"Nome digitado: {nome}");
            Console.WriteLine($"Local encontrado: {lugar}");
        }
        else
        {
            Console.WriteLine("Latitude ou longitude inválidas.");
        }
        Console.ReadLine();
    }
}
