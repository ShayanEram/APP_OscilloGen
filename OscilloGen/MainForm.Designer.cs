namespace OscilloGen
{
    partial class MainForm
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            MenuPanel = new Panel();
            AboutButton = new Button();
            UpdateButton = new Button();
            OscillButton = new Button();
            FuncGenButton = new Button();
            TitlePanel = new Panel();
            TitlePictureBox = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            FunGenPanel = new Panel();
            StopButton = new Button();
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
            OscillPanel = new Panel();
            UpdatePanel = new Panel();
            FwVersionButton = new Button();
            FwFileButton = new Button();
            FwVersionTextBox = new TextBox();
            FwVersionLabel = new Label();
            FwFileTextBox = new TextBox();
            FwFileLabel = new Label();
            AboutPanel = new Panel();
            DateLabel = new Label();
            NameLabel = new Label();
            VersionLabel = new Label();
            StartButton = new Button();
            OStopButton = new Button();
            MenuPanel.SuspendLayout();
            TitlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TitlePictureBox).BeginInit();
            FunGenPanel.SuspendLayout();
            OscillPanel.SuspendLayout();
            UpdatePanel.SuspendLayout();
            AboutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MenuPanel
            // 
            MenuPanel.BackColor = Color.FromArgb(31, 30, 68);
            MenuPanel.Controls.Add(AboutButton);
            MenuPanel.Controls.Add(UpdateButton);
            MenuPanel.Controls.Add(OscillButton);
            MenuPanel.Controls.Add(FuncGenButton);
            MenuPanel.Controls.Add(TitlePanel);
            MenuPanel.Dock = DockStyle.Left;
            MenuPanel.Location = new Point(0, 0);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Size = new Size(220, 1559);
            MenuPanel.TabIndex = 0;
            // 
            // AboutButton
            // 
            AboutButton.Dock = DockStyle.Top;
            AboutButton.FlatAppearance.BorderSize = 0;
            AboutButton.FlatStyle = FlatStyle.Flat;
            AboutButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            AboutButton.ForeColor = Color.White;
            AboutButton.Location = new Point(0, 440);
            AboutButton.Name = "AboutButton";
            AboutButton.Padding = new Padding(10, 0, 20, 0);
            AboutButton.Size = new Size(220, 100);
            AboutButton.TabIndex = 5;
            AboutButton.Text = "About";
            AboutButton.TextAlign = ContentAlignment.MiddleLeft;
            AboutButton.UseVisualStyleBackColor = true;
            // 
            // UpdateButton
            // 
            UpdateButton.Dock = DockStyle.Top;
            UpdateButton.FlatAppearance.BorderSize = 0;
            UpdateButton.FlatStyle = FlatStyle.Flat;
            UpdateButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            UpdateButton.ForeColor = Color.White;
            UpdateButton.Location = new Point(0, 340);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Padding = new Padding(10, 0, 20, 0);
            UpdateButton.Size = new Size(220, 100);
            UpdateButton.TabIndex = 4;
            UpdateButton.Text = "Update";
            UpdateButton.TextAlign = ContentAlignment.MiddleLeft;
            UpdateButton.UseVisualStyleBackColor = true;
            // 
            // OscillButton
            // 
            OscillButton.Dock = DockStyle.Top;
            OscillButton.FlatAppearance.BorderSize = 0;
            OscillButton.FlatStyle = FlatStyle.Flat;
            OscillButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            OscillButton.ForeColor = Color.White;
            OscillButton.Location = new Point(0, 240);
            OscillButton.Name = "OscillButton";
            OscillButton.Padding = new Padding(10, 0, 20, 0);
            OscillButton.Size = new Size(220, 100);
            OscillButton.TabIndex = 3;
            OscillButton.Text = "Oscilloscope";
            OscillButton.TextAlign = ContentAlignment.MiddleLeft;
            OscillButton.UseVisualStyleBackColor = true;
            // 
            // FuncGenButton
            // 
            FuncGenButton.Dock = DockStyle.Top;
            FuncGenButton.FlatAppearance.BorderSize = 0;
            FuncGenButton.FlatStyle = FlatStyle.Flat;
            FuncGenButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            FuncGenButton.ForeColor = Color.White;
            FuncGenButton.Location = new Point(0, 140);
            FuncGenButton.Name = "FuncGenButton";
            FuncGenButton.Padding = new Padding(10, 0, 20, 0);
            FuncGenButton.Size = new Size(220, 100);
            FuncGenButton.TabIndex = 2;
            FuncGenButton.Text = "Function Generator";
            FuncGenButton.TextAlign = ContentAlignment.MiddleLeft;
            FuncGenButton.UseVisualStyleBackColor = true;
            // 
            // TitlePanel
            // 
            TitlePanel.Controls.Add(TitlePictureBox);
            TitlePanel.Dock = DockStyle.Top;
            TitlePanel.Location = new Point(0, 0);
            TitlePanel.Name = "TitlePanel";
            TitlePanel.Size = new Size(220, 140);
            TitlePanel.TabIndex = 1;
            // 
            // TitlePictureBox
            // 
            TitlePictureBox.Dock = DockStyle.Left;
            TitlePictureBox.Image = (Image)resources.GetObject("TitlePictureBox.Image");
            TitlePictureBox.Location = new Point(0, 0);
            TitlePictureBox.Name = "TitlePictureBox";
            TitlePictureBox.Size = new Size(214, 140);
            TitlePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            TitlePictureBox.TabIndex = 0;
            TitlePictureBox.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 25, 62);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(220, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1956, 10);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(26, 25, 62);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(220, 1549);
            panel2.Name = "panel2";
            panel2.Size = new Size(1956, 10);
            panel2.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(26, 25, 62);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(2166, 10);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 1539);
            panel4.TabIndex = 4;
            // 
            // FunGenPanel
            // 
            FunGenPanel.BackColor = Color.Transparent;
            FunGenPanel.BorderStyle = BorderStyle.FixedSingle;
            FunGenPanel.Controls.Add(StopButton);
            FunGenPanel.Controls.Add(GenButton);
            FunGenPanel.Controls.Add(OffsetTextBox);
            FunGenPanel.Controls.Add(AmpliTextBox);
            FunGenPanel.Controls.Add(FreqTextBox);
            FunGenPanel.Controls.Add(OffsetLabel);
            FunGenPanel.Controls.Add(AmpliLabel);
            FunGenPanel.Controls.Add(FreqLabel);
            FunGenPanel.Controls.Add(SawRadioButton);
            FunGenPanel.Controls.Add(TriangleRadioButton);
            FunGenPanel.Controls.Add(SquareRadioButton);
            FunGenPanel.Controls.Add(SineRadioButton);
            FunGenPanel.Controls.Add(NoiseRadioButton);
            FunGenPanel.Controls.Add(SigTypeLabel);
            FunGenPanel.Location = new Point(1216, 764);
            FunGenPanel.Name = "FunGenPanel";
            FunGenPanel.Size = new Size(948, 724);
            FunGenPanel.TabIndex = 5;
            // 
            // StopButton
            // 
            StopButton.Location = new Point(618, 627);
            StopButton.Name = "StopButton";
            StopButton.Size = new Size(112, 34);
            StopButton.TabIndex = 13;
            StopButton.Text = "Stop";
            StopButton.UseVisualStyleBackColor = true;
            // 
            // GenButton
            // 
            GenButton.Location = new Point(756, 627);
            GenButton.Name = "GenButton";
            GenButton.Size = new Size(112, 34);
            GenButton.TabIndex = 12;
            GenButton.Text = "Generate";
            GenButton.UseVisualStyleBackColor = true;
            // 
            // OffsetTextBox
            // 
            OffsetTextBox.Location = new Point(399, 479);
            OffsetTextBox.Name = "OffsetTextBox";
            OffsetTextBox.Size = new Size(150, 31);
            OffsetTextBox.TabIndex = 11;
            // 
            // AmpliTextBox
            // 
            AmpliTextBox.Location = new Point(399, 385);
            AmpliTextBox.Name = "AmpliTextBox";
            AmpliTextBox.Size = new Size(150, 31);
            AmpliTextBox.TabIndex = 10;
            // 
            // FreqTextBox
            // 
            FreqTextBox.Location = new Point(399, 300);
            FreqTextBox.Name = "FreqTextBox";
            FreqTextBox.Size = new Size(150, 31);
            FreqTextBox.TabIndex = 9;
            // 
            // OffsetLabel
            // 
            OffsetLabel.AutoSize = true;
            OffsetLabel.Location = new Point(99, 485);
            OffsetLabel.Name = "OffsetLabel";
            OffsetLabel.Size = new Size(61, 25);
            OffsetLabel.TabIndex = 8;
            OffsetLabel.Text = "Offset";
            // 
            // AmpliLabel
            // 
            AmpliLabel.AutoSize = true;
            AmpliLabel.Location = new Point(97, 391);
            AmpliLabel.Name = "AmpliLabel";
            AmpliLabel.Size = new Size(131, 25);
            AmpliLabel.TabIndex = 7;
            AmpliLabel.Text = "Amplitude (Vp)";
            // 
            // FreqLabel
            // 
            FreqLabel.AutoSize = true;
            FreqLabel.Location = new Point(97, 306);
            FreqLabel.Name = "FreqLabel";
            FreqLabel.Size = new Size(129, 25);
            FreqLabel.TabIndex = 6;
            FreqLabel.Text = "Frequency (Hz)";
            // 
            // SawRadioButton
            // 
            SawRadioButton.AutoSize = true;
            SawRadioButton.Location = new Point(799, 147);
            SawRadioButton.Name = "SawRadioButton";
            SawRadioButton.Size = new Size(69, 29);
            SawRadioButton.TabIndex = 5;
            SawRadioButton.TabStop = true;
            SawRadioButton.Text = "Saw";
            SawRadioButton.UseVisualStyleBackColor = true;
            // 
            // TriangleRadioButton
            // 
            TriangleRadioButton.AutoSize = true;
            TriangleRadioButton.Location = new Point(618, 149);
            TriangleRadioButton.Name = "TriangleRadioButton";
            TriangleRadioButton.Size = new Size(97, 29);
            TriangleRadioButton.TabIndex = 4;
            TriangleRadioButton.TabStop = true;
            TriangleRadioButton.Text = "Triangle";
            TriangleRadioButton.UseVisualStyleBackColor = true;
            // 
            // SquareRadioButton
            // 
            SquareRadioButton.AutoSize = true;
            SquareRadioButton.Location = new Point(426, 148);
            SquareRadioButton.Name = "SquareRadioButton";
            SquareRadioButton.Size = new Size(92, 29);
            SquareRadioButton.TabIndex = 3;
            SquareRadioButton.TabStop = true;
            SquareRadioButton.Text = "Square";
            SquareRadioButton.UseVisualStyleBackColor = true;
            // 
            // SineRadioButton
            // 
            SineRadioButton.AutoSize = true;
            SineRadioButton.Location = new Point(249, 149);
            SineRadioButton.Name = "SineRadioButton";
            SineRadioButton.Size = new Size(70, 29);
            SineRadioButton.TabIndex = 2;
            SineRadioButton.TabStop = true;
            SineRadioButton.Text = "Sine";
            SineRadioButton.UseVisualStyleBackColor = true;
            // 
            // NoiseRadioButton
            // 
            NoiseRadioButton.AutoSize = true;
            NoiseRadioButton.Location = new Point(99, 148);
            NoiseRadioButton.Name = "NoiseRadioButton";
            NoiseRadioButton.Size = new Size(82, 29);
            NoiseRadioButton.TabIndex = 1;
            NoiseRadioButton.TabStop = true;
            NoiseRadioButton.Text = "Noise";
            NoiseRadioButton.UseVisualStyleBackColor = true;
            // 
            // SigTypeLabel
            // 
            SigTypeLabel.AutoSize = true;
            SigTypeLabel.Location = new Point(99, 73);
            SigTypeLabel.Name = "SigTypeLabel";
            SigTypeLabel.Size = new Size(102, 25);
            SigTypeLabel.TabIndex = 0;
            SigTypeLabel.Text = "Signal Type";
            // 
            // OscillPanel
            // 
            OscillPanel.BackColor = Color.Transparent;
            OscillPanel.BorderStyle = BorderStyle.FixedSingle;
            OscillPanel.Controls.Add(OStopButton);
            OscillPanel.Controls.Add(StartButton);
            OscillPanel.Location = new Point(1216, 10);
            OscillPanel.Name = "OscillPanel";
            OscillPanel.Size = new Size(948, 724);
            OscillPanel.TabIndex = 6;
            // 
            // UpdatePanel
            // 
            UpdatePanel.BackColor = Color.Transparent;
            UpdatePanel.BorderStyle = BorderStyle.FixedSingle;
            UpdatePanel.Controls.Add(FwVersionButton);
            UpdatePanel.Controls.Add(FwFileButton);
            UpdatePanel.Controls.Add(FwVersionTextBox);
            UpdatePanel.Controls.Add(FwVersionLabel);
            UpdatePanel.Controls.Add(FwFileTextBox);
            UpdatePanel.Controls.Add(FwFileLabel);
            UpdatePanel.Location = new Point(220, 764);
            UpdatePanel.Name = "UpdatePanel";
            UpdatePanel.Size = new Size(948, 724);
            UpdatePanel.TabIndex = 7;
            // 
            // FwVersionButton
            // 
            FwVersionButton.Location = new Point(797, 343);
            FwVersionButton.Name = "FwVersionButton";
            FwVersionButton.Size = new Size(112, 34);
            FwVersionButton.TabIndex = 5;
            FwVersionButton.Text = "Update";
            FwVersionButton.UseVisualStyleBackColor = true;
            // 
            // FwFileButton
            // 
            FwFileButton.Location = new Point(797, 144);
            FwFileButton.Name = "FwFileButton";
            FwFileButton.Size = new Size(112, 34);
            FwFileButton.TabIndex = 4;
            FwFileButton.Text = "Browse";
            FwFileButton.UseVisualStyleBackColor = true;
            // 
            // FwVersionTextBox
            // 
            FwVersionTextBox.Location = new Point(222, 348);
            FwVersionTextBox.Name = "FwVersionTextBox";
            FwVersionTextBox.Size = new Size(546, 31);
            FwVersionTextBox.TabIndex = 3;
            // 
            // FwVersionLabel
            // 
            FwVersionLabel.AutoSize = true;
            FwVersionLabel.Location = new Point(46, 348);
            FwVersionLabel.Name = "FwVersionLabel";
            FwVersionLabel.Size = new Size(147, 25);
            FwVersionLabel.TabIndex = 2;
            FwVersionLabel.Text = "Firmware Version";
            // 
            // FwFileTextBox
            // 
            FwFileTextBox.Location = new Point(177, 146);
            FwFileTextBox.Name = "FwFileTextBox";
            FwFileTextBox.Size = new Size(591, 31);
            FwFileTextBox.TabIndex = 1;
            // 
            // FwFileLabel
            // 
            FwFileLabel.AutoSize = true;
            FwFileLabel.Location = new Point(46, 149);
            FwFileLabel.Name = "FwFileLabel";
            FwFileLabel.Size = new Size(115, 25);
            FwFileLabel.TabIndex = 0;
            FwFileLabel.Text = "Firmware File";
            // 
            // AboutPanel
            // 
            AboutPanel.BackColor = Color.Transparent;
            AboutPanel.BorderStyle = BorderStyle.FixedSingle;
            AboutPanel.Controls.Add(DateLabel);
            AboutPanel.Controls.Add(NameLabel);
            AboutPanel.Controls.Add(VersionLabel);
            AboutPanel.Location = new Point(220, 10);
            AboutPanel.Name = "AboutPanel";
            AboutPanel.Size = new Size(948, 724);
            AboutPanel.TabIndex = 8;
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Location = new Point(408, 367);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(99, 25);
            DateLabel.TabIndex = 2;
            DateLabel.Text = "2025-2026";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(411, 240);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(96, 25);
            NameLabel.TabIndex = 1;
            NameLabel.Text = "OscilloGen";
            // 
            // VersionLabel
            // 
            VersionLabel.AutoSize = true;
            VersionLabel.Location = new Point(411, 304);
            VersionLabel.Name = "VersionLabel";
            VersionLabel.Size = new Size(86, 25);
            VersionLabel.TabIndex = 0;
            VersionLabel.Text = "Version #";
            // 
            // StartButton
            // 
            StartButton.Location = new Point(756, 641);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(112, 34);
            StartButton.TabIndex = 0;
            StartButton.Text = "Start";
            StartButton.UseVisualStyleBackColor = true;
            // 
            // OStopButton
            // 
            OStopButton.Location = new Point(618, 641);
            OStopButton.Name = "OStopButton";
            OStopButton.Size = new Size(112, 34);
            OStopButton.TabIndex = 1;
            OStopButton.Text = "Stop";
            OStopButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2176, 1559);
            Controls.Add(OscillPanel);
            Controls.Add(UpdatePanel);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(MenuPanel);
            Controls.Add(FunGenPanel);
            Controls.Add(AboutPanel);
            Name = "MainForm";
            Text = "OscilloGen";
            MenuPanel.ResumeLayout(false);
            TitlePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TitlePictureBox).EndInit();
            FunGenPanel.ResumeLayout(false);
            FunGenPanel.PerformLayout();
            OscillPanel.ResumeLayout(false);
            UpdatePanel.ResumeLayout(false);
            UpdatePanel.PerformLayout();
            AboutPanel.ResumeLayout(false);
            AboutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel MenuPanel;
        private Panel TitlePanel;
        private Button AboutButton;
        private Button UpdateButton;
        private Button OscillButton;
        private Button FuncGenButton;
        private PictureBox TitlePictureBox;
        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Panel FunGenPanel;
        private Panel OscillPanel;
        private Panel UpdatePanel;
        private Panel AboutPanel;
        private Label DateLabel;
        private Label NameLabel;
        private Label VersionLabel;
        private Button FwFileButton;
        private TextBox FwVersionTextBox;
        private Label FwVersionLabel;
        private TextBox FwFileTextBox;
        private Label FwFileLabel;
        private Button FwVersionButton;
        private RadioButton NoiseRadioButton;
        private Label SigTypeLabel;
        private RadioButton TriangleRadioButton;
        private RadioButton SquareRadioButton;
        private RadioButton SineRadioButton;
        private Label AmpliLabel;
        private Label FreqLabel;
        private RadioButton SawRadioButton;
        private Label OffsetLabel;
        private Button GenButton;
        private TextBox OffsetTextBox;
        private TextBox AmpliTextBox;
        private TextBox FreqTextBox;
        private Button StopButton;
        private Button OStopButton;
        private Button StartButton;
    }
}
