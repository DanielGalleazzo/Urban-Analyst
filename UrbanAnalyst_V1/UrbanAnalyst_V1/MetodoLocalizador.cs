using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace UrbanAnalyst_V1

{
    public static class LocalizacaoService
    {
        public static async Task<string> MetodoLocalizador(double latitude, double longitude)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.UserAgent.ParseAdd("MeuAppCSharp/1.0");
            string url = $"https://nominatim.openstreetmap.org/reverse?format=json&lat={latitude}&lon={longitude}";
            var response = await client.GetStringAsync(url);
            var result = JsonSerializer.Deserialize<Localizador>(response); 
            return result?.DisplayName ?? "Local não encontrado";
        }
    }
}