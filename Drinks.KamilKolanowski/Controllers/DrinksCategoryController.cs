using Drinks.KamilKolanowski.Enums;
using Spectre.Console;

namespace Drinks.KamilKolanowski.Controllers;

internal class DrinksCategoryController
{
    internal async Task ShowDrinks()
    {
        DrinksController drinksController = new DrinksController();
        
        while (true)
        {
            Console.Clear();

            var selectDrinkCategory = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("[gold3_1]Select Drink Category from the list[/]")
                    .AddChoices(DrinkCategories.DrinkCategoryOptionsDisplay.Values)
            );

            var selectedDrinkCategory = DrinkCategories
                .DrinkCategoryOptionsDisplay.FirstOrDefault(d => d.Value == selectDrinkCategory)
                .Key;

            switch (selectedDrinkCategory)
            {
                case DrinkCategories.DrinkCategoryOptions.Cocktail:
                    await drinksController.CreateDrinksList("Cocktail");
                    Console.ReadKey();
                    break;
                case DrinkCategories.DrinkCategoryOptions.OrdinaryDrink:
                    await drinksController.CreateDrinksList("Ordinary_Drink");
                    Console.ReadKey();
                    break;
                case DrinkCategories.DrinkCategoryOptions.PunchPartyDrink:
                    await drinksController.CreateDrinksList("Punch_/_Party_Drink");
                    Console.ReadKey();
                    break;
                case DrinkCategories.DrinkCategoryOptions.Shake:
                    await drinksController.CreateDrinksList("Shake");
                    Console.ReadKey();
                    break;
                case DrinkCategories.DrinkCategoryOptions.OtherUnknown:
                    await drinksController.CreateDrinksList("Other_/_Unknown");
                    Console.ReadKey();
                    break;
                case DrinkCategories.DrinkCategoryOptions.Cocoa:
                    await drinksController.CreateDrinksList("Cocoa");
                    Console.ReadKey();
                    break;
                case DrinkCategories.DrinkCategoryOptions.Shot:
                    await drinksController.CreateDrinksList("Shot");
                    Console.ReadKey();
                    break;
                case DrinkCategories.DrinkCategoryOptions.CoffeeTea:
                    await drinksController.CreateDrinksList("Coffee_/_Tea");
                    Console.ReadKey();
                    break;
                case DrinkCategories.DrinkCategoryOptions.HomemadeLiqueur:
                    await drinksController.CreateDrinksList("Homemade_Liqueur");
                    Console.ReadKey();
                    break;
                case DrinkCategories.DrinkCategoryOptions.Beer:
                    await drinksController.CreateDrinksList("Beer");
                    Console.ReadKey();
                    break;
                case DrinkCategories.DrinkCategoryOptions.SoftDrink:
                    await drinksController.CreateDrinksList("Soft_Drink");
                    Console.ReadKey();
                    break;
                case DrinkCategories.DrinkCategoryOptions.Exit:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
