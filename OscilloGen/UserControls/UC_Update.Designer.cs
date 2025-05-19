namespace OscilloGen.UserControls
{
    partial class UC_Update
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
            FwVersionButton = new Button();
            FwFileButton = new Button();
            FwVersionTextBox = new TextBox();
            FwVersionLabel = new Label();
            FwFileTextBox = new TextBox();
            FwFileLabel = new Label();
            SuspendLayout();
            // 
            // FwVersionButton
            // 
            FwVersionButton.BackColor = Color.FromArgb(31, 30, 68);
            FwVersionButton.FlatStyle = FlatStyle.Flat;
            FwVersionButton.ForeColor = Color.White;
            FwVersionButton.Location = new Point(1154, 584);
            FwVersionButton.Name = "FwVersionButton";
            FwVersionButton.Size = new Size(112, 34);
            FwVersionButton.TabIndex = 11;
            FwVersionButton.Text = "Update";
            FwVersionButton.UseVisualStyleBackColor = false;
            FwVersionButton.Click += FwVersionButton_Click;
            // 
            // FwFileButton
            // 
            FwFileButton.BackColor = Color.FromArgb(31, 30, 68);
            FwFileButton.FlatStyle = FlatStyle.Flat;
            FwFileButton.ForeColor = Color.White;
            FwFileButton.Location = new Point(1153, 385);
            FwFileButton.Name = "FwFileButton";
            FwFileButton.Size = new Size(112, 34);
            FwFileButton.TabIndex = 10;
            FwFileButton.Text = "Browse";
            FwFileButton.UseVisualStyleBackColor = false;
            FwFileButton.Click += FwFileButton_Click;
            // 
            // FwVersionTextBox
            // 
            FwVersionTextBox.Location = new Point(579, 589);
            FwVersionTextBox.Name = "FwVersionTextBox";
            FwVersionTextBox.Size = new Size(546, 31);
            FwVersionTextBox.TabIndex = 9;
            // 
            // FwVersionLabel
            // 
            FwVersionLabel.AutoSize = true;
            FwVersionLabel.Location = new Point(403, 589);
            FwVersionLabel.Name = "FwVersionLabel";
            FwVersionLabel.Size = new Size(147, 25);
            FwVersionLabel.TabIndex = 8;
            FwVersionLabel.Text = "Firmware Version";
            // 
            // FwFileTextBox
            // 
            FwFileTextBox.Location = new Point(540, 387);
            FwFileTextBox.Name = "FwFileTextBox";
            FwFileTextBox.Size = new Size(591, 31);
            FwFileTextBox.TabIndex = 7;
            // 
            // FwFileLabel
            // 
            FwFileLabel.AutoSize = true;
            FwFileLabel.Location = new Point(403, 390);
            FwFileLabel.Name = "FwFileLabel";
            FwFileLabel.Size = new Size(115, 25);
            FwFileLabel.TabIndex = 6;
            FwFileLabel.Text = "Firmware File";
            // 
            // UC_Update
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(FwVersionButton);
            Controls.Add(FwFileButton);
            Controls.Add(FwVersionTextBox);
            Controls.Add(FwVersionLabel);
            Controls.Add(FwFileTextBox);
            Controls.Add(FwFileLabel);
            Name = "UC_Update";
            Size = new Size(1668, 1004);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button FwVersionButton;
        private Button FwFileButton;
        private TextBox FwVersionTextBox;
        private Label FwVersionLabel;
        private TextBox FwFileTextBox;
        private Label FwFileLabel;
    }
}
