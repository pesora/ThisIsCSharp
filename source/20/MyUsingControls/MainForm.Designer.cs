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
            tbDummy = new TrackBar();
            pgDummy = new ProgressBar();
            grpBar = new GroupBox();
            grpForm = new GroupBox();
            btnMsgBox = new Button();
            btnModaless = new Button();
            btnModal = new Button();
            tvDummy = new TreeView();
            lvDummy = new ListView();
            btnAddRoot = new Button();
            btnAddChild = new Button();
            grpTreeList = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbDummy).BeginInit();
            grpBar.SuspendLayout();
            grpForm.SuspendLayout();
            grpTreeList.SuspendLayout();
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
            txtSampleText.Location = new Point(50, 70);
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
            groupBox1.Size = new Size(330, 113);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "ComboBox, CheckBox, TextBox";
            // 
            // tbDummy
            // 
            tbDummy.Location = new Point(28, 22);
            tbDummy.Maximum = 20;
            tbDummy.Name = "tbDummy";
            tbDummy.Size = new Size(292, 45);
            tbDummy.TabIndex = 6;
            tbDummy.Scroll += tbDummy_Scroll;
            // 
            // pgDummy
            // 
            pgDummy.Location = new Point(28, 63);
            pgDummy.Maximum = 20;
            pgDummy.Name = "pgDummy";
            pgDummy.Size = new Size(283, 21);
            pgDummy.TabIndex = 7;
            // 
            // grpBar
            // 
            grpBar.Controls.Add(pgDummy);
            grpBar.Controls.Add(tbDummy);
            grpBar.Location = new Point(34, 158);
            grpBar.Name = "grpBar";
            grpBar.Size = new Size(333, 101);
            grpBar.TabIndex = 8;
            grpBar.TabStop = false;
            grpBar.Text = "TrackBar && ProgressBar";
            // 
            // grpForm
            // 
            grpForm.Controls.Add(btnMsgBox);
            grpForm.Controls.Add(btnModaless);
            grpForm.Controls.Add(btnModal);
            grpForm.Location = new Point(34, 275);
            grpForm.Name = "grpForm";
            grpForm.Size = new Size(335, 77);
            grpForm.TabIndex = 9;
            grpForm.TabStop = false;
            grpForm.Text = "Modal && Modaless";
            // 
            // btnMsgBox
            // 
            btnMsgBox.Location = new Point(190, 32);
            btnMsgBox.Name = "btnMsgBox";
            btnMsgBox.Size = new Size(117, 27);
            btnMsgBox.TabIndex = 2;
            btnMsgBox.Text = "MessageBox";
            btnMsgBox.UseVisualStyleBackColor = true;
            btnMsgBox.Click += btnMsgBox_Click;
            // 
            // btnModaless
            // 
            btnModaless.Location = new Point(111, 32);
            btnModaless.Name = "btnModaless";
            btnModaless.Size = new Size(73, 27);
            btnModaless.TabIndex = 1;
            btnModaless.Text = "Modaless";
            btnModaless.UseVisualStyleBackColor = true;
            btnModaless.Click += btnModaless_Click;
            // 
            // btnModal
            // 
            btnModal.Location = new Point(20, 32);
            btnModal.Name = "btnModal";
            btnModal.Size = new Size(85, 27);
            btnModal.TabIndex = 0;
            btnModal.Text = "Modal";
            btnModal.UseVisualStyleBackColor = true;
            btnModal.Click += btnModal_Click;
            // 
            // tvDummy
            // 
            tvDummy.Location = new Point(21, 38);
            tvDummy.Name = "tvDummy";
            tvDummy.Size = new Size(140, 143);
            tvDummy.TabIndex = 10;
            // 
            // lvDummy
            // 
            lvDummy.Location = new Point(167, 38);
            lvDummy.Name = "lvDummy";
            lvDummy.Size = new Size(141, 143);
            lvDummy.TabIndex = 11;
            lvDummy.UseCompatibleStateImageBehavior = false;
            lvDummy.View = View.Details;
            // 
            // btnAddRoot
            // 
            btnAddRoot.Location = new Point(21, 187);
            btnAddRoot.Name = "btnAddRoot";
            btnAddRoot.Size = new Size(74, 31);
            btnAddRoot.TabIndex = 12;
            btnAddRoot.Text = "루트 추가";
            btnAddRoot.UseVisualStyleBackColor = true;
            btnAddRoot.Click += btnAddRoot_Click;
            // 
            // btnAddChild
            // 
            btnAddChild.Location = new Point(101, 187);
            btnAddChild.Name = "btnAddChild";
            btnAddChild.Size = new Size(70, 31);
            btnAddChild.TabIndex = 13;
            btnAddChild.Text = "자식 추가";
            btnAddChild.UseVisualStyleBackColor = true;
            btnAddChild.Click += btnAddChild_Click;
            // 
            // grpTreeList
            // 
            grpTreeList.Controls.Add(btnAddChild);
            grpTreeList.Controls.Add(btnAddRoot);
            grpTreeList.Controls.Add(lvDummy);
            grpTreeList.Controls.Add(tvDummy);
            grpTreeList.Location = new Point(34, 376);
            grpTreeList.Name = "grpTreeList";
            grpTreeList.Size = new Size(335, 228);
            grpTreeList.TabIndex = 14;
            grpTreeList.TabStop = false;
            grpTreeList.Text = "TreeView && ListView";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 617);
            Controls.Add(grpTreeList);
            Controls.Add(grpForm);
            Controls.Add(grpBar);
            Controls.Add(groupBox1);
            Name = "MainForm";
            Text = "Control Test";
            Load += MainForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbDummy).EndInit();
            grpBar.ResumeLayout(false);
            grpBar.PerformLayout();
            grpForm.ResumeLayout(false);
            grpTreeList.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private ComboBox cboFont;
        private CheckBox chkBold;
        private CheckBox chkItalic;
        private TextBox txtSampleText;
        private GroupBox groupBox1;
        private TrackBar tbDummy;
        private ProgressBar pgDummy;
        private GroupBox grpBar;
        private GroupBox grpForm;
        private Button btnMsgBox;
        private Button btnModaless;
        private Button btnModal;
        private TreeView tvDummy;
        private ListView lvDummy;
        private Button btnAddRoot;
        private Button btnAddChild;
        private GroupBox grpTreeList;
    }
}