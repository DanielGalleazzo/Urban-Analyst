using UrbanAnalyst_V1;
using UrbanMobilityAnalyzer.Services;



class program
{
    static async Task Main(string[] args)
    {
        var loader = new CsvLoader();

        var points = loader.Load("C:\\Users\\danie\\Downloads\\CentroFariaV4.csv");

        Console.WriteLine($"Cordenadas carregadas: {points.Count}");

        foreach (var p in points.Take(3))
        {
            Console.WriteLine($"{p.Localizacao} | {p.Latitude} | {p.Longitude}");
            //var lugar = await LocalizacaoService.MetodoLocalizador(p.Latitude, p.Longitude);
            Console.WriteLine("-----");
            Console.WriteLine("Localização das coordenadas");
           
        }
       
    }
}