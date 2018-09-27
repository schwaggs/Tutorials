using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClasses
{
    public static class StaticClassExample
    {
        public static InnerClass StaticInnerClassObj { get; set; }
        public static string StaticClassProperty { get; set; }

        public class InnerClass
        {
            public string InnerClassProperty { get; set; }

            public void PrintInnerClassProperty()
            {
                Console.WriteLine(InnerClassProperty);
            }
        }

        public static int Sum(int start = 0, int end = 0)
        {
            int sum = 0;

            for(int i = start; i <= end; i++)
            {
                sum += i;
            }

            return sum;
        }

        public static void PrintInternalClass()
        {
            PrintInnerClass(StaticInnerClassObj);
        }

        public static void PrintInnerClass(InnerClass InnerClassObj)
        {
            if (InnerClassObj != null)
            {
                Console.WriteLine(InnerClassObj.InnerClassProperty);
            }
        }
    }
}
