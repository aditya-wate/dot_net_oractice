using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApps
{
    /*
    class SizeFind
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Size of int: {0}", sizeof(int));
            Console.ReadLine();
        }
    }

    class ExplicitConversion
    {
        static void Main(string[] args)
        {
            double d = 5673.74;
            int i;

            // cast double to int.
            Console.WriteLine("Before conversion it looks like {0}",d);
            i = (int)d;
            //i = d; build error
            Console.WriteLine("Changing Ensues and now it's {0}",i);
            Console.ReadKey();
        }
    } 

    class StringConversion
    {
        static void Main(string[] args)
        {
            int i = 75;
            float f = 53.005f;
            double d = 2345.7652;
            bool b = true;

            Console.WriteLine(i.ToString());
            Console.WriteLine(f.ToString());
            Console.WriteLine(d.ToString());
            Console.WriteLine(b.ToString());
            Console.ReadKey();

        }
    }

    class Declaration
    {
        public static void Main(string[] args)
        {
            short a;
            int b;
            double c;

            //initialization

            a = 10;
            b = 30;
            c = a + b;

            Console.WriteLine(" a = {0} \n b = {1} \n c = {2}", a, b, c);
            Console.ReadLine();
        }
    }

    class ConstDeclaration
    {
        static void Main(string[] args)
        {
            const double pi = 3.14159;

            // constant declaration 
            double r;
            Console.WriteLine("Enter Radius: ");
            r = Convert.ToDouble(Console.ReadLine());
            double areaCircle = pi * r * r;
            Console.WriteLine("Radius: {0}, Area: {1}", r, areaCircle);
            Console.ReadLine();
        }
    }

    class OperatorsTest
    {
        static void Main(string[] args)
        {
            int a = 11;
            a++;
            Console.WriteLine("a = {0}", a);
            Console.ReadLine();
        }
    }*/

    class DecisionMaking
    {
        static void Main(string[] args)
        {
            // local variable definition
            int a = 100;

            // check the boolean condition
            if (a < 20)
            {
                // if condition is true then print the following
                Console.WriteLine("a is less than 20");
            }
            else
            {
                // if condition is false then print the following
                Console.WriteLine("a is not less than 20");
            }
            Console.WriteLine("value of a is : {0}", a);


            Work.TestNS tns = new Work.TestNS();

            tns.Func();

            Console.ReadLine();

            
        }
    }

    namespace Work
    {
        class TestNS
        {
            public void Func()
            {
                Console.Write("Jump");
            }
        }
    }

}
