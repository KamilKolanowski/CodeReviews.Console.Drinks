namespace Drinks.KamilKolanowski.Services;

internal class DrinkDataFetcher
{
    private static readonly HttpClient sharedClient = new()
    {
        BaseAddress = new Uri("https://www.thecocktaildb.com/api/json/v1/1/"),
    };

    internal async Task<string> GetAsync(string uri)
    {
        using HttpResponseMessage response = await sharedClient.GetAsync(uri);

        response.EnsureSuccessStatusCode();

        var jsonResponse = await response.Content.ReadAsStringAsync();
        return jsonResponse;
    }
}
