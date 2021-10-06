using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstQa
{
    public class Rectangle
    {
        private int length;
        private int width;
        private int area;
        private int perimeter;
        public Rectangle()
        {
            length = 1;
            width = 1;

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
        public int GetArea()
        {
            return area = length * width;
        }
        public int GetPerimeter()
        {
            return perimeter = (length + width) * 2;
        }
    }
}
