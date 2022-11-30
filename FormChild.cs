    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using System.Drawing.Text;
    using System.Collections;
    using System.IO;

    namespace Notepad2022
    {
        public partial class FormChild : Form
        {
            public FormChild()
            {
                InitializeComponent();
            }
            // 窗体加载事件
            private void FormChild_Load(object sender, EventArgs e)
            {
                // 获取系统已安装的字体
                InstalledFontCollection installedFontCollection = new InstalledFontCollection();
                FontFamily[] fontFamilies = installedFontCollection.Families;
                ArrayList arrayList = new ArrayList();
                foreach (FontFamily family in fontFamilies)
                {
                    arrayList.Add(family);
                    toolStripComboBoxFont.Items.Add(family.Name);
                }
            }

            private void toolStripComboBox1_Click(object sender, EventArgs e)
            {

            }
            // 加粗按钮
            private void toolStripButtonBold_Click(object sender, EventArgs e)
            {
                if (textBox.Font.Bold == false)
                {
                    textBox.Font = new Font(textBox.Font, FontStyle.Bold);
                }
                else
                {
                    textBox.Font = new Font(textBox.Font, FontStyle.Regular);
                }
            
            }
            // 倾斜按钮
            private void toolStripButtonItalic_Click(object sender, EventArgs e)
            {
                if (textBox.Font.Italic == false)
                {
                    textBox.Font = new Font(textBox.Font, FontStyle.Italic);
                }
                else
                {
                    textBox.Font = new Font(textBox.Font, FontStyle.Regular);
                }
            }
            // 选择字体的索引
            private void toolStripComboBoxFont_SelectedIndexChanged(object sender, EventArgs e)
            {
                string fontName = toolStripComboBoxFont.Text;
                int size = int.Parse(toolStripComboBoxSize.Text);
                textBox.Font = new Font(fontName, size);
            }
            // 选择字号的索引
            private void toolStripComboBoxSize_SelectedIndexChanged(object sender, EventArgs e)
            {
                string fontName = toolStripComboBoxFont.Text;
                int size = int.Parse(toolStripComboBoxSize.Text);
                textBox.Font = new Font(fontName, size);
            }
            // 手动输入字号
            private void toolStripComboBoxSize_TextChanged(object sender, EventArgs e)
            {
                string fontName = toolStripComboBoxFont.Text;
                int size = int.Parse(toolStripComboBoxSize.Text);
                textBox.Font = new Font(fontName, size);
            }
        // 保存
        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            if (this.Text == "Notepad2022" || this.Text == "Notepad2022*")
            {
                saveFileDialog.Filter = ("文本文档（*.txt）|*.txt");
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    StreamWriter streamWriter = new StreamWriter(filePath, false);
                    streamWriter.Write(textBox.Text);
                    streamWriter.Flush();
                    streamWriter.Close();
                    this.Text = filePath;
                }
            }
            else
            {
                char last_char_of_title = this.Text[this.Text.Length - 1];
                string filePath = this.Text;
                if (last_char_of_title == '*')
                {
                    filePath = this.Text.Substring(0, this.Text.Length - 2);
                }
                StreamWriter streamWriter = new StreamWriter(filePath, false);
                streamWriter.Write(textBox.Text);
                streamWriter.Flush();
                streamWriter.Close();
                isNewOpen.Text = "False";
                if (last_char_of_title == '*')
                {
                    this.Text = this.Text.Substring(0, this.Text.Length - 1);
                }
            }
        }
        // 打开文件按钮
        private void toolStripButtonOpen_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = ("文本文档（*.txt）|*.txt");
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                isNewOpen.Text = "True";
                string filePath = openFileDialog.FileName;
                this.Text = filePath;
                StreamReader streamReader = new StreamReader(filePath, Encoding.UTF8);
                string text = streamReader.ReadToEnd();
                textBox.Text = text;
                streamReader.Close();
            }
        }
        // 文本框更新
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            char last_char_of_title = this.Text[this.Text.Length - 1];
            if (last_char_of_title != '*' && isNewOpen.Text != "True")
            {
                this.Text += "*";
            }
            isNewOpen.Text = "False";
        }
        // 关闭子窗口
        private void FormChild_FormClosing(object sender, FormClosingEventArgs e)
        {
            char last_char_of_title = this.Text[this.Text.Length - 1];
            if (last_char_of_title == '*')
            {
                DialogResult dialogResult = MessageBox.Show("文件未保存，是否直接退出？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Dispose();
                }
                else
                {
                    e.Cancel = true;
                }

            }
        }
        // 松开按键
        private void FormChild_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
            {
                isCtrlDown.Text = "False";
            }
        }
        // 按下按键
        private void FormChild_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
            {
                isCtrlDown.Text = "True";
            }
            if (e.KeyCode == Keys.S && isCtrlDown.Text == "True")
            {
                this.toolStripButtonSave_Click(sender, e);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            char last_char_of_title = this.Text[this.Text.Length - 1];
            if (last_char_of_title == '*')
            {
                DialogResult dialogResult = MessageBox.Show("文件未保存，是否继续？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    textBox.Text = "";
                    this.Text = "Notepad2022";
                }
                else
                {
                    this.toolStripButtonSave_Click(sender, e);
                }
            }
            else
            {
                textBox.Text = "";
                this.Text = "Notepad2022";
            }
        }
    }
    }
