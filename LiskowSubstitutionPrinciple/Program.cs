using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskowSubstitutionPrinciple
{

    class Rectangle
    {
        protected Int32 width;
        protected Int32 height;
        public Int32 Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }
        public Int32 Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }
        public Int32 Area { get { return width * height; } }
    }

    class Square : Rectangle
    {
        public Int32 Width { set { height = value; width = value; } }
        public Int32 Height { set { height = value; width = value; } }
    }

    class RectangleTest
    {
        public void RectangleTestArea(Rectangle rectangle)
        {
            rectangle.Width = 10;
            rectangle.Width = 5;
            if (rectangle.Area != 50)
                throw new Exception("Bad Area!");

            Console.WriteLine("RectangleTest Test Passed");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle() { Width = 10, Height = 5 };
            Square square = new Square() { Width = 10, Height = 5 };
            Console.WriteLine("Rectangle area: {0}", rectangle.Area);
            Console.WriteLine("Square area: {0}", square.Area);

            new RectangleTest().RectangleTestArea(rectangle);
            new RectangleTest().RectangleTestArea(square);

            Console.ReadKey();

        }
    }
}

