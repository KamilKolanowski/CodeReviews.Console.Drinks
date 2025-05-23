using Drinks.KamilKolanowski.Models;
using Spectre.Console;

namespace Drinks.KamilKolanowski.Services;

internal class CreateDrinkDetails
{
    DrinkDataFetcher drinkDataFetcher = new();
    DeserializeJson deserializeJson = new();
    
    internal async Task CreateTable(string drinkName, List<Details> drink)
    {
        var table = new Table();
        table.AddColumn($"[red]{drinkName}[/]");
        table.AddColumn("[red]Details[/]");

        
        var detail = drink.FirstOrDefault();
        if (detail != null)
        {
            table.AddRow("[deeppink2]Drink Id[/]", detail.IdDrink);
            table.AddRow("[deeppink2]Drink Name[/]", detail.StrDrink);
            table.AddRow("[deeppink2]Category[/]", detail.StrCategory);
            table.AddRow("[deeppink2]Alcoholic[/]", detail.StrAlcoholic);
            table.AddRow("[deeppink2]Glass[/]", detail.StrGlass);
            table.AddRow("[deeppink2]Instructions[/]", detail.StrInstructions);

            for (int i = 1; i <= 15; i++)
            {
                var ingredient = detail.GetType().GetProperty($"strIngredient{i}")?.GetValue(detail) as string;
                var measure = detail.GetType().GetProperty($"strMeasure{i}")?.GetValue(detail) as string;

                if (!string.IsNullOrWhiteSpace(ingredient))
                    table.AddRow($"[deeppink2]Ingredient {i}[/]", string.IsNullOrWhiteSpace(measure) ? ingredient : $"{measure.Trim()} {ingredient.Trim()}");
            }
        }

        table.Border(TableBorder.Rounded);
        AnsiConsole.Write(table);
        AnsiConsole.MarkupLine("[grey50]Press any key to go back.[/]");
    }

    internal async Task<List<Drink>> CreateListOfDrinks(string drinkType)
    {
        string response = await drinkDataFetcher.GetAsync($"filter.php?c={drinkType}");
        
        DrinksCategory? drinkCategory = await deserializeJson.DeserializeAsync<DrinksCategory>(response);
        return drinkCategory?.Drinks;
    }
    
    internal async Task<List<Details>> CreateListOfDrinkDetails(string drinkId)
    {
        string response = await drinkDataFetcher.GetAsync($"lookup.php?i={drinkId}");
        
        DrinkDetails? drinkDetails = await deserializeJson.DeserializeAsync<DrinkDetails>(response);
        return drinkDetails?.Drinks;
    }
}
