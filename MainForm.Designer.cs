namespace ReOrganize
{
    partial class ReOrganizeWindow
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainProgressBar = new System.Windows.Forms.ProgressBar();
            this.progressLabel = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.optionsGroupBox = new System.Windows.Forms.GroupBox();
            this.WarningLabel = new System.Windows.Forms.Label();
            this.outputLocationTxt = new System.Windows.Forms.TextBox();
            this.selectInputLocationBtn = new System.Windows.Forms.Button();
            this.monthYearCheckBox = new System.Windows.Forms.CheckBox();
            this.yearCheckBox = new System.Windows.Forms.CheckBox();
            this.monthCheckBox = new System.Windows.Forms.CheckBox();
            this.inputLocationTxt = new System.Windows.Forms.TextBox();
            this.subdirectoryLabel = new System.Windows.Forms.Label();
            this.inputLocationLabel = new System.Windows.Forms.Label();
            this.selectOutputLocationBtn = new System.Windows.Forms.Button();
            this.outputLocationLabel = new System.Windows.Forms.Label();
            this.processGroupBox = new System.Windows.Forms.GroupBox();
            this.currentFileLabel = new System.Windows.Forms.Label();
            this.stopBtn = new System.Windows.Forms.Button();
            this.optionsGroupBox.SuspendLayout();
            this.processGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainProgressBar
            // 
            this.mainProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainProgressBar.Location = new System.Drawing.Point(69, 48);
            this.mainProgressBar.Name = "mainProgressBar";
            this.mainProgressBar.Size = new System.Drawing.Size(558, 10);
            this.mainProgressBar.TabIndex = 1;
            // 
            // progressLabel
            // 
            this.progressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressLabel.AutoEllipsis = true;
            this.progressLabel.Location = new System.Drawing.Point(233, 30);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(394, 15);
            this.progressLabel.TabIndex = 2;
            this.progressLabel.Text = "Progress...";
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(69, 19);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 12;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // optionsGroupBox
            // 
            this.optionsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.optionsGroupBox.Controls.Add(this.WarningLabel);
            this.optionsGroupBox.Controls.Add(this.outputLocationTxt);
            this.optionsGroupBox.Controls.Add(this.selectInputLocationBtn);
            this.optionsGroupBox.Controls.Add(this.monthYearCheckBox);
            this.optionsGroupBox.Controls.Add(this.yearCheckBox);
            this.optionsGroupBox.Controls.Add(this.monthCheckBox);
            this.optionsGroupBox.Controls.Add(this.inputLocationTxt);
            this.optionsGroupBox.Controls.Add(this.subdirectoryLabel);
            this.optionsGroupBox.Controls.Add(this.inputLocationLabel);
            this.optionsGroupBox.Controls.Add(this.selectOutputLocationBtn);
            this.optionsGroupBox.Controls.Add(this.outputLocationLabel);
            this.optionsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.optionsGroupBox.Name = "optionsGroupBox";
            this.optionsGroupBox.Size = new System.Drawing.Size(705, 140);
            this.optionsGroupBox.TabIndex = 13;
            this.optionsGroupBox.TabStop = false;
            // 
            // WarningLabel
            // 
            this.WarningLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WarningLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.WarningLabel.Location = new System.Drawing.Point(164, 10);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(366, 23);
            this.WarningLabel.TabIndex = 12;
            this.WarningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputLocationTxt
            // 
            this.outputLocationTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputLocationTxt.Location = new System.Drawing.Point(164, 87);
            this.outputLocationTxt.Name = "outputLocationTxt";
            this.outputLocationTxt.Size = new System.Drawing.Size(366, 20);
            this.outputLocationTxt.TabIndex = 7;
            // 
            // selectInputLocationBtn
            // 
            this.selectInputLocationBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectInputLocationBtn.Location = new System.Drawing.Point(535, 34);
            this.selectInputLocationBtn.Name = "selectInputLocationBtn";
            this.selectInputLocationBtn.Size = new System.Drawing.Size(92, 23);
            this.selectInputLocationBtn.TabIndex = 0;
            this.selectInputLocationBtn.Text = "Select Location";
            this.selectInputLocationBtn.UseVisualStyleBackColor = true;
            this.selectInputLocationBtn.Click += new System.EventHandler(this.selectInputLocationBtn_Click);
            // 
            // monthYearCheckBox
            // 
            this.monthYearCheckBox.AutoSize = true;
            this.monthYearCheckBox.Checked = true;
            this.monthYearCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.monthYearCheckBox.Location = new System.Drawing.Point(279, 64);
            this.monthYearCheckBox.Name = "monthYearCheckBox";
            this.monthYearCheckBox.Size = new System.Drawing.Size(102, 17);
            this.monthYearCheckBox.TabIndex = 11;
            this.monthYearCheckBox.Text = "Month and Year";
            this.monthYearCheckBox.UseVisualStyleBackColor = true;
            this.monthYearCheckBox.CheckedChanged += new System.EventHandler(this.monthYearCheckBox_CheckedChanged);
            // 
            // yearCheckBox
            // 
            this.yearCheckBox.AutoSize = true;
            this.yearCheckBox.Checked = true;
            this.yearCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.yearCheckBox.Location = new System.Drawing.Point(164, 64);
            this.yearCheckBox.Name = "yearCheckBox";
            this.yearCheckBox.Size = new System.Drawing.Size(48, 17);
            this.yearCheckBox.TabIndex = 3;
            this.yearCheckBox.Text = "Year";
            this.yearCheckBox.UseVisualStyleBackColor = true;
            this.yearCheckBox.CheckedChanged += new System.EventHandler(this.yearCheckBox_CheckedChanged);
            // 
            // monthCheckBox
            // 
            this.monthCheckBox.AutoSize = true;
            this.monthCheckBox.Location = new System.Drawing.Point(218, 64);
            this.monthCheckBox.Name = "monthCheckBox";
            this.monthCheckBox.Size = new System.Drawing.Size(56, 17);
            this.monthCheckBox.TabIndex = 10;
            this.monthCheckBox.Text = "Month";
            this.monthCheckBox.UseVisualStyleBackColor = true;
            this.monthCheckBox.CheckedChanged += new System.EventHandler(this.monthCheckBox_CheckedChanged);
            // 
            // inputLocationTxt
            // 
            this.inputLocationTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputLocationTxt.Location = new System.Drawing.Point(164, 36);
            this.inputLocationTxt.Name = "inputLocationTxt";
            this.inputLocationTxt.Size = new System.Drawing.Size(366, 20);
            this.inputLocationTxt.TabIndex = 4;
            // 
            // subdirectoryLabel
            // 
            this.subdirectoryLabel.AutoSize = true;
            this.subdirectoryLabel.Location = new System.Drawing.Point(78, 65);
            this.subdirectoryLabel.Name = "subdirectoryLabel";
            this.subdirectoryLabel.Size = new System.Drawing.Size(80, 13);
            this.subdirectoryLabel.TabIndex = 9;
            this.subdirectoryLabel.Text = "Subdirectories :";
            // 
            // inputLocationLabel
            // 
            this.inputLocationLabel.AutoSize = true;
            this.inputLocationLabel.Location = new System.Drawing.Point(80, 39);
            this.inputLocationLabel.Name = "inputLocationLabel";
            this.inputLocationLabel.Size = new System.Drawing.Size(78, 13);
            this.inputLocationLabel.TabIndex = 5;
            this.inputLocationLabel.Text = "Input Location:";
            // 
            // selectOutputLocationBtn
            // 
            this.selectOutputLocationBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectOutputLocationBtn.Location = new System.Drawing.Point(535, 85);
            this.selectOutputLocationBtn.Name = "selectOutputLocationBtn";
            this.selectOutputLocationBtn.Size = new System.Drawing.Size(92, 23);
            this.selectOutputLocationBtn.TabIndex = 8;
            this.selectOutputLocationBtn.Text = "Select Location";
            this.selectOutputLocationBtn.UseVisualStyleBackColor = true;
            this.selectOutputLocationBtn.Click += new System.EventHandler(this.selectOutputLocationBtn_Click);
            // 
            // outputLocationLabel
            // 
            this.outputLocationLabel.AutoSize = true;
            this.outputLocationLabel.Location = new System.Drawing.Point(72, 90);
            this.outputLocationLabel.Name = "outputLocationLabel";
            this.outputLocationLabel.Size = new System.Drawing.Size(86, 13);
            this.outputLocationLabel.TabIndex = 6;
            this.outputLocationLabel.Text = "Output Location:";
            // 
            // processGroupBox
            // 
            this.processGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.processGroupBox.Controls.Add(this.currentFileLabel);
            this.processGroupBox.Controls.Add(this.stopBtn);
            this.processGroupBox.Controls.Add(this.startBtn);
            this.processGroupBox.Controls.Add(this.mainProgressBar);
            this.processGroupBox.Controls.Add(this.progressLabel);
            this.processGroupBox.Location = new System.Drawing.Point(12, 159);
            this.processGroupBox.Name = "processGroupBox";
            this.processGroupBox.Size = new System.Drawing.Size(705, 75);
            this.processGroupBox.TabIndex = 14;
            this.processGroupBox.TabStop = false;
            // 
            // currentFileLabel
            // 
            this.currentFileLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentFileLabel.AutoEllipsis = true;
            this.currentFileLabel.Location = new System.Drawing.Point(233, 16);
            this.currentFileLabel.Name = "currentFileLabel";
            this.currentFileLabel.Size = new System.Drawing.Size(394, 14);
            this.currentFileLabel.TabIndex = 14;
            this.currentFileLabel.Text = "Current File...";
            // 
            // stopBtn
            // 
            this.stopBtn.Enabled = false;
            this.stopBtn.Location = new System.Drawing.Point(150, 19);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(75, 23);
            this.stopBtn.TabIndex = 13;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // ReOrganizeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 251);
            this.Controls.Add(this.processGroupBox);
            this.Controls.Add(this.optionsGroupBox);
            this.MinimumSize = new System.Drawing.Size(495, 290);
            this.Name = "ReOrganizeWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReOrganize";
            this.optionsGroupBox.ResumeLayout(false);
            this.optionsGroupBox.PerformLayout();
            this.processGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ProgressBar mainProgressBar;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.GroupBox optionsGroupBox;
        private System.Windows.Forms.TextBox outputLocationTxt;
        private System.Windows.Forms.Button selectInputLocationBtn;
        private System.Windows.Forms.CheckBox monthYearCheckBox;
        private System.Windows.Forms.CheckBox yearCheckBox;
        private System.Windows.Forms.CheckBox monthCheckBox;
        private System.Windows.Forms.TextBox inputLocationTxt;
        private System.Windows.Forms.Label subdirectoryLabel;
        private System.Windows.Forms.Label inputLocationLabel;
        private System.Windows.Forms.Button selectOutputLocationBtn;
        private System.Windows.Forms.Label outputLocationLabel;
        private System.Windows.Forms.GroupBox processGroupBox;
        private System.Windows.Forms.Label currentFileLabel;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Label WarningLabel;
    }
}

