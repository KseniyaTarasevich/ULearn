using System;

namespace DistanceTask
{
	public static class DistanceTask
	{
		// Расстояние от точки (x, y) до отрезка AB с координатами A(ax, ay), B(bx, by)
		public static double GetDistanceToSegment(double ax, double ay, double bx, double by, double x, double y)
        {
            if (x == ax && y == ay || x == bx && y == by) return 0.0;
           // double k = (by - ay) / (bx - ax);
           // double b = (ay + by - k * ax - k * bx) / 2;
           // if (y == k * x + b && ax / x == ay / y) return 0;
           // if (y == k * x + b && ax / x != ay / y) 
           if (ax / x != ay / y) return (Math.Min(Math.Sqrt((ax - x) * (ax - x) + (ay - y) * (ay - y)), Math.Sqrt((bx - x) * (bx - x) + (by - y) * (by - y))));
            else if ( ax / x == ay / y) return 0;
            return 1.0;
        }
    }
}