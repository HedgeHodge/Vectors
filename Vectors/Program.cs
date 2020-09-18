using System;
using System.Diagnostics;

namespace Vectors
{
    class Program
    {
        static Random rand = new Random();

        struct Point
        {
            public int x;
            public int y;
        }

        static Point[] GetPoints(int n=100)
        {
            Point[] points = new Point[n];

            for (int i = 0; i < n; i++)
            {
                points[i] = new Point
                {
                    x = rand.Next(1, 100),
                    y = rand.Next(1, 100)
                };
            }

            return points;
        }

        static double GetDistance(Point A, Point B)
        {
            int width = Math.Abs(A.x) - Math.Abs(B.x);
            int height = Math.Abs(A.y) - Math.Abs(B.y);
            return Math.Sqrt(width * width + height * height);
        }

        static double ShortestDistance()
        {
            Point[] pointArr = GetPoints();

            double shortest = Convert.ToDouble(int.MaxValue);

            for (int i = 0; i < pointArr.Length; i++)
            {
                for (int j = 0; j < pointArr.Length; j++)
                {
                    if(i == j)
                    {
                        continue;
                    }

                    double distance = GetDistance(pointArr[i], pointArr[j]);
                    
                    if(distance < shortest)
                    {
                        shortest = distance;
                    }
                }
            }

            return shortest;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ShortestDistance());
        }
    }
}
