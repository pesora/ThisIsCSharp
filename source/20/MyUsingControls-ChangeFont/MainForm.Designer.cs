namespace MyUsingControls
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
            label1 = new Label();
            cboFont = new ComboBox();
            chkBold = new CheckBox();
            chkItalic = new CheckBox();
            txtSampleText = new TextBox();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 34);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "Font :";
            // 
            // cboFont
            // 
            cboFont.FormattingEnabled = true;
            cboFont.Location = new Point(50, 32);
            cboFont.Name = "cboFont";
            cboFont.Size = new Size(132, 23);
            cboFont.TabIndex = 1;
            cboFont.SelectedIndexChanged += cboFont_SelectedIndexChanged;
            // 
            // chkBold
            // 
            chkBold.AutoSize = true;
            chkBold.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            chkBold.Location = new Point(194, 34);
            chkBold.Name = "chkBold";
            chkBold.Size = new Size(50, 19);
            chkBold.TabIndex = 2;
            chkBold.Text = "굵게";
            chkBold.UseVisualStyleBackColor = true;
            chkBold.CheckedChanged += chkBold_CheckedChanged;
            // 
            // chkItalic
            // 
            chkItalic.AutoSize = true;
            chkItalic.Font = new Font("맑은 고딕", 9F, FontStyle.Italic, GraphicsUnit.Point);
            chkItalic.Location = new Point(247, 35);
            chkItalic.Name = "chkItalic";
            chkItalic.Size = new Size(62, 19);
            chkItalic.TabIndex = 3;
            chkItalic.Text = "이탤릭";
            chkItalic.UseVisualStyleBackColor = true;
            chkItalic.CheckedChanged += chkItalic_CheckedChanged;
            // 
            // txtSampleText
            // 
            txtSampleText.Location = new Point(50, 82);
            txtSampleText.Name = "txtSampleText";
            txtSampleText.Size = new Size(236, 23);
            txtSampleText.TabIndex = 4;
            txtSampleText.Text = "Hello, C#";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSampleText);
            groupBox1.Controls.Add(chkItalic);
            groupBox1.Controls.Add(chkBold);
            groupBox1.Controls.Add(cboFont);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(36, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(330, 131);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "ComboBox, CheckBox, TextBox";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 249);
            Controls.Add(groupBox1);
            Name = "MainForm";
            Text = "Control Test";
            Load += MainForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private ComboBox cboFont;
        private CheckBox chkBold;
        private CheckBox chkItalic;
        private TextBox txtSampleText;
        private GroupBox groupBox1;
    }
}