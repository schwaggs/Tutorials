using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Husky meshka = new Husky();
            meshka.Speak();
            Console.ReadLine();
        }
    }

    public class Mammal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Base Class: Mammal");
        }
    }

    public class Dog : Mammal
    {
        public override void Speak()
        {
            base.Speak();
            Bark();
        }

        public virtual void Bark()
        {
            Console.WriteLine("Derived Class/Base Class: Dog");
        }
    }

    public class Husky : Dog
    {
        public override void Bark()
        {
            base.Bark();
            Yip();
        }

        public void Yip()
        {
            Console.WriteLine("Derived Class: Husky");
        }
    }
}
