using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.WinForms;

namespace App
{
    public partial class Form1 : Form
    {
        private readonly CartesianChart chart;
        
        
        public Form1()
        {
            InitializeComponent();

            var viewModel = new ChartViewModel();
            
            chart = new CartesianChart
            {
                Series = viewModel.Series,
                
                Location = chartContainer.Location,
                Size = chartContainer.Size, //new Size(500, 450),
                Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Top
            };

            Console.WriteLine((chartContainer.Location + new Size(10, 10)).ToString());
            Console.WriteLine(chartContainer.Size.ToString());
            
            Controls.Add(chart);
        }

        private void chartContainer_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}