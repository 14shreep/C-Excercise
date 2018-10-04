using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderEx
{
    class Program
    {
               static void Main(string[] args)
        {
            StringBuilder letters = new StringBuilder("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
            StringBuilder line = new StringBuilder();
            StringBuilder results = new StringBuilder();
            for (int i = 0; i < 26; i++)
            {
                line.Append(letters[i]);
                results.AppendLine(line.ToString());
            }
            Console.WriteLine(results.ToString());

        }
    }
}

