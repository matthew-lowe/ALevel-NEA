using System;
using System.ComponentModel;

namespace App
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.chartContainer = new System.Windows.Forms.ContainerControl();
            this.functionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.plotButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.xLowerTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.xUpperTextBox = new System.Windows.Forms.TextBox();
            this.areaMethodComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.segmentCountTextBox = new System.Windows.Forms.TextBox();
            this.areaLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.areaCalculateButton = new System.Windows.Forms.Button();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.colourLabel = new System.Windows.Forms.ToolStripLabel();
            this.colourComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.graphWidthLabel = new System.Windows.Forms.ToolStripLabel();
            this.graphWidthTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.resolutionLabel = new System.Windows.Forms.ToolStripLabel();
            this.resolutionTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.togglePointsButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartContainer
            // 
            this.chartContainer.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.chartContainer.Location = new System.Drawing.Point(12, 12);
            this.chartContainer.Name = "chartContainer";
            this.chartContainer.Size = new System.Drawing.Size(870, 568);
            this.chartContainer.TabIndex = 0;
            this.chartContainer.Text = "containerControl1";
            // 
            // functionTextBox
            // 
            this.functionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.functionTextBox.Location = new System.Drawing.Point(937, 55);
            this.functionTextBox.Name = "functionTextBox";
            this.functionTextBox.Size = new System.Drawing.Size(237, 30);
            this.functionTextBox.TabIndex = 1;
            this.functionTextBox.Text = "sin(x)";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(888, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Function:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(891, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "y =";
            // 
            // plotButton
            // 
            this.plotButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.plotButton.Location = new System.Drawing.Point(891, 191);
            this.plotButton.Name = "plotButton";
            this.plotButton.Size = new System.Drawing.Size(175, 50);
            this.plotButton.TabIndex = 4;
            this.plotButton.Text = "Plot!";
            this.plotButton.UseVisualStyleBackColor = true;
            this.plotButton.Click += new System.EventHandler(this.plotButton_Click_1);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.Location = new System.Drawing.Point(891, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "X-value range:";
            // 
            // xLowerTextBox
            // 
            this.xLowerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.xLowerTextBox.Location = new System.Drawing.Point(891, 140);
            this.xLowerTextBox.Name = "xLowerTextBox";
            this.xLowerTextBox.Size = new System.Drawing.Size(40, 30);
            this.xLowerTextBox.TabIndex = 6;
            this.xLowerTextBox.Text = "-pi";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.Location = new System.Drawing.Point(937, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "< x <";
            // 
            // xUpperTextBox
            // 
            this.xUpperTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.xUpperTextBox.Location = new System.Drawing.Point(1001, 140);
            this.xUpperTextBox.Name = "xUpperTextBox";
            this.xUpperTextBox.Size = new System.Drawing.Size(40, 30);
            this.xUpperTextBox.TabIndex = 8;
            this.xUpperTextBox.Text = "pi";
            // 
            // areaMethodComboBox
            // 
            this.areaMethodComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.areaMethodComboBox.FormattingEnabled = true;
            this.areaMethodComboBox.Items.AddRange(new object[] {"Trapezium", "Mid-ordinate", "Simpson\'s"});
            this.areaMethodComboBox.Location = new System.Drawing.Point(891, 286);
            this.areaMethodComboBox.Name = "areaMethodComboBox";
            this.areaMethodComboBox.Size = new System.Drawing.Size(227, 33);
            this.areaMethodComboBox.TabIndex = 9;
            this.areaMethodComboBox.Text = "Select to see area";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label5.Location = new System.Drawing.Point(891, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 30);
            this.label5.TabIndex = 10;
            this.label5.Text = "Area calculation method:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label6.Location = new System.Drawing.Point(891, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 30);
            this.label6.TabIndex = 11;
            this.label6.Text = "Segment count:";
            // 
            // segmentCountTextBox
            // 
            this.segmentCountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.segmentCountTextBox.Location = new System.Drawing.Point(1039, 325);
            this.segmentCountTextBox.Name = "segmentCountTextBox";
            this.segmentCountTextBox.Size = new System.Drawing.Size(40, 30);
            this.segmentCountTextBox.TabIndex = 12;
            this.segmentCountTextBox.Text = "0";
            // 
            // areaLabel
            // 
            this.areaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.areaLabel.Location = new System.Drawing.Point(957, 355);
            this.areaLabel.Name = "areaLabel";
            this.areaLabel.Size = new System.Drawing.Size(161, 30);
            this.areaLabel.TabIndex = 14;
            this.areaLabel.Text = "N/A";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label7.Location = new System.Drawing.Point(891, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 30);
            this.label7.TabIndex = 15;
            this.label7.Text = "Area:";
            // 
            // areaCalculateButton
            // 
            this.areaCalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.areaCalculateButton.Location = new System.Drawing.Point(888, 388);
            this.areaCalculateButton.Name = "areaCalculateButton";
            this.areaCalculateButton.Size = new System.Drawing.Size(175, 50);
            this.areaCalculateButton.TabIndex = 16;
            this.areaCalculateButton.Text = "Calculate Area";
            this.areaCalculateButton.UseVisualStyleBackColor = true;
            this.areaCalculateButton.Click += new System.EventHandler(this.areaCalculateButton_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.colourLabel, this.colourComboBox, this.toolStripSeparator1, this.graphWidthLabel, this.graphWidthTextBox, this.toolStripSeparator2, this.resolutionLabel, this.resolutionTextBox, this.toolStripSeparator3, this.togglePointsButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1191, 28);
            this.toolStrip.TabIndex = 17;
            this.toolStrip.Text = "toolStrip1";
            // 
            // colourLabel
            // 
            this.colourLabel.Name = "colourLabel";
            this.colourLabel.Size = new System.Drawing.Size(100, 25);
            this.colourLabel.Text = "Graph Colour:";
            // 
            // colourComboBox
            // 
            this.colourComboBox.Items.AddRange(new object[] {"Red", "Aqua", "Yellow", "Green", "White", "Pink"});
            this.colourComboBox.Name = "colourComboBox";
            this.colourComboBox.Size = new System.Drawing.Size(75, 28);
            this.colourComboBox.Text = "Red";
            this.colourComboBox.TextChanged += new System.EventHandler(this.colourComboBox_TextChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // graphWidthLabel
            // 
            this.graphWidthLabel.Name = "graphWidthLabel";
            this.graphWidthLabel.Size = new System.Drawing.Size(96, 25);
            this.graphWidthLabel.Text = "Graph Width:";
            // 
            // graphWidthTextBox
            // 
            this.graphWidthTextBox.Name = "graphWidthTextBox";
            this.graphWidthTextBox.Size = new System.Drawing.Size(25, 28);
            this.graphWidthTextBox.Text = "2";
            this.graphWidthTextBox.TextChanged += new System.EventHandler(this.graphWidthTextBox_TextChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // resolutionLabel
            // 
            this.resolutionLabel.Name = "resolutionLabel";
            this.resolutionLabel.Size = new System.Drawing.Size(82, 25);
            this.resolutionLabel.Text = "Resolution:";
            // 
            // resolutionTextBox
            // 
            this.resolutionTextBox.Name = "resolutionTextBox";
            this.resolutionTextBox.Size = new System.Drawing.Size(50, 28);
            this.resolutionTextBox.Text = "10";
            this.resolutionTextBox.TextChanged += new System.EventHandler(this.resolutionTextBox_TextChanged);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 28);
            // 
            // togglePointsButton
            // 
            this.togglePointsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.togglePointsButton.Image = ((System.Drawing.Image) (resources.GetObject("togglePointsButton.Image")));
            this.togglePointsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.togglePointsButton.Name = "togglePointsButton";
            this.togglePointsButton.Size = new System.Drawing.Size(102, 25);
            this.togglePointsButton.Text = "Toggle Points";
            this.togglePointsButton.Click += new System.EventHandler(this.togglePointsButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 592);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.areaCalculateButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.areaLabel);
            this.Controls.Add(this.segmentCountTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.areaMethodComboBox);
            this.Controls.Add(this.xUpperTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.xLowerTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.plotButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.functionTextBox);
            this.Controls.Add(this.chartContainer);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripComboBox colourComboBox;
        private System.Windows.Forms.ToolStripTextBox graphWidthTextBox;
        private System.Windows.Forms.ToolStripTextBox resolutionTextBox;
        private System.Windows.Forms.ToolStripButton togglePointsButton;
        private System.Windows.Forms.ToolStripLabel colourLabel;
        private System.Windows.Forms.ToolStripLabel graphWidthLabel;
        private System.Windows.Forms.ToolStripLabel resolutionLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;

        private System.Windows.Forms.ToolStrip toolStrip;


        private System.Windows.Forms.Button areaCalculateButton;

        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.Label areaLabel;

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox segmentCountTextBox;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.ComboBox areaMethodComboBox;

        private System.Windows.Forms.Button plotButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox xLowerTextBox;
        private System.Windows.Forms.TextBox xUpperTextBox;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox functionTextBox;

        private System.Windows.Forms.ContainerControl chartContainer;

        #endregion
    }
}