using Lesson11.Data.Model;
using Lesson11.Implementations;

namespace Lesson11.Interfaces;

public interface IFileService
{
    void SaveMovie(MovieSearchResult result);
    void DeleteMovie(int index);
    void WriteAllMovieResults();
}