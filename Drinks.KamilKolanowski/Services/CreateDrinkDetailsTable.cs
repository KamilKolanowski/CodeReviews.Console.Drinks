using Spectre.Console;

namespace Drinks.KamilKolanowski.Services;

internal class CreateDrinkDetailsTable
{
    internal void CreateTable(string drinkName, List<string> ingredients)
    {
        var table = new Table();
        table.AddColumn($"[deeppink4_2]{drinkName} Details[/]");

        int index = 1;

        foreach (var ingredient in ingredients)
        {
            table.AddRow($"[mediumorchid3]{index}: {ingredient}[/]");
            index++;
        }
        
        table.Border(TableBorder.Rounded);

        AnsiConsole.Write(table);
    }    
}
