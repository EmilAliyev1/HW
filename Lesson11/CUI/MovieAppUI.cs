namespace Lesson11.CUI;
using Lesson11;
using Lesson11.Implementations;
using Lesson11.Interfaces;

public class MovieAppUi
{
    private Menu _menu;
    private IMovieService _movieService;
    private HistoryService _historyService;

    public MovieAppUi()
    {
        _menu = new Menu();
        _movieService = new MovieService();
        _historyService = new HistoryService();
        
        bool flag = true;
        while (flag)
        {
            _menu.DisplayMenu();

            MenuChoice choice = _menu.GetMenuChoice();

            try
            {
                switch (choice.Id)
                {
                    case 1:
                        Console.WriteLine($"You chose {choice.Description}");

                        Console.WriteLine("Enter movie name:");
                        var movieName = Console.ReadLine();
            
                        var res = _movieService.SearchMovie(movieName);
            
                        _movieService.SaveMovie(res);
            
                        Console.WriteLine(res);

                        foreach (var movie in res.results)
                        {
                            Console.WriteLine(movie);
                        }
            
                        break;
                    case 2:
                        Console.WriteLine($"You chose {choice.Description}");
                        break;
                    case 3:
                        _historyService.WriteAllMovieResults();
                        break;
                    case 4:
                        Console.WriteLine("Choose index:");
                        int.TryParse(Console.ReadLine(), out int index);
                        _movieService.DeleteMovie(index);
                        break;
                    case 5:
                        flag = false;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}