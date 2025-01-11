using System.Xml;

namespace Lesson11;

public class Menu
{
    private List<MenuChoice> _menuChoices = new()
    {
        new() { Id = 1, Description = "Search for a movie by name" },
        new() { Id = 2, Description = "Search for a movie by genre" },
        new () { Id = 3, Description = "View movies search history" },
        new () { Id = 4, Description = "Delete movie search history by index" },
        new() { Id = 5, Description = "Exit" },
    };
    
    public void DisplayMenu()
    {
        Console.WriteLine("Please choose an option:");
        foreach (var choice in _menuChoices)
        {
            Console.WriteLine($"{choice.Id}. {choice.Description}");
        }
    }
    
    public MenuChoice GetMenuChoice()
    {
        var choice = Console.ReadLine();
        if (int.TryParse(choice, out var result))
        {
            return _menuChoices[result - 1];
        }
        return _menuChoices[_menuChoices.Count - 1];
    }
}

public class MenuChoice
{
    public  int Id { get; set; }
    public string Description { get; set; }
}