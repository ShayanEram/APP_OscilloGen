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
            ConnectionLabel = new Label();
            AboutButton = new Button();
            UpdateButton = new Button();
            OscillButton = new Button();
            FuncGenButton = new Button();
            TitlePanel = new Panel();
            TitlePictureBox = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            MainPanel = new Panel();
            WelcomeLabel = new Label();
            MenuPanel.SuspendLayout();
            TitlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TitlePictureBox).BeginInit();
            MainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MenuPanel
            // 
            MenuPanel.BackColor = Color.FromArgb(31, 30, 68);
            MenuPanel.Controls.Add(ConnectionLabel);
            MenuPanel.Controls.Add(AboutButton);
            MenuPanel.Controls.Add(UpdateButton);
            MenuPanel.Controls.Add(OscillButton);
            MenuPanel.Controls.Add(FuncGenButton);
            MenuPanel.Controls.Add(TitlePanel);
            MenuPanel.Dock = DockStyle.Left;
            MenuPanel.Location = new Point(0, 0);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Size = new Size(220, 1024);
            MenuPanel.TabIndex = 0;
            // 
            // ConnectionLabel
            // 
            ConnectionLabel.AutoSize = true;
            ConnectionLabel.Dock = DockStyle.Bottom;
            ConnectionLabel.Location = new Point(0, 999);
            ConnectionLabel.Name = "ConnectionLabel";
            ConnectionLabel.Size = new Size(102, 25);
            ConnectionLabel.TabIndex = 6;
            ConnectionLabel.Text = "Connection";
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
            AboutButton.Click += AboutButton_Click;
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
            UpdateButton.Click += UpdateButton_Click;
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
            OscillButton.Click += OscillButton_Click;
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
            FuncGenButton.Click += FuncGenButton_Click;
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
            panel1.Size = new Size(1678, 10);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(26, 25, 62);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(220, 1014);
            panel2.Name = "panel2";
            panel2.Size = new Size(1678, 10);
            panel2.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(26, 25, 62);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(1888, 10);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 1004);
            panel4.TabIndex = 4;
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.White;
            MainPanel.Controls.Add(WelcomeLabel);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(220, 10);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1668, 1004);
            MainPanel.TabIndex = 5;
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.AutoSize = true;
            WelcomeLabel.Font = new Font("BankGothic Md BT", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            WelcomeLabel.Location = new Point(580, 465);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(508, 75);
            WelcomeLabel.TabIndex = 0;
            WelcomeLabel.Text = "OscilloGen";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 1024);
            Controls.Add(MainPanel);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(MenuPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "OscilloGen";
            Load += MainForm_Load;
            MenuPanel.ResumeLayout(false);
            MenuPanel.PerformLayout();
            TitlePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TitlePictureBox).EndInit();
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
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
        private Panel MainPanel;
        private Label WelcomeLabel;
        private Label ConnectionLabel;
    }
}
