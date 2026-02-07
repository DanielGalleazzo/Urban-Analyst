using UrbanMobilityAnalyzer.Services;

var loader = new CsvLoader();

var points = loader.Load("C:\\Users\\danie\\Desktop\\TesteCSV.csv");

Console.WriteLine($"Pontos carregados: {points.Count}");

foreach (var p in points.Take(3))
{
    Console.WriteLine($"{p.Timestamp} | {p.Latitude} | {p.Longitude}");
}
