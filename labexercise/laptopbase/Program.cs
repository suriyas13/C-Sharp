using System;

class LaptopBase
{
    public const string DefaultName = "Unknown";
    public const decimal DefaultPrice = 0m;
    public const string DefaultProcessor = "Unknown";
    public const int DefaultRam = 0;
    public const int DefaultHardDrive = 0;
}

class Laptop : LaptopBase
{
    public string Name { get; private set; }
    public decimal Price { get; private set; }
    public string Processor { get; private set; }
    public int Ram { get; private set; }
    public int HardDrive { get; private set; }

    public Laptop(string name, decimal price, string processor, int ram, int hardDrive)
    {
        Name = name;
        Price = price;
        Processor = processor;
        Ram = ram;
        HardDrive = hardDrive;
    }

    public void PrintDetails()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Price: {Price}");
        Console.WriteLine($"Processor: {Processor}");
        Console.WriteLine($"RAM: {Ram} GB");
        Console.WriteLine($"Hard Drive: {HardDrive} GB");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Laptop laptop1 = new Laptop("Laptop 1", 999.99m, "Intel Core i7", 16, 512);
        Laptop laptop2 = new Laptop("Laptop 2", 799.99m, "AMD Ryzen 5", 8, 256);
        Laptop laptop3 = new Laptop("Laptop 3", 1499.99m, "Intel Core i9", 32, 1024);

        Console.WriteLine("Laptop 1 Details:");
        laptop1.PrintDetails();
        Console.WriteLine();

        Console.WriteLine("Laptop 2 Details:");
        laptop2.PrintDetails();
        Console.WriteLine();

        Console.WriteLine("Laptop 3 Details:");
        laptop3.PrintDetails();
    }
}