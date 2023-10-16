namespace MyAsyncFileIOWinForm
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
            txtSource = new TextBox();
            txtTarget = new TextBox();
            lblSource = new Label();
            lblTarget = new Label();
            btnFindSource = new Button();
            btnFindTarget = new Button();
            btnAsyncCopy = new Button();
            btnSyncCopy = new Button();
            btnCancel = new Button();
            pbCopy = new ProgressBar();
            SuspendLayout();
            // 
            // txtSource
            // 
            txtSource.Location = new Point(89, 25);
            txtSource.Name = "txtSource";
            txtSource.Size = new Size(232, 23);
            txtSource.TabIndex = 0;
            txtSource.TextChanged += MainForm_Load;
            // 
            // txtTarget
            // 
            txtTarget.Location = new Point(89, 59);
            txtTarget.Name = "txtTarget";
            txtTarget.Size = new Size(232, 23);
            txtTarget.TabIndex = 1;
            // 
            // lblSource
            // 
            lblSource.AutoSize = true;
            lblSource.Location = new Point(36, 33);
            lblSource.Name = "lblSource";
            lblSource.Size = new Size(51, 15);
            lblSource.TabIndex = 2;
            lblSource.Text = "Source :";
            // 
            // lblTarget
            // 
            lblTarget.AutoSize = true;
            lblTarget.Location = new Point(36, 67);
            lblTarget.Name = "lblTarget";
            lblTarget.Size = new Size(47, 15);
            lblTarget.TabIndex = 3;
            lblTarget.Text = "Target :";
            // 
            // btnFindSource
            // 
            btnFindSource.Location = new Point(326, 25);
            btnFindSource.Name = "btnFindSource";
            btnFindSource.Size = new Size(43, 23);
            btnFindSource.TabIndex = 4;
            btnFindSource.Text = "...";
            btnFindSource.UseVisualStyleBackColor = true;
            btnFindSource.Click += btnFindSource_Click;
            // 
            // btnFindTarget
            // 
            btnFindTarget.Location = new Point(327, 59);
            btnFindTarget.Name = "btnFindTarget";
            btnFindTarget.Size = new Size(43, 23);
            btnFindTarget.TabIndex = 5;
            btnFindTarget.Text = "...";
            btnFindTarget.UseVisualStyleBackColor = true;
            btnFindTarget.Click += btnFindTarget_Click;
            // 
            // btnAsyncCopy
            // 
            btnAsyncCopy.Location = new Point(36, 100);
            btnAsyncCopy.Name = "btnAsyncCopy";
            btnAsyncCopy.Size = new Size(93, 23);
            btnAsyncCopy.TabIndex = 6;
            btnAsyncCopy.Text = "Async Copy";
            btnAsyncCopy.UseVisualStyleBackColor = true;
            btnAsyncCopy.Click += btnAsyncCopy_Click;
            // 
            // btnSyncCopy
            // 
            btnSyncCopy.Location = new Point(157, 100);
            btnSyncCopy.Name = "btnSyncCopy";
            btnSyncCopy.Size = new Size(93, 23);
            btnSyncCopy.TabIndex = 7;
            btnSyncCopy.Text = "Sync Copy";
            btnSyncCopy.UseVisualStyleBackColor = true;
            btnSyncCopy.Click += btnSyncCopy_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(276, 100);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(93, 23);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // pbCopy
            // 
            pbCopy.Location = new Point(36, 137);
            pbCopy.Name = "pbCopy";
            pbCopy.Size = new Size(333, 19);
            pbCopy.TabIndex = 9;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 179);
            Controls.Add(pbCopy);
            Controls.Add(btnCancel);
            Controls.Add(btnSyncCopy);
            Controls.Add(btnAsyncCopy);
            Controls.Add(btnFindTarget);
            Controls.Add(btnFindSource);
            Controls.Add(lblTarget);
            Controls.Add(lblSource);
            Controls.Add(txtTarget);
            Controls.Add(txtSource);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSource;
        private TextBox txtTarget;
        private Label lblSource;
        private Label lblTarget;
        private Button btnFindSource;
        private Button btnFindTarget;
        private Button btnAsyncCopy;
        private Button btnSyncCopy;
        private Button btnCancel;
        private ProgressBar pbCopy;
    }
}