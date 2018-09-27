using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            StaticClassExample.StaticClassProperty = "This is the static class's property that stays for the life of the program.";
            Console.WriteLine(StaticClassExample.StaticClassProperty);

            StaticClassExample.PrintInternalClass();
            StaticClassExample.PrintInnerClass(StaticClassExample.StaticInnerClassObj);

            if(StaticClassExample.StaticInnerClassObj == null)
            {
                Console.WriteLine("Static inner class object is null");
            }

            StaticClassExample.StaticInnerClassObj = new StaticClassExample.InnerClass
            {
                InnerClassProperty = "This is the non static class property of the class inside the static class."
            };

            StaticClassExample.PrintInternalClass();
            StaticClassExample.PrintInnerClass(StaticClassExample.StaticInnerClassObj);

            Console.WriteLine("Press ENTER to exit");
            Console.ReadLine();
        }
    }
}
