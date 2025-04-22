namespace Drinks.KamilKolanowski.Services;

public class DataGetter
{
    private static readonly HttpClient sharedClient = new()
    {
        BaseAddress = new Uri("https://www.thecocktaildb.com/api/json/v1/1/"),
    };

    internal async Task GetAsyncData(string uri)
    {
        await GetAsync(sharedClient, uri);
    }

    internal async Task GetAsync(HttpClient client, string uri)
    {
        using HttpResponseMessage response = await client.GetAsync(uri);

        response.EnsureSuccessStatusCode().WriteRequestToConsole();

        var jsonResponse = await response.Content.ReadAsStringAsync();
        Console.WriteLine($"Response: {jsonResponse}");
    }
}

static class HttpResponseMessageExtensions
{
    internal static void WriteRequestToConsole(this HttpResponseMessage response)
    {
        if (response is null)
        {
            return;
        }

        var request = response.RequestMessage;
        Console.Write($"{request?.Method} ");
        Console.Write($"{request?.RequestUri} ");
        Console.WriteLine($"HTTP/{request?.Version}");
    }
}
