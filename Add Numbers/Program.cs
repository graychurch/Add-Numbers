// See https://aka.ms/new-console-template for more information
// <auto-generated/>
global using global::System;
global using global::System.Collections.Generic;
global using global::System.IO;
global using global::System.Linq;
global using global::System.Net.Http;
global using global::System.Threading;
global using global::System.Threading.Tasks;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("I will add two numbers for you.");
        Console.Write("Type your first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Type another number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        int sum = num1 + num2;
        Console.Write("The sum of "+num1+" and "+num2+" equals "+sum);
        Console.WriteLine();
        Console.WriteLine("Press any key to exit.");
        Console.ReadLine();
    }
}