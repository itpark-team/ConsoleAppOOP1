using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Cat cat = new Cat("pushok",11);
            Cat cat2 = new Cat(cat);

            cat2.SetName("Vasyok");

            Console.WriteLine(cat.GetName());
            Console.WriteLine(cat.GetAge());

            Console.WriteLine(cat2.GetName());
            Console.WriteLine(cat2.GetAge());*/

            Rectangle rectangle = new Rectangle(3, 8, 11, 2);
            Rectangle rectangle2 = new Rectangle(rectangle.X1 + 1, 8, 11, 2);

            Console.WriteLine(rectangle.GetPerimeter());
            Console.WriteLine(rectangle.GetArea());
            Console.WriteLine(rectangle.GetWidth());
            Console.WriteLine(rectangle.GetHeight());

            rectangle.X1 = 10;
            Console.WriteLine(rectangle.X1);

            Console.ReadKey();
        }
    }
}
