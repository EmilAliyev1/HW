using System;
using System.Collections.Generic;
using System.Text;

public enum FuelType
{
    Petrol,
    Diesel,
    Electric
}

public abstract class Transport
{
    public string Type { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public int MaxSpeed { get; set; }

    public Transport(string type, string brand, string model, int year, int maxSpeed)
    {
        Type = type;
        Brand = brand;
        Model = model;
        Year = year;
        MaxSpeed = maxSpeed;
    }

    public virtual void ShowInfo()
    {
        Console.WriteLine($"Тип: {Type}, Марка: {Brand}, Модель: {Model}, Год выпуска: {Year}, Максимальная скорость: {MaxSpeed} км/ч");
    }

    public virtual void Move()
    {
        Console.WriteLine("Транспорт начинает движение.");
    }
}

public class Car : Transport
{
    public FuelType Fuel { get; set; }

    public Car(string type, string brand, string model, int year, int maxSpeed, FuelType fuelType) : base(type, brand, model, year, maxSpeed)
    {
        Fuel = fuelType;
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Тип топлива: {Fuel}");
    }

    public override void Move()
    {
        Console.WriteLine($"Автомобиль {Brand} {Model} едет по дороге со скоростью до {MaxSpeed} км/ч.\n");
    }
}

public class Truck : Transport
{
    public double LoadCapacity { get; set; }

    public Truck(string type, string brand, string model, int year, int maxSpeed, double loadCapacity) : base(type, brand, model, year, maxSpeed)
    {
        LoadCapacity = loadCapacity;
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Грузоподъемность: {LoadCapacity} тонн");
    }

    public override void Move()
    {
        Console.WriteLine($"Грузовик {Brand} {Model} перевозит груз.\n");
    }
}

public class Bike : Transport
{
    public bool HasSidecar { get; set; }

    public Bike(string type, string brand, string model, int year, int maxSpeed, bool hasSidecar) : base(type, brand, model, year, maxSpeed)
    {
        HasSidecar = hasSidecar;
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Есть ли коляска: {(HasSidecar ? "Да" : "Нет")}");
    }

    public override void Move()
    {
        Console.WriteLine($"Мотоцикл {Brand} {Model} мчится по дороге.\n");
    }
}

public class Bus : Transport
{
    public int PassengerCapacity { get; set; }

    public Bus(string type, string brand, string model, int year, int maxSpeed, int passengerCapacity) : base(type, brand, model, year, maxSpeed)
    {
        PassengerCapacity = passengerCapacity;
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Вместимость пассажиров: {PassengerCapacity}");
    }

    public override void Move()
    {
        Console.WriteLine($"Автобус {Brand} {Model} перевозит пассажиров.\n");
    }
}

public class TransportManager
{
    public void AddTransport(List<Transport> transports)
    {
        Console.WriteLine("Выберите тип транспорта: 1. Легковой автомобиль, 2. Грузовик, 3. Мотоцикл, 4. Автобус");
        string typeChoice = Console.ReadLine();

        Console.Write("Введите тип машины: ");
        string type = Console.ReadLine();
        Console.Write("Введите марку: ");
        string brand = Console.ReadLine();
        Console.Write("Введите модель: ");
        string model = Console.ReadLine();
        Console.Write("Введите год выпуска: ");
        int year = int.Parse(Console.ReadLine());
        Console.Write("Введите максимальную скорость: ");
        int maxSpeed = int.Parse(Console.ReadLine());

        switch (typeChoice)
        {
            case "1":
                Console.Write("Введите тип топлива (бензин (1), дизель (2), электро(3)): ");
                int fuelTypeIndex  = int.Parse(Console.ReadLine()) - 1;
                if (fuelTypeIndex >= 0 && fuelTypeIndex <= 2)
                {
                    FuelType fuelType = (FuelType)fuelTypeIndex;
                    transports.Add(new Car(type, brand, model, year, maxSpeed, fuelType));
                }
                else
                {
                    Console.WriteLine("Неверный выбор типа топлива.");
                }
                break;

            case "2":
                Console.Write("Введите грузоподъемность (в тоннах): ");
                double loadCapacity = double.Parse(Console.ReadLine());
                transports.Add(new Truck(type, brand, model, year, maxSpeed, loadCapacity));
                break;

            case "3":
                Console.Write("Есть ли коляска (да/нет): ");
                bool hasSidecar = Console.ReadLine().ToLower() == "да";
                transports.Add(new Bike(type, brand, model, year, maxSpeed, hasSidecar));
                break;

            case "4":
                Console.Write("Введите вместимость пассажиров: ");
                int passengerCapacity = int.Parse(Console.ReadLine());
                transports.Add(new Bus(type, brand, model, year, maxSpeed, passengerCapacity));
                break;

            default:
                Console.WriteLine("Неверный выбор типа транспорта.");
                break;
        }
    }

    public void ShowAllTransport(List<Transport> transports)
    {
        if (transports.Count == 0)
        {
            Console.WriteLine("Список транспорта пуст.");
            return;
        }

        for (int i = 0; i < transports.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            transports[i].ShowInfo();
        }
    }

    public void StartTransport(List<Transport> transports)
    {
        Console.Write("Введите номер транспорта для запуска: ");
        int index = int.Parse(Console.ReadLine());

        if (index >= 1 && index <= transports.Count)
        {
            transports[index-1].Move();
        }
        else
        {
            Console.WriteLine("Неверный индекс.");
        }
    }

    public void DeleteTransport(List<Transport> transports)
    {
        Console.Write("Введите номер транспорта для удаления: ");
        int index = int.Parse(Console.ReadLine());

        if (index >= 1 && index <= transports.Count)
        {
            transports.RemoveAt(index - 1);
            Console.WriteLine("Транспорт удален.");
        }
        else
        {
            Console.WriteLine("Неверный индекс.");
        }
    }

    public void FilterTransport(List<Transport> transports)
    {
        Console.WriteLine("Выберите тип транспорта для фильтрации: 1. Легковой автомобиль, 2. Грузовик, 3. Мотоцикл, 4. Автобус");
        string typeChoice = Console.ReadLine();

        List<Transport> filteredTransports = new List<Transport>();

        switch (typeChoice)
        {
            case "1":
                filteredTransports = transports.FindAll(t => t is Car);
                break;
            case "2":
                filteredTransports = transports.FindAll(t => t is Truck);
                break;
            case "3":
                filteredTransports = transports.FindAll(t => t is Bike);
                break;
            case "4":
                filteredTransports = transports.FindAll(t => t is Bus);
                break;
            default:
                Console.WriteLine("Неверный выбор типа транспорта.");
                return;
        }

        if (filteredTransports.Count > 0)
        {
            Console.WriteLine("Результаты фильтрации:");
            for (int i = 0; i < filteredTransports.Count; i++)
            {
                Console.Write($"{i + 1}. ");
                filteredTransports[i].ShowInfo();
            }
        }
        else
        {
            Console.WriteLine("Транспорт указанного типа не найден.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        
        TransportManager transportManager = new TransportManager();
        
        List<Transport> transports = new List<Transport>();
        bool running = true;
        
        while (running)
        {
            Console.WriteLine("\nМеню:");
            Console.WriteLine("1. Добавить транспортное средство");
            Console.WriteLine("2. Показать все транспортные средства");
            Console.WriteLine("3. Запустить транспорт");
            Console.WriteLine("4. Удалить транспортное средство");
            Console.WriteLine("5. Фильтрация транспорта по типу");
            Console.WriteLine("6. Выход");

            Console.Write("Выберите опцию: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    transportManager.AddTransport(transports);
                    break;
                case "2":
                    transportManager.ShowAllTransport(transports);
                    break;
                case "3":
                    transportManager.StartTransport(transports);
                    break;
                case "4":
                    transportManager.DeleteTransport(transports);
                    break;
                case "5":
                    transportManager.FilterTransport(transports);
                    break;
                case "6":
                    running = false;
                    Console.WriteLine("\nДо свидания!");
                    break;
                default:
                    Console.WriteLine("Неверный ввод. Попробуйте снова.");
                    break;
            }
        }
    }
}