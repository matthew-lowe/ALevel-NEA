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
            this.label2 = new System.Windows.Forms.Label();
            this.xLowerTextBox = new System.Windows.Forms.TextBox();
            this.functionTextBox = new System.Windows.Forms.TextBox();
            this.xUpperTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.plotButton = new System.Windows.Forms.Button();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartContainer
            // 
            this.chartContainer.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.chartContainer.Location = new System.Drawing.Point(15, 41);
            this.chartContainer.Name = "chartContainer";
            this.chartContainer.Size = new System.Drawing.Size(888, 535);
            this.chartContainer.TabIndex = 0;
            this.chartContainer.Text = "containerControl1";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Roboto", 12F);
            this.label2.Location = new System.Drawing.Point(17, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "y =";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // xLowerTextBox
            // 
            this.xLowerTextBox.Font = new System.Drawing.Font("Roboto", 12F);
            this.xLowerTextBox.Location = new System.Drawing.Point(17, 57);
            this.xLowerTextBox.Name = "xLowerTextBox";
            this.xLowerTextBox.Size = new System.Drawing.Size(81, 32);
            this.xLowerTextBox.TabIndex = 6;
            this.xLowerTextBox.Text = "-pi";
            this.xLowerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // functionTextBox
            // 
            this.functionTextBox.Font = new System.Drawing.Font("Roboto", 12F);
            this.functionTextBox.Location = new System.Drawing.Point(68, 10);
            this.functionTextBox.Name = "functionTextBox";
            this.functionTextBox.Size = new System.Drawing.Size(181, 32);
            this.functionTextBox.TabIndex = 1;
            this.functionTextBox.Text = "sin(x)";
            // 
            // xUpperTextBox
            // 
            this.xUpperTextBox.Font = new System.Drawing.Font("Roboto", 12F);
            this.xUpperTextBox.Location = new System.Drawing.Point(168, 57);
            this.xUpperTextBox.Name = "xUpperTextBox";
            this.xUpperTextBox.Size = new System.Drawing.Size(81, 32);
            this.xUpperTextBox.TabIndex = 8;
            this.xUpperTextBox.Text = "pi";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Roboto", 12F);
            this.label4.Location = new System.Drawing.Point(104, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "< x <";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plotButton
            // 
            this.plotButton.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (38)))), ((int) (((byte) (38)))), ((int) (((byte) (38)))));
            this.plotButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.plotButton.FlatAppearance.BorderSize = 0;
            this.plotButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plotButton.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.plotButton.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (184)))), ((int) (((byte) (132)))), ((int) (((byte) (246)))));
            this.plotButton.Location = new System.Drawing.Point(17, 100);
            this.plotButton.Name = "plotButton";
            this.plotButton.Size = new System.Drawing.Size(232, 50);
            this.plotButton.TabIndex = 4;
            this.plotButton.Text = "PLOT";
            this.plotButton.UseVisualStyleBackColor = false;
            this.plotButton.Click += new System.EventHandler(this.plotButton_Click_1);
            // 
            // areaMethodComboBox
            // 
            this.areaMethodComboBox.Font = new System.Drawing.Font("Roboto", 12F);
            this.areaMethodComboBox.FormattingEnabled = true;
            this.areaMethodComboBox.Items.AddRange(new object[] {"Trapezium", "Mid-ordinate", "Simpson\'s"});
            this.areaMethodComboBox.Location = new System.Drawing.Point(17, 37);
            this.areaMethodComboBox.Name = "areaMethodComboBox";
            this.areaMethodComboBox.Size = new System.Drawing.Size(227, 32);
            this.areaMethodComboBox.TabIndex = 9;
            this.areaMethodComboBox.Text = "Select to see area";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Roboto", 12F);
            this.label5.Location = new System.Drawing.Point(17, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Integral Method:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Roboto", 12F);
            this.label6.Location = new System.Drawing.Point(17, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Segment count:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // segmentCountTextBox
            // 
            this.segmentCountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.segmentCountTextBox.Location = new System.Drawing.Point(204, 75);
            this.segmentCountTextBox.Name = "segmentCountTextBox";
            this.segmentCountTextBox.Size = new System.Drawing.Size(40, 30);
            this.segmentCountTextBox.TabIndex = 12;
            this.segmentCountTextBox.Text = "0";
            // 
            // areaLabel
            // 
            this.areaLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.areaLabel.Location = new System.Drawing.Point(106, 185);
            this.areaLabel.Name = "areaLabel";
            this.areaLabel.Size = new System.Drawing.Size(143, 24);
            this.areaLabel.TabIndex = 14;
            this.areaLabel.Text = "N/A";
            this.areaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Roboto", 12F);
            this.label7.Location = new System.Drawing.Point(17, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "Area:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // areaCalculateButton
            // 
            this.areaCalculateButton.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (38)))), ((int) (((byte) (38)))), ((int) (((byte) (38)))));
            this.areaCalculateButton.FlatAppearance.BorderSize = 0;
            this.areaCalculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.areaCalculateButton.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.areaCalculateButton.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (184)))), ((int) (((byte) (132)))), ((int) (((byte) (246)))));
            this.areaCalculateButton.Location = new System.Drawing.Point(17, 120);
            this.areaCalculateButton.Name = "areaCalculateButton";
            this.areaCalculateButton.Size = new System.Drawing.Size(232, 53);
            this.areaCalculateButton.TabIndex = 16;
            this.areaCalculateButton.Text = "CALCULATE INTEGRAL";
            this.areaCalculateButton.UseVisualStyleBackColor = false;
            this.areaCalculateButton.Click += new System.EventHandler(this.areaCalculateButton_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (28)))), ((int) (((byte) (28)))), ((int) (((byte) (28)))));
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.colourLabel, this.colourComboBox, this.toolStripSeparator1, this.graphWidthLabel, this.graphWidthTextBox, this.toolStripSeparator2, this.resolutionLabel, this.resolutionTextBox, this.toolStripSeparator3, this.togglePointsButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1191, 26);
            this.toolStrip.TabIndex = 17;
            this.toolStrip.Text = "toolStrip1";
            // 
            // colourLabel
            // 
            this.colourLabel.Font = new System.Drawing.Font("Roboto", 9F);
            this.colourLabel.Name = "colourLabel";
            this.colourLabel.Size = new System.Drawing.Size(100, 23);
            this.colourLabel.Text = "Graph Colour:";
            // 
            // colourComboBox
            // 
            this.colourComboBox.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (38)))), ((int) (((byte) (38)))), ((int) (((byte) (38)))));
            this.colourComboBox.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold);
            this.colourComboBox.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (227)))), ((int) (((byte) (227)))), ((int) (((byte) (227)))));
            this.colourComboBox.Items.AddRange(new object[] {"Red", "Aqua", "Yellow", "Green", "White", "Pink"});
            this.colourComboBox.Name = "colourComboBox";
            this.colourComboBox.Size = new System.Drawing.Size(75, 26);
            this.colourComboBox.Text = "Red";
            this.colourComboBox.TextChanged += new System.EventHandler(this.colourComboBox_TextChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 26);
            // 
            // graphWidthLabel
            // 
            this.graphWidthLabel.Font = new System.Drawing.Font("Roboto", 9F);
            this.graphWidthLabel.Name = "graphWidthLabel";
            this.graphWidthLabel.Size = new System.Drawing.Size(93, 23);
            this.graphWidthLabel.Text = "Graph Width:";
            // 
            // graphWidthTextBox
            // 
            this.graphWidthTextBox.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (38)))), ((int) (((byte) (38)))), ((int) (((byte) (38)))));
            this.graphWidthTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.graphWidthTextBox.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold);
            this.graphWidthTextBox.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (227)))), ((int) (((byte) (227)))), ((int) (((byte) (227)))));
            this.graphWidthTextBox.Name = "graphWidthTextBox";
            this.graphWidthTextBox.Size = new System.Drawing.Size(25, 26);
            this.graphWidthTextBox.Text = "2";
            this.graphWidthTextBox.TextChanged += new System.EventHandler(this.graphWidthTextBox_TextChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 26);
            // 
            // resolutionLabel
            // 
            this.resolutionLabel.Font = new System.Drawing.Font("Roboto", 9F);
            this.resolutionLabel.Name = "resolutionLabel";
            this.resolutionLabel.Size = new System.Drawing.Size(84, 23);
            this.resolutionLabel.Text = "Resolution:";
            // 
            // resolutionTextBox
            // 
            this.resolutionTextBox.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (38)))), ((int) (((byte) (38)))), ((int) (((byte) (38)))));
            this.resolutionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resolutionTextBox.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold);
            this.resolutionTextBox.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (227)))), ((int) (((byte) (227)))), ((int) (((byte) (227)))));
            this.resolutionTextBox.Name = "resolutionTextBox";
            this.resolutionTextBox.Size = new System.Drawing.Size(50, 26);
            this.resolutionTextBox.Text = "10";
            this.resolutionTextBox.TextChanged += new System.EventHandler(this.resolutionTextBox_TextChanged);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 26);
            // 
            // togglePointsButton
            // 
            this.togglePointsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.togglePointsButton.Font = new System.Drawing.Font("Roboto", 9F);
            this.togglePointsButton.Image = ((System.Drawing.Image) (resources.GetObject("togglePointsButton.Image")));
            this.togglePointsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.togglePointsButton.Name = "togglePointsButton";
            this.togglePointsButton.Size = new System.Drawing.Size(104, 23);
            this.togglePointsButton.Text = "Toggle Points";
            this.togglePointsButton.Click += new System.EventHandler(this.togglePointsButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (28)))), ((int) (((byte) (28)))), ((int) (((byte) (28)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.areaCalculateButton);
            this.panel1.Controls.Add(this.segmentCountTextBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.areaLabel);
            this.panel1.Controls.Add(this.areaMethodComboBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(919, 214);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 219);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (28)))), ((int) (((byte) (28)))), ((int) (((byte) (28)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.xUpperTextBox);
            this.panel2.Controls.Add(this.xLowerTextBox);
            this.panel2.Controls.Add(this.functionTextBox);
            this.panel2.Controls.Add(this.plotButton);
            this.panel2.Location = new System.Drawing.Point(919, 31);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 162);
            this.panel2.TabIndex = 17;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (18)))), ((int) (((byte) (18)))), ((int) (((byte) (18)))));
            this.ClientSize = new System.Drawing.Size(1191, 592);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.chartContainer);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (227)))), ((int) (((byte) (227)))), ((int) (((byte) (227)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox xLowerTextBox;
        private System.Windows.Forms.TextBox xUpperTextBox;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox functionTextBox;

        private System.Windows.Forms.ContainerControl chartContainer;

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}