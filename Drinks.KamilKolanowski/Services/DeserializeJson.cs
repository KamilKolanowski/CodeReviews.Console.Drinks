using System.Text.Json;

namespace Drinks.KamilKolanowski.Services;

internal class DeserializeJson
{
    internal async Task<T> DeserializeAsync<T>(string json)
    {
        return await Task.FromResult(JsonSerializer.Deserialize<T>(json));
    }
}