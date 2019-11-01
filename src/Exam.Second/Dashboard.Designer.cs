namespace Exam.Second
{
    partial class Dashboard
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
            this.datasListBox = new System.Windows.Forms.ListBox();
            this.functionSqueresListBox = new System.Windows.Forms.ListBox();
            this.functionSinsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sequentialFillButton = new System.Windows.Forms.Button();
            this.clearAllButton = new System.Windows.Forms.Button();
            this.parallelFillButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // datasListBox
            // 
            this.datasListBox.FormattingEnabled = true;
            this.datasListBox.Location = new System.Drawing.Point(12, 48);
            this.datasListBox.Name = "datasListBox";
            this.datasListBox.Size = new System.Drawing.Size(200, 264);
            this.datasListBox.TabIndex = 0;
            // 
            // functionSqueresListBox
            // 
            this.functionSqueresListBox.FormattingEnabled = true;
            this.functionSqueresListBox.Location = new System.Drawing.Point(273, 48);
            this.functionSqueresListBox.Name = "functionSqueresListBox";
            this.functionSqueresListBox.Size = new System.Drawing.Size(200, 264);
            this.functionSqueresListBox.TabIndex = 1;
            // 
            // functionSinsListBox
            // 
            this.functionSinsListBox.FormattingEnabled = true;
            this.functionSinsListBox.Location = new System.Drawing.Point(533, 48);
            this.functionSinsListBox.Name = "functionSinsListBox";
            this.functionSinsListBox.Size = new System.Drawing.Size(200, 264);
            this.functionSinsListBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Datas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Function squeres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(530, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Function sins";
            // 
            // sequentialFillButton
            // 
            this.sequentialFillButton.Location = new System.Drawing.Point(323, 383);
            this.sequentialFillButton.Name = "sequentialFillButton";
            this.sequentialFillButton.Size = new System.Drawing.Size(85, 33);
            this.sequentialFillButton.TabIndex = 6;
            this.sequentialFillButton.Text = "Sequential";
            this.sequentialFillButton.UseVisualStyleBackColor = true;
            this.sequentialFillButton.Click += new System.EventHandler(this.SequentialFillButton_Click);
            // 
            // clearAllButton
            // 
            this.clearAllButton.Location = new System.Drawing.Point(127, 383);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(85, 33);
            this.clearAllButton.TabIndex = 7;
            this.clearAllButton.Text = "Clear all";
            this.clearAllButton.UseVisualStyleBackColor = true;
            this.clearAllButton.Click += new System.EventHandler(this.ClearAllButton_Click);
            // 
            // parallelFillButton
            // 
            this.parallelFillButton.Location = new System.Drawing.Point(533, 383);
            this.parallelFillButton.Name = "parallelFillButton";
            this.parallelFillButton.Size = new System.Drawing.Size(85, 33);
            this.parallelFillButton.TabIndex = 8;
            this.parallelFillButton.Text = "Parallel";
            this.parallelFillButton.UseVisualStyleBackColor = true;
            this.parallelFillButton.Click += new System.EventHandler(this.ParallelFillButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(749, 450);
            this.Controls.Add(this.parallelFillButton);
            this.Controls.Add(this.clearAllButton);
            this.Controls.Add(this.sequentialFillButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.functionSinsListBox);
            this.Controls.Add(this.functionSqueresListBox);
            this.Controls.Add(this.datasListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Second exam task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox datasListBox;
        private System.Windows.Forms.ListBox functionSqueresListBox;
        private System.Windows.Forms.ListBox functionSinsListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button sequentialFillButton;
        private System.Windows.Forms.Button clearAllButton;
        private System.Windows.Forms.Button parallelFillButton;
    }
}

