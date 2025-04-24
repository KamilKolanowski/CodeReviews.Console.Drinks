using Drinks.KamilKolanowski.Models;
using Drinks.KamilKolanowski.Services;
using Spectre.Console;

namespace Drinks.KamilKolanowski.Controllers;

internal class DrinksController
{
    CreateDrinkDetails createDrinkDetails = new ();
    
    internal async Task CreateDrinksList(string drinkType)
    {
        var drinks = await createDrinkDetails.CreateListOfDrinks(drinkType);
        
        var selectedDrink = AnsiConsole.Prompt(
            new SelectionPrompt<Drink>()
                .Title("[gold3_1]Select Drink from the list[/]")
                .AddChoices(drinks)
                .UseConverter(drink => drink.StrDrink)
        );
        
        var details = await createDrinkDetails.CreateListOfDrinkDetails(selectedDrink.IdDrink);

        await createDrinkDetails.CreateTable(selectedDrink.StrDrink, details);
    }
}