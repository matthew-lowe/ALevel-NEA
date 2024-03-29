﻿using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using MathsLibrary;
using MathsLibrary.Interpreter;

namespace App
{
    public partial class MainForm : Form
    {
        public double Resolution { get; set; } = 0.1;
        public GraphControl Graph { get; private set; }
        private Settings _setting { get; set; }
        
        private readonly Interpreter _interpreter;

        public MainForm()
        {
            InitializeComponent();
            _interpreter = new Interpreter();
            _setting = new Settings(this);

            var size = chartContainer.Size;
            var location = chartContainer.Location;
            chartContainer.Visible = false;

            Graph = new GraphControl
            {
                Size = size, 
                Location = location,
                Name = "graphControl", 
                TabIndex = 0
            };

            var series = new CoordinateSeries(Array.Empty<double>(), Array.Empty<double>(), this);
            Graph.Series = new[] {series};

            Controls.Add(Graph);
            UpdatePlot();
        }

        public void UpdatePlot()
        {
            string function = functionTextBox.Text;
            string upper_text = xUpperTextBox.Text;
            string lower_text = xLowerTextBox.Text;
            
            double upper_bound = _interpreter.Interpret(upper_text);
            double lower_bound = _interpreter.Interpret(lower_text);

            if (upper_bound - lower_bound < 0)
            {
                functionTextBox.BackColor = Color.IndianRed;
                return;
            }
            
            var X = new List<double>();
            var Y = new List<double>();
            
            try
            {
                for (double i = lower_bound; i < upper_bound; i += Resolution)
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
            Graph.Series[0].X = X.ToArray();
            Graph.Series[0].Y = Y.ToArray();
            Graph.Invalidate();
        }

        private void colourComboBox_TextChanged(object sender, EventArgs e)
        {
            _setting.Colour = Color.FromKnownColor((KnownColor) Enum.Parse(typeof(KnownColor), ((ToolStripComboBox) sender).Text));
        }

        private void graphWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _setting.GraphWidth = (int) _interpreter.Interpret(graphWidthTextBox.Text);
            }
            // If there's something invalid, nothing can be done so just ignore it and move on
            catch (Exception) {}
        }

        private void resolutionTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Reciprocal, so as resolution increases, so does the number of samples (more friendly than entering decimals)
                var res = 1 / _interpreter.Interpret(resolutionTextBox.Text);
                if (0 < res && res <= 1) _setting.Resolution = res;
            }
            catch (Exception) {}
        }
        
        private void togglePointsButton_Click(object sender, EventArgs e)
        {
            _setting.PointsVisible = !_setting.PointsVisible;
        }

        private void plotButton_Click_1(object sender, EventArgs e)
        {
            UpdatePlot();
        }

        private void areaCalculateButton_Click(object sender, EventArgs e)
        {
            string function = functionTextBox.Text;
            string lower_text = xLowerTextBox.Text;
            string upper_text = xUpperTextBox.Text;
            string n_text = segmentCountTextBox.Text;
            
            var tree = _interpreter.ToTree(function);
            double lower_bound = _interpreter.Interpret(lower_text);
            double upper_bound = _interpreter.Interpret(upper_text);
            int n = (int) _interpreter.Interpret(n_text);

            if (n <= 0)
            {
                areaLabel.Text = "INVALID (N >= 1)";
                return;
            }
                
            if (upper_bound - lower_bound < 0)
            {
                functionTextBox.BackColor = Color.IndianRed;
                return;
            }
            
            switch (areaMethodComboBox.Text)
            {
                case "Trapezium":
                    areaLabel.Text =  Integration.Trapezium(tree, lower_bound, upper_bound, n).ToString();
                    break;
                case "Mid-ordinate":
                    areaLabel.Text =  Integration.MidOrdinate(tree, lower_bound, upper_bound, n).ToString();
                    break;
                case "Simpson's":
                    if (n % 2 != 0)
                    {
                        areaLabel.Text = "NOT EVEN";
                        return;
                    }
                    areaLabel.Text =  Integration.Simpsons(tree, lower_bound, upper_bound, n).ToString();
                    break;
                default:
                    areaMethodComboBox.Text = "Trapezium";
                    break;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }
    }
}