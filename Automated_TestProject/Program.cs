using System;
using TestLibrary;

namespace Automated_TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var Functions = new Functions();

            var answer = Functions.Add1(3);

            Console.WriteLine($"Answer is {answer}");
        }
    }
}
