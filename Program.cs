using FizzBuzz.Interface;
using FizzBuzz.Classes;
using System;

namespace FizzBuzz.Main
{
    class Program
    {
        static void Main(string[] args)
        {
            IFizzBuzzHandler fizzBuzzHandler = new Classes.FizzBuzz(new Fizz(new Buzz()));

            for (int i = 1; i <= 200; i++)
            {
                Console.WriteLine(fizzBuzzHandler.Handle(i));
            }
            Console.ReadKey();
        }
    }
}
