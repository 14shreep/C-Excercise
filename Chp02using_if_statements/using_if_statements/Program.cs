using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace using_if_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int first = 2;
            int second = 0;

            Console.WriteLine("Single if statement");

            if (first == 2)
            {
                Console.WriteLine("if statement evaluated to true");
            }
            Console.WriteLine("This line outputs regardless of the if condition");

            Console.WriteLine();

            // statements only if both are true
            Console.WriteLine("if statement using && operator.");

            if (first == 2 && second == 0)
            {
                Console.WriteLine("if statement evaluated to true");
            }
            Console.WriteLine("This line outputs regardless of the if condition");

            Console.WriteLine();

            // create nested if statements

            Console.WriteLine("Nested if statements.");

            if (first == 2)
            {
                if (second == 0)
                {
                    Console.WriteLine("Both outer and inner conditions are true.");
                }
                Console.WriteLine("Outer condition is true, inner may be true.");
            }
            Console.WriteLine("This line outputs regardless of the if condition");

            Console.WriteLine();

        }
    }
}
