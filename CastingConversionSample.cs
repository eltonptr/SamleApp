using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    // Create a console app to show basic calculations
    // Addtion, Subtraction, Multiplication and Division
    // Proper Exceptions needs to be handled and print generic message in console

    // Classroom Session Assignment - Day1 
    public class CastingConversionSample
    {

    }

    class Animal
    {
        public void Eat() { Console.WriteLine("Eating."); }
        public override string ToString()
        {
            return "I am an animal.";
        }
    }
    class Mammal : Animal { }
    class Giraffe : Mammal { }

    class SuperNova { }

    class Program
    {
        static void Main(string[] args)
        {
            var g = new Giraffe();
            var a = new Animal();
            //FeedMammals(g);
            //FeedMammals(a);
            // Output:
            // Eating.
            // Animal is not a Mammal

            SuperNova sn = new SuperNova();
            TestForMammals(g);
            TestForMammals(sn);
            // Output:
            // I am an animal.
            // SuperNova is not a Mammal
        }

        static void FeedMammals(Animal a)
        {
            if (a is Mammal m)
            {
                m.Eat();
            }
            else
            {
                // variable 'm' is not in scope here, and can't be used.
                Console.WriteLine($"{a.GetType().Name} is not a Mammal");
            }
        }

        static void TestForMammals(object o)
        {
            // You also can use the as operator and test for null
            // before referencing the variable.
            var m = o as Mammal;
            if (m != null)
            {
                Console.WriteLine(m.ToString());
            }
            else
            {
                Console.WriteLine($"{o.GetType().Name} is not a Mammal");
            }
        }
    }
}
