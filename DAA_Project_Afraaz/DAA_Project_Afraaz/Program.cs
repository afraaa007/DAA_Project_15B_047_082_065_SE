using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace breaKString
{

    class Program
    {
        static void Main(string[] args)
        {
            string value = "we are here to break a string";
            Console.WriteLine("we are here to break a string");
            char[] array = value.ToCharArray();
            Console.WriteLine("Enter starting index of substring: ");
            int s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Ending index of substring: ");
            int e = Convert.ToInt32(Console.ReadLine());
            for (int i = s; i <= e; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadLine();
        }
    }
}