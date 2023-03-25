using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string greetings = "Happy to meet you,";
            string name = " Narcis";
            Console.WriteLine(string.Concat(greetings, name));
            Console.WriteLine(string.IsNullOrEmpty(name));
            Console.WriteLine(name.Replace("s", "T"));
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.TrimStart(' '));
            Console.WriteLine(name.Trim());
            Console.WriteLine(name.IndexOf('N'));
        }
    }
}
