using Lesson11.Data.Model;
using Lesson11.Interfaces;

namespace Lesson11.Implementations;

public class HistoryService : IHistoryService
{
    public void WriteAllMovieResults()
    {
        Console.WriteLine("----------------------------------------------------------");
        for (int i = 0; i < MovieService.Results.Count; i++)
        {
            Console.WriteLine($"{i + 1} - {MovieService.Results[i]}");
            foreach (var movie in MovieService.Results[i].results)
            {
                Console.WriteLine($"\t{movie}");
            }
        }
        Console.WriteLine("----------------------------------------------------------");
    }
}