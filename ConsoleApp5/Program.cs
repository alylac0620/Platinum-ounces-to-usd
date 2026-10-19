using System;

class Program
{
    static decimal PlatToUSD(decimal ounces)
    {
        return ounces * 1634.00m;
    }

        static void Main()
    {
        decimal PlatOunces = 0.0m;
        Console.WriteLine("Please enter the platinum ouncces: ");
        PlatOunces = Convert.ToDecimal(Console.ReadLine());

        decimal totalUSD = 0.0m;
        totalUSD = PlatToUSD(PlatOunces);
        Console.WriteLine($"Value in USD: {totalUSD:C2}");


    }
}