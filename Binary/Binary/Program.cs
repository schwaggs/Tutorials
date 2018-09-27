using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter decimal to convert: ");

            int dec = int.Parse(Console.ReadLine());
            int dec_temp = dec;

            List<int> remainders = new List<int>();
            
            // While our decimal division with 2 does not yield the stop case of 0
            while(dec_temp != 0)
            {
                // Get the remainder of the division before changing the decimal value
                int remainder = dec_temp % 2;

                // Keep history of previous remainders
                remainders.Add(remainder);

                // Divide the decimal by 2 and set it to itself
                dec_temp /= 2;
            }

            // We will convert all of the bit integers to a string for output
            string result = string.Empty;

            // We should now have all of our bits in the remainders list
            // We can either read the list by iterating from the end to the beggining OR
            // We can flip the list then iterate from beggining to end

            // End to Beggining

            // Iterate from the last index in the list to the first, which is always 0

            for(int i = remainders.Count-1; i >= 0; i --)
            {
                result += remainders[i].ToString();
            }

            Console.WriteLine(result);

            // Clear previous results from our string for new output
            result = string.Empty;

            // Beggining to End

            // Flip the list
            remainders.Reverse();

            // Iterate through
            for(int i = 0; i < remainders.Count; i ++)
            {
                result += remainders[i].ToString();
            }

            Console.WriteLine(result);

            // One more way to iterate through the list is using a for each loop
            // Clear previous results from our string for new output

            result = string.Empty;
            
            // The list should still be in reverse order so we will iterate it that

            foreach(int remainder in remainders)
            {
                result += remainder.ToString();
            }

            Console.WriteLine(result);

            // If the list was not in reverse order, since that is the correct way to read the result, we would first have to reverse the list then do the foreach

            // Now let's use a built in method for conversion using a custom class with a method call.

            // Instantiate the BinaryConverter object passing in the required parameter which is the value we want to convert
            BinaryConverter bc = new BinaryConverter(dec);

            // Output the result of the UseString method in the BinaryConverter class
            Console.WriteLine(bc.UseString());

            // Keep window up until enter pressed
            Console.WriteLine("Press ENTER to close console.");
            Console.ReadLine();
        }
    }
}
