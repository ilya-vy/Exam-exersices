using System;

namespace Завдання_2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateIndexerClass dateIndexerClass = new DateIndexerClass();
            Console.WriteLine("Укажите количество дней: ");
            Console.WriteLine(dateIndexerClass[double.Parse(Console.ReadLine())]);
            Console.ReadKey();
        }
    }
}
