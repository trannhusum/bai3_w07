using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3_w07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle[] circles = new Circle[3];
            circles[0] = new Circle(3.6);
            circles[1] = new Circle();
            circles[2] = new Circle(3.5, "indigo", false);

            Console.WriteLine("Pre-sorted:");
            foreach (Circle circle in circles)
            {
                Console.WriteLine(circle);
            }

            IComparer<Circle> circleComparator = new CircleComparator();
            Array.Sort(circles, circleComparator);

            Console.WriteLine("After-sorted:");
            foreach (Circle circle in circles)
            {
                Console.WriteLine(circle);
            }
            Console.ReadKey();
        }
    }
    public class CircleComparator : IComparer<Circle>
    {
        public int Compare(Circle c1, Circle c2)
        {
            if (c1.getRadius() > c2.getRadius()) return 1;
            else if (c1.getRadius() < c2.getRadius()) return -1;
            else return 0;
        }
    }
    public class Circle
    {
        public double radius;
        public string color;
        public bool filled;

        public Circle()
        {
        }

        public Circle(double radius)
        {
            this.radius = radius;
        }
        public Circle(double radius, string color, bool filled)
        {
            this.radius = radius;
            this.color = color;
            this.filled = filled;
        }
        public double getRadius()
        {
            return radius;
        }
    }
}
