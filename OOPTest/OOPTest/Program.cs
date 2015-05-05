using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTest
{
    /*
    class RectanglePublic
    {
        //member variables
        public double length;
        public double width;

        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }//end class Rectangle

    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            RectanglePublic r = new RectanglePublic();
            r.length = 4.5;
            r.width = 3.5;
            r.Display();
            Console.ReadLine();
        }
    }

    class RectanglePrivate
    {
        //member variables
        private double length;
        private double width;

        public void Acceptdetails()
        {
            Console.Write("Enter Length: ");
            length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Width: ");
            width = Convert.ToDouble(Console.ReadLine());
        }
        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }//end class Rectangle

    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            RectanglePrivate r = new RectanglePrivate();
            r.Acceptdetails();
            r.Display();
            Console.ReadLine();
        }
    }

    class Rectangle
    {
        //member variables
        internal double length;
        internal double width;

        double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }//end class Rectangle

    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.length = 4.5;
            r.width = 3.5;
            r.Display();
            Console.ReadLine();
        }
    }

    class NumberManipulator
    {
        public void getValue(out int x)
        {
            int temp = 5;
            x = temp;
        }

        static void Main(string[] args)
        {
            NumberManipulator n = new NumberManipulator();

            // local variable definition
            int a = 100;

            Console.WriteLine("Before method call, value of a : {0}", a);

            // calling a function to get the value
            n.getValue(out a);

            Console.WriteLine("After method call, value of a : {0}", a);
            Console.ReadLine();

        }
    }*/

    class MyArray
    {
        static void Main(string[] args)
        {
            int[] n = new int[3] {34, 67, 89}; /* n is an array of 10 integers */

            foreach (int j in n)
            {
                //int i = j - 100;
                //Console.WriteLine("Element[{0}] = {1}", i, j);
                //i++;
                Console.WriteLine("E[] = {0}",j);
            }
            Console.ReadKey();
        }
    }
}
