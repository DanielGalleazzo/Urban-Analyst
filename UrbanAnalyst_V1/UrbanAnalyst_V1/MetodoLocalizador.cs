using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace UrbanAnalyst_V1

{
    public static class LocalizacaoService
    {
        public static async Task<(double lat, double lon)> BuscarCoordenadasPorNome(string lugar)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.UserAgent.ParseAdd("UrbanAnalyst/1.0");

            string url =
                $"https://nominatim.openstreetmap.org/search?format=json&q={Uri.EscapeDataString(lugar)}";

            var json = await client.GetStringAsync(url);

            var results = JsonSerializer.Deserialize<List<Cidade>>(json);

            if (results == null || results.Count == 0)
                Console.WriteLine("Lugar não encontrado");

            double latitude = double.Parse(results[0].lat, CultureInfo.InvariantCulture);
            double longitude = double.Parse(results[0].lon, CultureInfo.InvariantCulture);

            return (
                double.Parse(results[0].lat.ToString(), CultureInfo.InvariantCulture),
                double.Parse(results[0].lon.ToString(), CultureInfo.InvariantCulture)
            );
        }

            public static async Task<string> MetodoLocalizador(double latitude, double longitude)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.UserAgent.ParseAdd("UrbanAnalyst/1.0");

            string url =
                $"https://nominatim.openstreetmap.org/reverse?format=json&lat={latitude.ToString(CultureInfo.InvariantCulture)}&lon={longitude.ToString(CultureInfo.InvariantCulture)}";

            var response = await client.GetStringAsync(url);

            var result = JsonSerializer.Deserialize<Localizador>(response);

            return result?.DisplayName ?? "Local não encontrado";
        }
    }
    }
    
    
