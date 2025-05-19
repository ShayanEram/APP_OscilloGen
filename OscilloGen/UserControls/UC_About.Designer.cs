namespace OscilloGen.UserControls
{
    partial class UC_About
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
            DateLabel = new Label();
            NameLabel = new Label();
            VersionLabel = new Label();
            SuspendLayout();
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Location = new Point(786, 553);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(99, 25);
            DateLabel.TabIndex = 5;
            DateLabel.Text = "2025-2026";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(786, 427);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(96, 25);
            NameLabel.TabIndex = 4;
            NameLabel.Text = "OscilloGen";
            // 
            // VersionLabel
            // 
            VersionLabel.AutoSize = true;
            VersionLabel.Location = new Point(786, 490);
            VersionLabel.Name = "VersionLabel";
            VersionLabel.Size = new Size(86, 25);
            VersionLabel.TabIndex = 3;
            VersionLabel.Text = "Version #";
            // 
            // UC_About
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DateLabel);
            Controls.Add(NameLabel);
            Controls.Add(VersionLabel);
            Name = "UC_About";
            Size = new Size(1668, 1004);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DateLabel;
        private Label NameLabel;
        private Label VersionLabel;
    }
}
