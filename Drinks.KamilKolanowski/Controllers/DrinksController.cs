using Drinks.KamilKolanowski.Enums;
using Drinks.KamilKolanowski.Services;
using Spectre.Console;

namespace Drinks.KamilKolanowski.Controllers;

internal class DrinksController
{
    internal void ShowDrinks()
    {
        CreateDrinkDetailsTable drinkDetailsTable = new();
        
        while (true)
        {
            Console.Clear();

            var selectDrinkCategory = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("Select Drink Category from the list")
                    .AddChoices(DrinkCategories.DrinkCategoryOptionsDisplay.Values)
            );

            var selectedDrinkCategory = DrinkCategories
                .DrinkCategoryOptionsDisplay.FirstOrDefault(d => d.Value == selectDrinkCategory)
                .Key;

            switch (selectedDrinkCategory)
            {
                case DrinkCategories.DrinkCategoryOptions.Cocktail:
                    drinkDetailsTable.CreateTable("Cocktail", new List<string> { "Whiskey", "Lemon", "Angostura" });
                    Console.ReadKey();
                    break;
                case DrinkCategories.DrinkCategoryOptions.OrdinaryDrink:
                    drinkDetailsTable.CreateTable("Ordinary Drink", new List<string> { "Vodka", "Salt", "Pepper" });
                    Console.ReadKey();
                    break;
                case DrinkCategories.DrinkCategoryOptions.PunchPartyDrink:

                    Console.ReadKey();
                    break;
                case DrinkCategories.DrinkCategoryOptions.Shake:
                    AnsiConsole.MarkupLine("[bold green]Selected Shake[/]");
                    Console.ReadKey();
                    break;
                case DrinkCategories.DrinkCategoryOptions.OtherUnknown:
                    AnsiConsole.MarkupLine("[bold green]Unknown[/]");
                    Console.ReadKey();
                    break;
                case DrinkCategories.DrinkCategoryOptions.Cocoa:
                    AnsiConsole.MarkupLine("[bold green]Cocoa[/]");
                    Console.ReadKey();
                    break;
                case DrinkCategories.DrinkCategoryOptions.Shot:
                    AnsiConsole.MarkupLine("[bold green]Shot[/]");
                    Console.ReadKey();
                    break;
                case DrinkCategories.DrinkCategoryOptions.CoffeeTea:
                    AnsiConsole.MarkupLine("[bold green]CoffeeTea[/]");
                    Console.ReadKey();
                    break;
                case DrinkCategories.DrinkCategoryOptions.HomemadeLiqueur:
                    AnsiConsole.MarkupLine("[bold green]Homemade Liqueur[/]");
                    Console.ReadKey();
                    break;
                case DrinkCategories.DrinkCategoryOptions.Beer:
                    AnsiConsole.MarkupLine("[bold green]Beer[/]");
                    Console.ReadKey();
                    break;
                case DrinkCategories.DrinkCategoryOptions.SoftDrink:
                    AnsiConsole.MarkupLine("[bold green]Soft Drink[/]");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
