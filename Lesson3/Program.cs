namespace Lesson3;


public enum FuelType
{
    Petrol,
    Diesel,
    Electric,
    Hybrid
}

public enum BodyType
{
    Sedan,
    Hatchback,
    SUV,
    Coupe,
    Convertible
}

public abstract class Transport
{
    public string Model { get; set; }
    public int Year { get; set; }
    public FuelType Fuel { get; set; }

    public Transport(string model, int year, FuelType fuel)
    {
        Model = model;
        Year = year;
        Fuel = fuel;
    }
}

public class Car : Transport
{
    public BodyType Body { get; set; }

    public Car(string model, int year, FuelType fuel, BodyType body) : base(model, year, fuel)
    {
        Body = body;
    }
}

public class Bus : Transport
{
    public int PassengerCapacity { get; set; }

    public Bus(string model, int year, FuelType fuel, int capacity) : base(model, year, fuel)
    {
        PassengerCapacity = capacity;
    }
}

public class TransportManager
{
    private List<Transport> transportList = new();
    
    public void AddTransport(Transport transport)
    {
        transportList.Add(transport);
        Console.WriteLine("Transport added successfully.");
    }
    
    public void EditTransport(int index, Transport newTransport)
    {
        if (index >= 0 && index < transportList.Count)
        {
            transportList[index] = newTransport;
            Console.WriteLine("Transport updated successfully.");
        }
        else
        {
            Console.WriteLine("Invalid index.");
        }
    }
    
    public void RemoveTransport(int index)
    {
        if (index >= 0 && index < transportList.Count)
        {
            transportList.RemoveAt(index);
            Console.WriteLine("Transport removed successfully.");
        }
        else
        {
            Console.WriteLine("Invalid index.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        TransportManager manager = new TransportManager();
        
        manager.AddTransport(new Car("Toyota Corolla", 2020, FuelType.Petrol, BodyType.Sedan));
        manager.AddTransport(new Bus("Mercedes Sprinter", 2018, FuelType.Diesel, 20));
        manager.EditTransport(0, new Car("Honda Civic", 2022, FuelType.Hybrid, BodyType.Sedan));
        manager.RemoveTransport(1);
    }
}