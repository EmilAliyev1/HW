using Lesson11.Data.Model;
using Lesson11.Interfaces;

namespace Lesson11.Implementations;

public class FileService : IFileService
{
    private List<MovieSearchResult> _results = new List<MovieSearchResult>();
    public void SaveMovie(MovieSearchResult result)
    {
        _results.Add(result);
    }

    public void DeleteMovie(int index)
    {
        _results.RemoveAt(index - 1);
    }

    public void WriteAllMovieResults()
    {
        Console.WriteLine("----------------------------------------------------------");
        for (int i = 0; i < _results.Count; i++)
        {
            Console.WriteLine($"{i + 1} - {_results[i]}");
            foreach (var movie in _results[i].results)
            {
                Console.WriteLine($"\t{movie}");
            }
        }
        Console.WriteLine("----------------------------------------------------------");
    }
}