using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a MAC address:");
        string macAddress = Console.ReadLine();

        if (IsValidMacAddress(macAddress))
        {
            Console.WriteLine("Valid MAC address.");
        }
        else
        {
            Console.WriteLine("Invalid MAC address.");
        }
    }

    static bool IsValidMacAddress(string macAddress)
    {
        // Regular expression pattern to match a MAC address
        string pattern = @"^([0-9A-Fa-f]{2}[:-]){5}([0-9A-Fa-f]{2})$";

        // Check if the input string matches the pattern
        return Regex.IsMatch(macAddress, pattern);
    }
}
