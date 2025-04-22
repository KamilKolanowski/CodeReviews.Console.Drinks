namespace Drinks.KamilKolanowski.Enums;

internal class DrinkCategories
{
    internal enum DrinkCategoryOptions
    {
        Cocktail,
        OrdinaryDrink,
        PunchPartyDrink,
        Shake,
        OtherUnknown,
        Cocoa,
        Shot,
        CoffeeTea,
        HomemadeLiqueur,
        Beer,
        SoftDrink,
    }

    internal static Dictionary<DrinkCategoryOptions, string> DrinkCategoryOptionsDisplay { get; } =
        new()
        {
            [DrinkCategoryOptions.Cocktail] = "Cocktail",
            [DrinkCategoryOptions.OrdinaryDrink] = "Ordinary Drink",
            [DrinkCategoryOptions.PunchPartyDrink] = "Punch / Party Drink",
            [DrinkCategoryOptions.Shake] = "Shake",
            [DrinkCategoryOptions.OtherUnknown] = "Other / Unknown",
            [DrinkCategoryOptions.Cocoa] = "Cocoa",
            [DrinkCategoryOptions.Shot] = "Shot",
            [DrinkCategoryOptions.CoffeeTea] = "Coffee / Tea",
            [DrinkCategoryOptions.HomemadeLiqueur] = "Homemade Liqueur",
            [DrinkCategoryOptions.Beer] = "Beer",
            [DrinkCategoryOptions.SoftDrink] = "Soft Drink",
        };
}
