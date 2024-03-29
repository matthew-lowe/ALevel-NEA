﻿using System;
using System.Drawing;
using System.Linq;

namespace App
{
    /// <summary>
    /// Represents a series of X and Y values for plotting
    /// </summary>
    public class CoordinateSeries
    {
        public double[] X { get; set; }
        public double[] Y { get; set; }
        public int? ZeroX { get; private set; }
        public int? ZeroY { get; private set; }
        private readonly MainForm _form;

        public CoordinateSeries(double[] x, double[] y, MainForm form)
        {
            X = x;
            Y = y;
            _form = form;
        }

        private bool IsValid => X.Length == Y.Length;

        /// <summary>
        /// Return the contained X and Y value pairs as a series of point coordinates in the graph
        /// </summary>
        /// <param name="area">The area that the graph takes up</param>
        /// <returns>An array of points to be directly plotted</returns>
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
                if (Math.Abs(X[i]) <= _form.Resolution / 2)
                {
                    ZeroX = x;
                }

                if (Math.Abs(Y[i]) <= _form.Resolution / 2)
                {
                    ZeroY = y;
                }
            }

            return points;
        }
    }
}