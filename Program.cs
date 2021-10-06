using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstQa
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Enter the length:");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the width:");
            int width = Convert.ToInt32(Console.ReadLine());

            Rectangle r = new Rectangle(length,width);
            Console.WriteLine("Area is:" + r.GetArea());
            Console.WriteLine("Perimeter is:" + r.GetPerimeter());
            Console.ReadKey();
        }

    }
}
