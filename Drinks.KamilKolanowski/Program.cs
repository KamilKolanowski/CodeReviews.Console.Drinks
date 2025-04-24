using Drinks.KamilKolanowski.Controllers;

namespace Drinks.KamilKolanowski;

class Program
{
    static async Task Main()
    {
        DrinksCategoryController drinksCategoryController = new();

        await drinksCategoryController.ShowDrinks();
    }
}
