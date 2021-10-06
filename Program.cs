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
            Console.WriteLine("Rectangle of length{0} and width{1} has area{2} and parameter{3}", length, width);
            Rectangle r1 = new Rectangle();
            Console.WriteLine("Area is:" + r1.GetArea());
            Console.WriteLine("Perimeter is:" + r1.GetPerimeter());
            Console.WriteLine("Rectangle of default length{0} and width{1} has area{2} with parameter{3}", length, width);  
        }

    }
}
