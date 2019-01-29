using System.Linq;
using System.Windows;
using System.Collections.Generic;

namespace ConvexHull.Graham_sA {
    public static class Graham_sAConvexHull {
        private static double ConterClockWise(Point p1, Point p2, Point p3) {
            return (p2.X - p1.X) * (p3.Y - p1.Y) - (p2.Y - p1.Y) * (p3.X - p1.X);
        }
        private static void SortByPolarAngle(List<Point> source) {
            Point point0;
            double minY = source.Min(pointCoordY => pointCoordY.Y);
            var leftPoints = source.Where(point => point.Y == minY);
            if (leftPoints.Count() > 1) {
                double minX = leftPoints.Min(pointCoordX => pointCoordX.X);
                point0 = leftPoints.First(point => point.X == minX);
            } else {
                point0 = leftPoints.First();
            }
            source.Sort(new PolarAngleComparer(point0));
        }
        public static List<Point> ConvexHull(List<Point> source) {
            var result = new Stack<Point>();
            SortByPolarAngle(source);
            result.Push(source[0]);
            result.Push(source[1]);
            for (int i = 2; i < source.Count; i++) {
                while (ConterClockWise(result.ElementAt(1), result.Peek(), source[i]) > 0) {
                    result.Pop();
                }
                result.Push(source[i]);
            }
            return new List<Point>(result);
        }
        class PolarAngleComparer : IComparer<Point> {
            private Point point0;
            public PolarAngleComparer(Point point0) {
                this.point0 = point0;
            }
            public int Compare(Point a, Point b) {
                double angleA = (point0.X - a.X) / (a.Y - point0.Y);
                double angleB = (point0.X - b.X) / (b.Y - point0.Y);
                int result = (-angleA).CompareTo(-angleB);
                if (result == 0) {
                    double distanceA = (a - point0).LengthSquared;
                    double distanceB = (b - point0).LengthSquared;
                    result = distanceA.CompareTo(distanceB);
                }
                return result;
            }
        }
    }
}