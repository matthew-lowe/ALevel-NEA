using System.Drawing;
using System.Windows.Forms;

namespace App
{
    public class Settings
    {
        private MainForm _mainForm;
        
        private Color _color;
        private int _graphWidth;
        private double _resolution;
        private bool _pointsVisible;

        // Wrapping them all in properties means the MainForm methods only need to change the Settings class and it'll
        //  take care of all the updating logic
        public Color Colour
        {
            get => _color;
            set
            {
                _color = value;
                _mainForm.Graph.GraphPen.Color = _color;
                _mainForm.Graph.Invalidate();
            }
        }

        public int GraphWidth
        {
            get => _graphWidth;
            set
            {
                _graphWidth = value;
                _mainForm.Graph.GraphPen.Width = _graphWidth;
                _mainForm.Graph.Invalidate();
            }
        }

        public double Resolution
        {
            get => _resolution;
            set
            {
                _resolution = value;
                _mainForm.Resolution = _resolution;
                _mainForm.Graph.Invalidate();
            }
        }

        public bool PointsVisible
        {
            get => _pointsVisible;
            set
            {
                _pointsVisible = value;
                _mainForm.Graph.DrawPoints = _pointsVisible;
                _mainForm.Graph.Invalidate();
            }
        }

        public Settings(MainForm mainForm)
        {
            _mainForm = mainForm;
        }
    }
}