namespace Notepad2022
{
    partial class FormChild
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChild));
            this.toolStripMark = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonBold = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonItalic = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBoxFont = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBoxSize = new System.Windows.Forms.ToolStripComboBox();
            this.isNewOpen = new System.Windows.Forms.ToolStripLabel();
            this.isCtrlDown = new System.Windows.Forms.ToolStripLabel();
            this.textBox = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripMark.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMark
            // 
            this.toolStripMark.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripMark.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButtonOpen,
            this.toolStripButtonSave,
            this.toolStripButtonBold,
            this.toolStripButtonItalic,
            this.toolStripLabel1,
            this.toolStripComboBoxFont,
            this.toolStripLabel2,
            this.toolStripComboBoxSize,
            this.isNewOpen,
            this.isCtrlDown});
            this.toolStripMark.Location = new System.Drawing.Point(0, 0);
            this.toolStripMark.Name = "toolStripMark";
            this.toolStripMark.Padding = new System.Windows.Forms.Padding(2);
            this.toolStripMark.Size = new System.Drawing.Size(1312, 61);
            this.toolStripMark.TabIndex = 0;
            this.toolStripMark.Text = "toolStrip1";
            // 
            // toolStripButtonOpen
            // 
            this.toolStripButtonOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOpen.Image")));
            this.toolStripButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpen.Name = "toolStripButtonOpen";
            this.toolStripButtonOpen.RightToLeftAutoMirrorImage = true;
            this.toolStripButtonOpen.Size = new System.Drawing.Size(50, 52);
            this.toolStripButtonOpen.Text = "打开";
            this.toolStripButtonOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonOpen.Click += new System.EventHandler(this.toolStripButtonOpen_Click);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(50, 52);
            this.toolStripButtonSave.Text = "保存";
            this.toolStripButtonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // toolStripButtonBold
            // 
            this.toolStripButtonBold.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBold.Image")));
            this.toolStripButtonBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBold.Name = "toolStripButtonBold";
            this.toolStripButtonBold.Size = new System.Drawing.Size(50, 52);
            this.toolStripButtonBold.Text = "加粗";
            this.toolStripButtonBold.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonBold.Click += new System.EventHandler(this.toolStripButtonBold_Click);
            // 
            // toolStripButtonItalic
            // 
            this.toolStripButtonItalic.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonItalic.Image")));
            this.toolStripButtonItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonItalic.Name = "toolStripButtonItalic";
            this.toolStripButtonItalic.Size = new System.Drawing.Size(50, 52);
            this.toolStripButtonItalic.Text = "倾斜";
            this.toolStripButtonItalic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonItalic.Click += new System.EventHandler(this.toolStripButtonItalic_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(46, 52);
            this.toolStripLabel1.Text = "字体";
            // 
            // toolStripComboBoxFont
            // 
            this.toolStripComboBoxFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxFont.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripComboBoxFont.Name = "toolStripComboBoxFont";
            this.toolStripComboBoxFont.Size = new System.Drawing.Size(200, 57);
            this.toolStripComboBoxFont.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxFont_SelectedIndexChanged);
            this.toolStripComboBoxFont.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(46, 52);
            this.toolStripLabel2.Text = "字号";
            // 
            // toolStripComboBoxSize
            // 
            this.toolStripComboBoxSize.Items.AddRange(new object[] {
            "10",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "30"});
            this.toolStripComboBoxSize.Name = "toolStripComboBoxSize";
            this.toolStripComboBoxSize.Size = new System.Drawing.Size(75, 57);
            this.toolStripComboBoxSize.Tag = "";
            this.toolStripComboBoxSize.Text = "10";
            this.toolStripComboBoxSize.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxSize_SelectedIndexChanged);
            this.toolStripComboBoxSize.TextChanged += new System.EventHandler(this.toolStripComboBoxSize_TextChanged);
            // 
            // isNewOpen
            // 
            this.isNewOpen.Name = "isNewOpen";
            this.isNewOpen.Size = new System.Drawing.Size(110, 52);
            this.isNewOpen.Text = "isNewOpen";
            this.isNewOpen.Visible = false;
            // 
            // isCtrlDown
            // 
            this.isCtrlDown.Name = "isCtrlDown";
            this.isCtrlDown.Size = new System.Drawing.Size(104, 52);
            this.isCtrlDown.Text = "isCtrlDown";
            this.isCtrlDown.Visible = false;
            // 
            // textBox
            // 
            this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox.Location = new System.Drawing.Point(0, 61);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(1312, 521);
            this.textBox.TabIndex = 1;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(50, 52);
            this.toolStripButton1.Text = "新建";
            this.toolStripButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // FormChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 582);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.toolStripMark);
            this.KeyPreview = true;
            this.Name = "FormChild";
            this.Text = "Notepad2022";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormChild_FormClosing);
            this.Load += new System.EventHandler(this.FormChild_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormChild_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormChild_KeyUp);
            this.toolStripMark.ResumeLayout(false);
            this.toolStripMark.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStripMark;
        private ToolStripButton toolStripButtonOpen;
        private ToolStripButton toolStripButtonSave;
        private ToolStripButton toolStripButtonBold;
        private ToolStripButton toolStripButtonItalic;
        private ToolStripComboBox toolStripComboBoxFont;
        private ToolStripComboBox toolStripComboBoxSize;
        private TextBox textBox;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private ToolStripLabel toolStripLabel1;
        private ToolStripLabel toolStripLabel2;
        private ToolStripLabel isNewOpen;
        private ToolStripLabel isCtrlDown;
        private ToolStripButton toolStripButton1;
    }
}