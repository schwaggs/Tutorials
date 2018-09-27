using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            PublicClass pub = new PublicClass();
            PublicClassPrivateProp pubpriv = new PublicClassPrivateProp();
            PublicClassGetSet pubgetset = new PublicClassGetSet();
            OuterClass outer = new OuterClass();
            OuterClass.TestProtected outerprotectedtest = new OuterClass.TestProtected();
            OuterProtectedTestClass outerprotectedderivedtest = new OuterProtectedTestClass();

            // Access the public property of the PublicClass class
            pub.PublicProperty = "setting public property to value";
            Console.WriteLine(pub.PublicProperty);

            // Try to access the private property of the PublicClassPrivateProp class
            // pubpriv

            // Access the properties with get and set from the PublicClassGetSet class
            pubgetset.OnlySet = "new value 1";
            Console.WriteLine(pubgetset.OnlyGet);
            pubgetset.Both = "new value 2";
            Console.WriteLine(pubgetset.Both);

            // Try to access the private classes nested inside the outer class
            //outer

            // Access the protected OuterClassProtected class from class within OuterClass
            Console.WriteLine(outerprotectedtest.GetString());

            // Use a derived class to access the protected OuterClassProtected class, this class is outside the OuterClass
            Console.WriteLine(outerprotectedderivedtest.GetString());
            

            Console.WriteLine("Press ENTER to exit");
            Console.ReadLine();
        }
    }

    // Public class and public property
    public class PublicClass
    {
        public string PublicProperty { get; set; }
    }

    // Public class and private property
    public class PublicClassPrivateProp
    {
        private string PrivateProperty { get; set; }
    }

    // Public class and property with only set and proeprty with only get and one with both
    public class PublicClassGetSet
    {
        private string _SomeString { get; set; }

        public string OnlyGet
        {
            get
            {
                return _SomeString;
            }
        }

        public string OnlySet
        {
            set
            {
                _SomeString = value;
            }
        }

        public string Both
        {
            get
            {
                return _SomeString;
            }
            set
            {
                _SomeString = value;
            }
        }
    }

    public class OuterClass
    {
        // Private class public property
        private class PrivateClassPublicProp
        {
            public string PublicProperty { get; set; }
        }

        // private class private property
        private class PrivateClassPrivateProp
        {
            private string PrivateProperty { get; set; }
        }

        public class TestProtected
        {
            public string GetString()
            {
                OuterClassProtected temp = new OuterClassProtected();

                temp.ProtectedProperty = "This string is from the protected class.";

                return temp.ProtectedProperty;
            }
        }

        protected class OuterClassProtected
        {
            public string ProtectedProperty { get; set; }
        }
    }

    public class OuterProtectedTestClass : OuterClass
    {
        public string GetString()
        {
            OuterClassProtected temp = new OuterClassProtected
            {
                ProtectedProperty = "This string is from the protected class"
            };

            return temp.ProtectedProperty;
        }
    }
}
