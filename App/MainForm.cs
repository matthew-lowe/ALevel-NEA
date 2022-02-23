using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using LiveChartsCore;
using LiveChartsCore.Defaults;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.WinForms;
using MathsLibrary;
using MathsLibrary.Interpreter;

namespace App
{
    public partial class MainForm : Form
    {
        private readonly double _resolution = 0.1;

        private CartesianChart _chart;
        private Interpreter _interpreter;

        public MainForm()
        {
            InitializeComponent();
            _interpreter = new Interpreter();
            
            var size = chartContainer.Size;
            var location = chartContainer.Location;

            var series = new LineSeries<ObservablePoint>();
            var points = new List<ObservablePoint>();

            for (var i = -Math.PI; i < Math.PI; i += _resolution)
            {
                points.Add(new ObservablePoint(i, Math.Exp(i)));
            }

            series.Values = points.ToArray();
            series.Fill = null;
            series.GeometrySize = 0;

            _chart = new CartesianChart
            {
                Size = size,
                Location = location,
                Series = new ISeries[] {series},
            };
            
            Controls.Add(_chart);
            chartContainer.Visible = false;
        }

        private void plotButton_Click_1(object sender, EventArgs e)
        {
            string function = functionTextBox.Text;
            string lower_text = xLowerTextBox.Text;
            string upper_text = xUpperTextBox.Text;
            
            double upper_bound = _interpreter.Interpret(upper_text);
            double lower_bound = _interpreter.Interpret(lower_text);

            var points = new List<ObservablePoint>();

            try
            {
                for (double i = lower_bound; i < upper_bound; i += _resolution)
                    points.Add(new ObservablePoint(i, _interpreter.Interpret(function, i)));
            }
            catch (Exception)
            {
                functionTextBox.BackColor = Color.IndianRed;
                Console.WriteLine("cum");
                return;
            }

            _chart.Series.First().Values = points;
            functionTextBox.BackColor = SystemColors.Window;
        }

        private void areaCalculateButton_Click(object sender, EventArgs e)
        {
            string function = functionTextBox.Text;
            string lower_text = xLowerTextBox.Text;
            string upper_text = xUpperTextBox.Text;
            string n_text = segmentCountTextBox.Text;
            
            var tree = _interpreter.ToTree(function);
            double lower = _interpreter.Interpret(lower_text);
            double upper = _interpreter.Interpret(upper_text);
            int n = (int) _interpreter.Interpret(n_text);
            
            switch (areaMethodComboBox.Text)
            {
                case "Trapezium":
                    areaLabel.Text =  Integration.Trapezium(tree, lower, upper, n).ToString();
                    break;
                case "Mid-ordinate":
                    areaLabel.Text =  Integration.MidOrdinate(tree, lower, upper, n).ToString();
                    break;
                case "Simpson's":
                    areaLabel.Text =  Integration.Simpsons(tree, lower, upper, n).ToString();
                    break;
                default:
                    areaMethodComboBox.Text = "Trapezium";
                    break;
            }
        }
    }
}