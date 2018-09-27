using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncrementDecrement
{
    class Program
    {
        static void Main(string[] args)
        {
            int test = 0;

            Console.WriteLine(test++);
            Console.WriteLine(test);
            test = 0;
            Console.WriteLine(++test + "\n\n");

            for(int i = 0; i < 10; ++i)
            {
                Console.WriteLine(i.ToString());
            }

            Console.WriteLine("\n\n");

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i.ToString());
            }

            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();
        }
    }
}
