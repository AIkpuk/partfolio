using System;

namespace Incups
{
    class Point
    {
        double x;
        double y;


        public static Point createPoint(double x, double y)
        {
            var point = new Point();
            point.x = x;
            point.y = y;

            return point;
        }
        public double getDistance(Point other)
        {
            double dx = this.x - other.x;
            double dy = this.y - other.y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = Point.createPoint(1, 2);
            var p2 = Point.createPoint(2, 4);


            var distance = p1.getDistance(p2);
            Console.ReadLine();
        }


    }
}
