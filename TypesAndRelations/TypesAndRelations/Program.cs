using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndRelations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Can use relational operators to compare multiple types including the types themselfs

            // See if two static integers are equal, should output "true" because 1 equals 1
            Console.WriteLine(1 == 1);

            // See if two static strings are equal, should output "false" because "str" is not the same string as "sta"
            Console.WriteLine("str" == "sta");

            // This should also output "false" because the string "str" is all lowercase while the strign "STR" is all uppercase, and things are case sensitive.
            Console.WriteLine("str" == "STR");

            // The above comparisons used the equivalency operator ==
            // Let's use the not equivalent operator != in the case of the comparison above with "str" and "STR"

            // This will return "true" because "str" does not equal "STR"
            Console.WriteLine("str" != "STR");

            // Next let's look at less than and greater than

            // This will return "false" because 1 is not less than itself
            Console.WriteLine(1 < 1);

            // This will return true because 0.5 is less than 1
            Console.WriteLine(0.5 < 1 );

            // Next let's look at less than or equal and greater than or equal

            // This will return true because even though 1 is not less than 1, it is still equal to itself
            Console.WriteLine(1 <= 1);

            // And the same case for greater than
            Console.WriteLine(1 >= 1);

            // Now let's look at a few more operators is and as

            // is will return true if the type of something is the type of another
            char a = 'a';
            Console.WriteLine(a is int);

            // As will return an object of one type converted to another type
            object tst = new test();

            test testObj = tst as test;

            Console.WriteLine(testObj.GetType());

            Console.ReadLine();
        }
    }

    public class test { }
}
