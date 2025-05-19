namespace OscilloGen.UserControls
{
    partial class UC_FunctionGenerator
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
            GenButton = new Button();
            OffsetTextBox = new TextBox();
            AmpliTextBox = new TextBox();
            FreqTextBox = new TextBox();
            OffsetLabel = new Label();
            AmpliLabel = new Label();
            FreqLabel = new Label();
            SawRadioButton = new RadioButton();
            TriangleRadioButton = new RadioButton();
            SquareRadioButton = new RadioButton();
            SineRadioButton = new RadioButton();
            NoiseRadioButton = new RadioButton();
            SigTypeLabel = new Label();
            SuspendLayout();
            // 
            // GenButton
            // 
            GenButton.BackColor = Color.FromArgb(31, 30, 68);
            GenButton.FlatStyle = FlatStyle.Flat;
            GenButton.ForeColor = Color.White;
            GenButton.Location = new Point(1108, 754);
            GenButton.Name = "GenButton";
            GenButton.Size = new Size(112, 34);
            GenButton.TabIndex = 25;
            GenButton.Text = "Generate";
            GenButton.UseVisualStyleBackColor = false;
            GenButton.Click += GenButton_Click;
            // 
            // OffsetTextBox
            // 
            OffsetTextBox.Location = new Point(751, 603);
            OffsetTextBox.Name = "OffsetTextBox";
            OffsetTextBox.Size = new Size(150, 31);
            OffsetTextBox.TabIndex = 24;
            // 
            // AmpliTextBox
            // 
            AmpliTextBox.Location = new Point(751, 512);
            AmpliTextBox.Name = "AmpliTextBox";
            AmpliTextBox.Size = new Size(150, 31);
            AmpliTextBox.TabIndex = 23;
            // 
            // FreqTextBox
            // 
            FreqTextBox.Location = new Point(751, 427);
            FreqTextBox.Name = "FreqTextBox";
            FreqTextBox.Size = new Size(150, 31);
            FreqTextBox.TabIndex = 22;
            // 
            // OffsetLabel
            // 
            OffsetLabel.AutoSize = true;
            OffsetLabel.Location = new Point(451, 606);
            OffsetLabel.Name = "OffsetLabel";
            OffsetLabel.Size = new Size(61, 25);
            OffsetLabel.TabIndex = 21;
            OffsetLabel.Text = "Offset";
            // 
            // AmpliLabel
            // 
            AmpliLabel.AutoSize = true;
            AmpliLabel.Location = new Point(449, 518);
            AmpliLabel.Name = "AmpliLabel";
            AmpliLabel.Size = new Size(131, 25);
            AmpliLabel.TabIndex = 20;
            AmpliLabel.Text = "Amplitude (Vp)";
            // 
            // FreqLabel
            // 
            FreqLabel.AutoSize = true;
            FreqLabel.Location = new Point(449, 433);
            FreqLabel.Name = "FreqLabel";
            FreqLabel.Size = new Size(129, 25);
            FreqLabel.TabIndex = 19;
            FreqLabel.Text = "Frequency (Hz)";
            // 
            // SawRadioButton
            // 
            SawRadioButton.AutoSize = true;
            SawRadioButton.Location = new Point(1148, 274);
            SawRadioButton.Name = "SawRadioButton";
            SawRadioButton.Size = new Size(69, 29);
            SawRadioButton.TabIndex = 18;
            SawRadioButton.TabStop = true;
            SawRadioButton.Text = "Saw";
            SawRadioButton.UseVisualStyleBackColor = true;
            // 
            // TriangleRadioButton
            // 
            TriangleRadioButton.AutoSize = true;
            TriangleRadioButton.Location = new Point(962, 276);
            TriangleRadioButton.Name = "TriangleRadioButton";
            TriangleRadioButton.Size = new Size(97, 29);
            TriangleRadioButton.TabIndex = 17;
            TriangleRadioButton.TabStop = true;
            TriangleRadioButton.Text = "Triangle";
            TriangleRadioButton.UseVisualStyleBackColor = true;
            // 
            // SquareRadioButton
            // 
            SquareRadioButton.AutoSize = true;
            SquareRadioButton.Location = new Point(781, 275);
            SquareRadioButton.Name = "SquareRadioButton";
            SquareRadioButton.Size = new Size(92, 29);
            SquareRadioButton.TabIndex = 16;
            SquareRadioButton.TabStop = true;
            SquareRadioButton.Text = "Square";
            SquareRadioButton.UseVisualStyleBackColor = true;
            // 
            // SineRadioButton
            // 
            SineRadioButton.AutoSize = true;
            SineRadioButton.Location = new Point(622, 276);
            SineRadioButton.Name = "SineRadioButton";
            SineRadioButton.Size = new Size(70, 29);
            SineRadioButton.TabIndex = 15;
            SineRadioButton.TabStop = true;
            SineRadioButton.Text = "Sine";
            SineRadioButton.UseVisualStyleBackColor = true;
            // 
            // NoiseRadioButton
            // 
            NoiseRadioButton.AutoSize = true;
            NoiseRadioButton.Location = new Point(451, 275);
            NoiseRadioButton.Name = "NoiseRadioButton";
            NoiseRadioButton.Size = new Size(82, 29);
            NoiseRadioButton.TabIndex = 14;
            NoiseRadioButton.TabStop = true;
            NoiseRadioButton.Text = "Noise";
            NoiseRadioButton.UseVisualStyleBackColor = true;
            // 
            // SigTypeLabel
            // 
            SigTypeLabel.AutoSize = true;
            SigTypeLabel.Location = new Point(449, 217);
            SigTypeLabel.Name = "SigTypeLabel";
            SigTypeLabel.Size = new Size(102, 25);
            SigTypeLabel.TabIndex = 13;
            SigTypeLabel.Text = "Signal Type";
            // 
            // UC_FunctionGenerator
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(GenButton);
            Controls.Add(OffsetTextBox);
            Controls.Add(AmpliTextBox);
            Controls.Add(FreqTextBox);
            Controls.Add(OffsetLabel);
            Controls.Add(AmpliLabel);
            Controls.Add(FreqLabel);
            Controls.Add(SawRadioButton);
            Controls.Add(TriangleRadioButton);
            Controls.Add(SquareRadioButton);
            Controls.Add(SineRadioButton);
            Controls.Add(NoiseRadioButton);
            Controls.Add(SigTypeLabel);
            Name = "UC_FunctionGenerator";
            Size = new Size(1668, 1004);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button GenButton;
        private TextBox OffsetTextBox;
        private TextBox AmpliTextBox;
        private TextBox FreqTextBox;
        private Label OffsetLabel;
        private Label AmpliLabel;
        private Label FreqLabel;
        private RadioButton SawRadioButton;
        private RadioButton TriangleRadioButton;
        private RadioButton SquareRadioButton;
        private RadioButton SineRadioButton;
        private RadioButton NoiseRadioButton;
        private Label SigTypeLabel;
    }
}
