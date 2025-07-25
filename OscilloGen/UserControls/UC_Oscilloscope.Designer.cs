﻿namespace OscilloGen.UserControls
{
    partial class UC_Oscilloscope
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PlotPanel = new Panel();
            StopButton = new Button();
            StartButton = new Button();
            FftButton = new Button();
            FilterButton = new Button();
            SuspendLayout();
            // 
            // PlotPanel
            // 
            PlotPanel.BackColor = Color.FromArgb(192, 192, 255);
            PlotPanel.Location = new Point(380, 174);
            PlotPanel.Name = "PlotPanel";
            PlotPanel.Size = new Size(909, 579);
            PlotPanel.TabIndex = 5;
            // 
            // StopButton
            // 
            StopButton.BackColor = Color.FromArgb(31, 30, 68);
            StopButton.FlatStyle = FlatStyle.Flat;
            StopButton.ForeColor = Color.White;
            StopButton.Location = new Point(978, 797);
            StopButton.Name = "StopButton";
            StopButton.Size = new Size(112, 34);
            StopButton.TabIndex = 4;
            StopButton.Text = "Stop";
            StopButton.UseVisualStyleBackColor = false;
            StopButton.Click += StopButton_Click;
            // 
            // StartButton
            // 
            StartButton.BackColor = Color.FromArgb(31, 30, 68);
            StartButton.FlatStyle = FlatStyle.Flat;
            StartButton.ForeColor = Color.White;
            StartButton.Location = new Point(1116, 797);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(112, 34);
            StartButton.TabIndex = 3;
            StartButton.Text = "Start";
            StartButton.UseVisualStyleBackColor = false;
            StartButton.Click += StartButton_Click;
            // 
            // FftButton
            // 
            FftButton.BackColor = Color.FromArgb(31, 30, 68);
            FftButton.FlatStyle = FlatStyle.Flat;
            FftButton.ForeColor = Color.White;
            FftButton.Location = new Point(1355, 217);
            FftButton.Name = "FftButton";
            FftButton.Size = new Size(112, 34);
            FftButton.TabIndex = 6;
            FftButton.Text = "FFT";
            FftButton.UseVisualStyleBackColor = false;
            FftButton.Click += FftButton_Click;
            // 
            // FilterButton
            // 
            FilterButton.BackColor = Color.FromArgb(31, 30, 68);
            FilterButton.FlatStyle = FlatStyle.Flat;
            FilterButton.ForeColor = Color.White;
            FilterButton.Location = new Point(1355, 321);
            FilterButton.Name = "FilterButton";
            FilterButton.Size = new Size(112, 34);
            FilterButton.TabIndex = 7;
            FilterButton.Text = "Filter";
            FilterButton.UseVisualStyleBackColor = false;
            FilterButton.Click += FilterButton_Click;
            // 
            // UC_Oscilloscope
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(FilterButton);
            Controls.Add(FftButton);
            Controls.Add(PlotPanel);
            Controls.Add(StopButton);
            Controls.Add(StartButton);
            Name = "UC_Oscilloscope";
            Size = new Size(1668, 1004);
            ResumeLayout(false);
        }

        #endregion

        private Panel PlotPanel;
        private Button StopButton;
        private Button StartButton;
        private Button FftButton;
        private Button FilterButton;
    }
}
