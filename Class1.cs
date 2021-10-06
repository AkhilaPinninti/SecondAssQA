using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//namesapces are used to arrange the classes
namespace firstQa
{
    //class name rectangle is declared with public keyword access specifier
    public class Rectangle
    {
        //length and width of rectangle variable names are declared here.
        private int length;
        private int width;
        //default constructor values are given already for length and width
        public Rectangle()
        {
            this.length = 1;
            this.width = 1;

        }
        public Rectangle(int l, int w)
        {
            length = l;
            width = w;
        }
        public int SetLength(int l) => length = l;
        public int SetWidth(int w) => width = w;
        public int GetLength()
        {
            return length;
        }
        public int GetWidth()
        {
            return width;
        }
        //GetArea used to calculate the area of the rectangle and it is returned
        public int GetArea()
        {
            return  length * width;
        }
        //GetPerimeter used to calculate the perimeter of the rectangle and it is returned
        public int GetPerimeter()
        {
            return (length + width) * 2;
        }
    }
}
