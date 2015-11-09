using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarianceAndControvariance
{
    public interface IShape { double Area { get; } }
    public class Circle : IShape
    {
        private double area;
        public Circle()
        {
            area = new Random().Next(10, 20);
        }
        public Circle(double area)
        {
            this.area = area;
        }

        public double Area
        {
            get { return area; }
        }
    }
    public class Square : IShape
    {
        private double area;
        public Square()
        {
            area = new Random().Next(10, 20);
        }
        public Square(double area)
        {
            this.area = area;
        }

        public double Area
        {
            get { return area; }
        }
    }

    public class AreaComparer : IComparer<IShape>
    {

        public int Compare(IShape x, IShape y)
        {
            //    A signed integer that indicates the relative values of x and y, as shown
            //     in the following table.Value Meaning
            //            - Less than zero x is less than y.
            //            - Zero x equals y.
            //            - Greater than zerox is greater than y.

            if (x.Area < y.Area)
                return -1;
            else if (x.Area == y.Area)
                return 0;
            else
                return 1;
        }
    }

    public class ControVariance
    {
        public ControVariance()
        {
            IComparer<IShape> areaComparer = new AreaComparer();
            List<Circle> circles = new List<Circle>();
            circles.Add(new Circle(20));
            circles.Add(new Circle(10));
            circles.Sort(areaComparer);

 
        }
    }
}
