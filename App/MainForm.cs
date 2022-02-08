using System;
using System.Windows.Forms;
using System.Collections.Generic;
using LiveChartsCore;
using LiveChartsCore.Defaults;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.WinForms;

namespace App
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            const double res = 0.1;
            
            InitializeComponent();
            var size = chartContainer.Size;
            var location = chartContainer.Location;

            var series = new LineSeries<ObservablePoint>();
            var points = new List<ObservablePoint>();

            for (var i = -Math.PI; i < Math.PI; i += res)
            {
                points.Add(new ObservablePoint(i, Math.Exp(i)));
            }

            series.Values = points.ToArray();
            series.Fill = null;
            series.GeometrySize = 0;

            var chart = new CartesianChart
            {
                Size = size,
                Location = location,
                Series = new ISeries[] {series},
            };
            
            Controls.Add(chart);
        }
    }
}