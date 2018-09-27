using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] IntegerArray = new int[10];
            int[] InitializedArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            List<int> IntegerList = new List<int>();
            List<int> IntegerListInitialized = new List<int>
            {
                { 1 },
                { 2 },
                { 3 },
                4,
                5,
                6,
                7,
                8,
                9,
                10
            };

            Dictionary<int, string> IntegerDict = new Dictionary<int, string>();
            Dictionary<int, string> IntegerDictInitialized = new Dictionary<int, string>
            {
                { 1, "1" },
                { 2, "2" },
                { 3, "3" },
                { 4, "4" },
                { 5, "5" },
                { 6, "6" },
                { 7, "7" },
                { 8, "8" },
                { 9, "9" },
                { 10, "10" }
            };

            // Iterating an array using index and foreach
            for(int i = 0; i < InitializedArray.Length; i++)
            {
                if (i < InitializedArray.Length-1)
                    Console.Write(InitializedArray[i].ToString() + ", ");
                else
                {
                    Console.WriteLine(InitializedArray[i].ToString() + "\n\n");
                }
            }

            foreach(int integer in IntegerArray)
            {
                Console.Write(integer.ToString() + ", ");
            }

            // Cant add anything to the array on it's own because it is non dynamic i.e. it cannot grow or shrink during runtime.

            Console.WriteLine("\n\n");

            // Iterating a list using index and foreach
            for(int i = 0; i < IntegerListInitialized.Count; i++)
            {
                if(i < IntegerListInitialized.Count - 1)
                {
                    Console.Write(IntegerListInitialized[i].ToString() + ", ");
                }
                else
                {
                    Console.WriteLine(IntegerListInitialized[i].ToString() + "\n\n");
                }
            }

            foreach(int integer in IntegerList)
            {
                Console.Write(integer.ToString() + ", ");
            }

            Console.WriteLine("\n\n");

            // Add something to IntegerList and IntegerListInitialized
            IntegerList.Add(1);
            IntegerList.Add(2);
            IntegerListInitialized.Add(11);
            IntegerListInitialized.Add(12);

            foreach(int integer in IntegerList)
            {
                Console.Write(integer.ToString() + ", ");
            }

            Console.WriteLine("\n\n");

            foreach (int integer in IntegerListInitialized)
            {
                Console.Write(integer.ToString() + ", ");
            }

            Console.WriteLine("\n\n");

            // Iterate through integer dictionary using index. This is only possible because we have our key defined as an integer
            // This is not always the case and is therefore not always applicible
            for(int i = 1; i <= IntegerDictInitialized.Count; i ++)
            {
                if (i < IntegerDictInitialized.Count)
                    Console.Write(IntegerDictInitialized[i] + ", ");
                else
                    Console.WriteLine(IntegerDictInitialized[i] + "\n\n");
            }

            // Iterate through integer dictionary using foreach
            foreach(KeyValuePair<int, string> kvp in IntegerDictInitialized)
            {
                Console.WriteLine("Key: " + kvp.Key.ToString() + "\tValue: " + kvp.Value);
            }

            Console.WriteLine("\n\n");

            // Add something to IntegerDict
            IntegerDict.Add(1, "1");
            IntegerDict.Add(2, "2");

            foreach(KeyValuePair<int, string> kvp in IntegerDict)
            {
                Console.WriteLine("Key: " + kvp.Key.ToString() + "\tValue: " + kvp.Value);
            }

            Console.WriteLine("Press ENTER to quit");
            Console.ReadLine();
        }
    }
}
