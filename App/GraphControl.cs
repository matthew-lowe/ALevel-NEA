using System;
using System.Drawing;
using System.Windows.Forms;

namespace App
{
    public class GraphControl : Control
    {
        private Pen _pen;

        // An array of the series to draw
        public CoordinateSeries[] Series { get; set; }

        public GraphControl()
        {
            _pen = new Pen(Color.DodgerBlue, 6);
            BackColor = Color.Black;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            
            e.Graphics.DrawCurve(new Pen(Color.Red, 2), Series[0].AsPoints(ClientRectangle));
            
            foreach (var p in Series[0].AsPoints(ClientRectangle))
                e.Graphics.DrawEllipse(new Pen(Color.Aqua), p.X, p.Y, 5, 5);
            
            // Draw the Y-Axis
            if (Series[0].ZeroX != null)
            {
                int zero = (int) Series[0].ZeroX;
                e.Graphics.DrawLine(new Pen(Color.White, 2), zero, 0, zero, ClientSize.Height);
                Console.WriteLine($"Drawing Y-Axis at x={zero}");
            }

            // Draw the X-Axis
            if (Series[0].ZeroY != null)
            {
                int zero = (int) Series[0].ZeroY;
                e.Graphics.DrawLine(new Pen(Color.White, 2), 0, zero, ClientSize.Width, zero);
                Console.WriteLine($"Drawing X-Axis at y={zero}");
            }

            Console.WriteLine(ClientRectangle.ToString());

            // Draw the graph border
            e.Graphics.DrawRectangle(_pen, ClientRectangle);
        }
    }
}