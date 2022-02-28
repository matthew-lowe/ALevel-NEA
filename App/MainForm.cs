using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using LiveChartsCore;
using LiveChartsCore.Defaults;
using LiveChartsCore.Geo;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.WinForms;
using MathsLibrary;
using MathsLibrary.Interpreter;

namespace App
{
    public partial class MainForm : Form
    {
        private readonly double _resolution = 0.1;
        private Interpreter _interpreter;
        private GraphControl _graph;

        public MainForm()
        {
            InitializeComponent();
            _interpreter = new Interpreter();

            var size = chartContainer.Size;
            var location = chartContainer.Location;
            chartContainer.Visible = false;

            _graph = new GraphControl();
            _graph.Size = size;
            _graph.Location = location;
            _graph.Name = "graphControl";
            _graph.TabIndex = 0;

            double[] X = {1, 2, 3, 4, 5};
            double[] Y = {1, 2, 3, 2, 1};
            var series = new CoordinateSeries(X, Y);
            _graph.Series = new CoordinateSeries[] {series};

            Controls.Add(_graph);
        }

        private void plotButton_Click_1(object sender, EventArgs e)
        {
            string function = functionTextBox.Text;
            string upper_text = xUpperTextBox.Text;
            string lower_text = xLowerTextBox.Text;
            
            double upper_bound = _interpreter.Interpret(upper_text);
            double lower_bound = _interpreter.Interpret(lower_text);

            var X = new List<double>();
            var Y = new List<double>();
            
            try
            {
                for (double i = lower_bound; i < upper_bound; i += _resolution)
                {
                    X.Add(i);
                    Y.Add(_interpreter.Interpret(function, i));
                }
            }
            catch (Exception)
            {
                functionTextBox.BackColor = Color.IndianRed;
                Console.WriteLine("cum");
                return;
            }

            functionTextBox.BackColor = SystemColors.Window;
            _graph.Series[0].X = X.ToArray();
            _graph.Series[0].Y = Y.ToArray();
            _graph.Invalidate();
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