using System.Collections.Generic;
using System.Drawing;
using LiveChartsCore;
using LiveChartsCore.Drawing;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Drawing.Geometries;

namespace App
{
    public class ChartViewModel
    {
        public List<ISeries> Series { get; set; } = new List<ISeries>
        {
            new LineSeries<double, RectangleGeometry>
            {
                Values = new List<double> {3, 3, -3, -2, -4, -3, -1},
                Fill = null,
                GeometryFill = null,
                GeometryStroke = null,
                GeometrySize = 10,
                DataPadding = new LvcPoint(0, 1),
                LineSmoothness = 1,
            },
        };
    }
}