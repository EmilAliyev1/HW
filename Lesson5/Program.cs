using System;
using System.Collections.Generic;
using System.Text;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }

    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }
}

public class LibraryManagement
{
    public void AddBook(List<Book> library)
    {
        Console.Write("\nВведите название книги: ");
        string title = Console.ReadLine();

        Console.Write("\nВведите автора книги: ");
        string author = Console.ReadLine();

        Console.Write("\nВведите год выпуска: ");
        if (int.TryParse(Console.ReadLine(), out int year))
        {
            library.Add(new Book(title, author, year));
            Console.WriteLine("\nКнига добавлена!");
        }
        else
        {
            Console.WriteLine("\nНекорректный год. Попробуйте снова.");
        }
    }

    public void RemoveBook(List<Book> library)
    {
        ShowBooks(library);

        if (library.Count == 0)
        {
            return;
        }

        Console.Write("\nВведите индекс книги для удаления: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= library.Count)
        {
            library.RemoveAt(index - 1);
            Console.WriteLine("\nКнига удалена!");
        }
        else
        {
            Console.WriteLine("\nНеверный индекс. Попробуйте снова.");
        }
    }

    public void ShowBooks(List<Book> library)
    {
        if (library.Count == 0)
        {
            Console.WriteLine("\nСписок книг пуст.");
        }
        else
        {
            Console.WriteLine("\nСписок книг:");
            for (int i = 0; i < library.Count; i++)
            {
                Console.WriteLine($"{i + 1}. \"{library[i].Title}\" - {library[i].Author} ({library[i].Year})");
            }
        }
    }
}


class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
            
        LibraryManagement libraryManagement = new LibraryManagement();
        
        List<Book> library = new List<Book>();
        bool running = true;

        Console.WriteLine("Добро пожаловать в библиотеку!");

        while (running)
        {
            Console.WriteLine("\nВыберите действие:");
            Console.WriteLine("1. Добавить книгу");
            Console.WriteLine("2. Удалить книгу");
            Console.WriteLine("3. Показать все книги");
            Console.WriteLine("4. Выход");
            Console.Write("Ваш выбор: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    libraryManagement.AddBook(library);
                    break;
                case "2":
                    libraryManagement.RemoveBook(library);
                    break;
                case "3":
                    libraryManagement.ShowBooks(library);
                    break;
                case "4":
                    running = false;
                    Console.WriteLine("\nДо свидания!");
                    break;
                default:
                    Console.WriteLine("\nНеверный выбор. Попробуйте снова.");
                    break;
            }
        }
    }
}