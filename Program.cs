using System;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your salary :");
            var salary = Convert.ToDouble(Console.ReadLine());

            var myCard = Factory.GetCard(salary);
            Console.WriteLine(myCard);
        }
    }
}
