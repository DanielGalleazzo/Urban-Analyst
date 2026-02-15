using System.Text.Json.Serialization;

public class Cidade
{
    public string lat { get; set; }
    public string lon { get; set; }

    [JsonPropertyName("display_name")]
    public string DisplayName { get; set; }
}