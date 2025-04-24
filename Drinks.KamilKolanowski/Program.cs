using Drinks.KamilKolanowski.Controllers;

namespace Drinks.KamilKolanowski;

class Program
{
    static async Task Main(string[] args)
    {
        DrinksCategoryController drinksCategoryController = new();

        await drinksCategoryController.ShowDrinks();
    }
}
