namespace App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.chartContainer = new System.Windows.Forms.ContainerControl();
            this.SuspendLayout();
            // 
            // chartContainer
            // 
            this.chartContainer.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.chartContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.chartContainer.Location = new System.Drawing.Point(0, 0);
            this.chartContainer.Name = "chartContainer";
            this.chartContainer.Size = new System.Drawing.Size(690, 559);
            this.chartContainer.TabIndex = 0;
            this.chartContainer.Text = "containerControl1";
            this.chartContainer.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 559);
            this.Controls.Add(this.chartContainer);
            this.Name = "Form1";
            this.Text = "Pogchamp";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ContainerControl chartContainer;

        #endregion
    }
}