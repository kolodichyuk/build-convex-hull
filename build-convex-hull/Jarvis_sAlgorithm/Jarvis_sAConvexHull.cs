using System.Linq;
using System.Windows;
using System.Collections.Generic;

namespace ConvexHull.Jarvis_sA {
    public class Jarvis_sAConvexHull {
        private static double ConterClockWise(Point p1, Point p2, Point p3) {
            return (p2.X - p1.X) * (p3.Y - p1.Y) - (p2.Y - p1.Y) * (p3.X - p1.X);
        }
        private static Point FindStartPoint(List<Point> source) {
            Point firstPoint;
            double minY = source.Min(pointCoordY => pointCoordY.Y);
            var leftPoints = source.Where(point => point.Y == minY);
            if (leftPoints.Count() > 1) {
                double minX = leftPoints.Min(pointCoordX => pointCoordX.X);
                firstPoint = leftPoints.First(point => point.X == minX);
            } else {
                firstPoint = leftPoints.First();
            }
            return firstPoint;
        }
        public static List<Point> ConvexHull(List<Point> source) {
            var firstPoint = FindStartPoint(source);
            var result = new Stack<Point>();
            source.Remove(firstPoint);
            result.Push(firstPoint);
            Point currentPoint = firstPoint, nextPoint, tryPoint;
            int it = 1, nextIt;
            do {
                nextPoint = firstPoint;
                nextIt = it;
                for (it = 0; it < source.Count; it++) {
                    tryPoint = source[it];
                    if (ConterClockWise(nextPoint, currentPoint, tryPoint) >= 0) {
                        nextPoint = tryPoint;
                        nextIt = it;
                    }
                }
                if (nextPoint != firstPoint) {
                    source.RemoveAt(nextIt);
                    result.Push(nextPoint);
                    currentPoint = nextPoint;
                }
            } while (nextPoint != firstPoint);
            return new List<Point>(result);
        }
    }
}