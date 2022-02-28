using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace App
{
    public class CoordinateSeries
    {
        public double[] X { get; set; }
        public double[] Y { get; set; }
        public int? ZeroX { get; private set; }
        public int? ZeroY { get; private set; }

        public CoordinateSeries()
        {
        }

        public CoordinateSeries(double[] x, double[] y)
        {
            X = x;
            Y = y;
        }

        private bool IsValid => X.Length == Y.Length;

        public Point[] AsPoints(Rectangle area)
        {
            if (!IsValid) return null;
            ZeroX = null;
            ZeroY = null;

            var points = new Point[X.Length];

            var xRange = X.Max() - X.Min(); // 5 - (-3) = 8
            var yRange = Y.Max() - Y.Min(); // 5 - (-3) = 8
            
            var yMin = Y.Min() - yRange / 10;
            var yMax = Y.Max() + yRange / 10;

            yRange = yMax - yMin;
            
            for (int i = 0; i < X.Length; i++)
            {
                var xPerc = (X[i] - X.Min()) / xRange; 
                var yPerc = (Y[i] - yMin) / yRange; // Should = 0.5
                
                var x = (int) (xPerc * area.Width);
                var y = (int) (area.Height - yPerc * area.Height); // = 0
                
                var point = new Point
                {
                    X = x, Y = y 
                };
                points[i] = point;

                // It's rare that the value with ever exactly equal 0
                if (Math.Abs(X[i]) <= 0.1)
                {
                    Console.WriteLine($"ZeroX at:\n\tX[i]: {X[i]}\n\tY[i]: {Y[i]}\n\txPerc: {xPerc}\n\tyPerc: {yPerc}\n\t x: {x}\n\t y: {y}");
                    ZeroX = x;
                }

                if (Math.Abs(Y[i]) <= 0.1)
                {
                    Console.WriteLine($"ZeroX at:\n\tX[i]: {X[i]}\n\tY[i]: {Y[i]}\n\txPerc: {xPerc}\n\tyPerc: {yPerc}\n\t x: {x}\n\t y: {y}");
                    ZeroY = y;
                }
            }

            return points;
        }
    }
}