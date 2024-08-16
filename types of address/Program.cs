using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the address:");
        string address = Console.ReadLine();

        string addressType = GetAddressType(address);
        Console.WriteLine($"The type of address is: {addressType}");
    }

    static string GetAddressType(string address)
    {
        // Check if the address ends with a specific pattern to classify it
        if (address.EndsWith(".255"))
        {
            return "Broadcast address";
        }
        else
        {
            return "Unicast address";
        }
    }
}
