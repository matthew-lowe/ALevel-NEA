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
            this.chartContainer = new System.Windows.Forms.ContainerControl();
            this.functionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.plotButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.xLowerTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.xUpperTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chartContainer
            // 
            this.chartContainer.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.chartContainer.Location = new System.Drawing.Point(12, 12);
            this.chartContainer.Name = "chartContainer";
            this.chartContainer.Size = new System.Drawing.Size(654, 426);
            this.chartContainer.TabIndex = 0;
            this.chartContainer.Text = "containerControl1";
            // 
            // functionTextBox
            // 
            this.functionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.functionTextBox.Location = new System.Drawing.Point(732, 45);
            this.functionTextBox.Name = "functionTextBox";
            this.functionTextBox.Size = new System.Drawing.Size(237, 30);
            this.functionTextBox.TabIndex = 1;
            this.functionTextBox.Text = "69x + 420";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(683, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Function:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(686, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "y =";
            // 
            // plotButton
            // 
            this.plotButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.plotButton.Location = new System.Drawing.Point(686, 181);
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
            this.label3.Location = new System.Drawing.Point(686, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "X-value range:";
            // 
            // xLowerTextBox
            // 
            this.xLowerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.xLowerTextBox.Location = new System.Drawing.Point(686, 130);
            this.xLowerTextBox.Name = "xLowerTextBox";
            this.xLowerTextBox.Size = new System.Drawing.Size(27, 30);
            this.xLowerTextBox.TabIndex = 6;
            this.xLowerTextBox.Text = "-5";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.Location = new System.Drawing.Point(719, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "< x <";
            // 
            // xUpperTextBox
            // 
            this.xUpperTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.xUpperTextBox.Location = new System.Drawing.Point(783, 130);
            this.xUpperTextBox.Name = "xUpperTextBox";
            this.xUpperTextBox.Size = new System.Drawing.Size(27, 30);
            this.xUpperTextBox.TabIndex = 8;
            this.xUpperTextBox.Text = "5";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 450);
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
            this.ResumeLayout(false);
            this.PerformLayout();
        }

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