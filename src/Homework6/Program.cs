using System;

namespace Homework6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Atm acc = new Atm(100);
            Console.WriteLine($"Current balance {acc.Sum} BYN");
            acc.Notify += DisplayMessage;
            acc.Put(20);
            Console.WriteLine($"Account amount {acc.Sum} BYN");
            acc.Take(70);
            Console.WriteLine($"Account amount {acc.Sum} BYN");
            acc.Take(10);
            Console.WriteLine($"Account amount {acc.Sum} BYN");
            acc.Take(80);
            Console.WriteLine($"Account amount {acc.Sum} BYN");
            Console.Read();
        }
        private static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
