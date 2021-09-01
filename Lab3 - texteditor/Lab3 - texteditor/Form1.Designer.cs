
namespace Lab3___texteditor
{
    partial class textEditor
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
            this.wholeStatus = new System.Windows.Forms.StatusStrip();
            this.WordsCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusRow = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLetter = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLetterWithSpace = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.closeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.wholeStatus.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wholeStatus
            // 
            this.wholeStatus.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.wholeStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WordsCount,
            this.StatusRow,
            this.StatusLetter,
            this.StatusLetterWithSpace});
            this.wholeStatus.Location = new System.Drawing.Point(0, 404);
            this.wholeStatus.Name = "wholeStatus";
            this.wholeStatus.Size = new System.Drawing.Size(558, 37);
            this.wholeStatus.TabIndex = 0;
            // 
            // WordsCount
            // 
            this.WordsCount.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.WordsCount.Margin = new System.Windows.Forms.Padding(10, 4, 10, 4);
            this.WordsCount.Name = "WordsCount";
            this.WordsCount.Size = new System.Drawing.Size(87, 29);
            this.WordsCount.Text = "Words: 0";
            // 
            // StatusRow
            // 
            this.StatusRow.Margin = new System.Windows.Forms.Padding(10, 4, 10, 4);
            this.StatusRow.Name = "StatusRow";
            this.StatusRow.Size = new System.Drawing.Size(65, 29);
            this.StatusRow.Text = "Row: 0";
            // 
            // StatusLetter
            // 
            this.StatusLetter.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.StatusLetter.Margin = new System.Windows.Forms.Padding(10, 4, 10, 4);
            this.StatusLetter.Name = "StatusLetter";
            this.StatusLetter.Size = new System.Drawing.Size(79, 29);
            this.StatusLetter.Text = "Letter: 0";
            // 
            // StatusLetterWithSpace
            // 
            this.StatusLetterWithSpace.Name = "StatusLetterWithSpace";
            this.StatusLetterWithSpace.Size = new System.Drawing.Size(163, 30);
            this.StatusLetterWithSpace.Text = "Letter with space: 0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(558, 36);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMenu,
            this.openMenu,
            this.saveToolStripMenuItem,
            this.saveAsMenu,
            this.closeMenu});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 30);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newMenu
            // 
            this.newMenu.Name = "newMenu";
            this.newMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newMenu.Size = new System.Drawing.Size(282, 34);
            this.newMenu.Text = "New";
            this.newMenu.Click += new System.EventHandler(this.newMenu_Click);
            // 
            // openMenu
            // 
            this.openMenu.Name = "openMenu";
            this.openMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openMenu.Size = new System.Drawing.Size(282, 34);
            this.openMenu.Text = "Open...";
            this.openMenu.Click += new System.EventHandler(this.openMenu_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(282, 34);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveMenu_Click);
            // 
            // saveAsMenu
            // 
            this.saveAsMenu.Name = "saveAsMenu";
            this.saveAsMenu.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsMenu.Size = new System.Drawing.Size(282, 34);
            this.saveAsMenu.Text = "Save as";
            this.saveAsMenu.Click += new System.EventHandler(this.saveAsMenu_Click);
            // 
            // closeMenu
            // 
            this.closeMenu.Name = "closeMenu";
            this.closeMenu.Size = new System.Drawing.Size(282, 34);
            this.closeMenu.Text = "Close";
            this.closeMenu.Click += new System.EventHandler(this.closeMenu_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox.Location = new System.Drawing.Point(0, 36);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(558, 368);
            this.richTextBox.TabIndex = 2;
            this.richTextBox.Text = "";
            this.richTextBox.TextChanged += new System.EventHandler(this.richTextBox_TextChanged);
            // 
            // textEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 441);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.wholeStatus);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(580, 497);
            this.Name = "textEditor";
            this.Text = "Namnlös - Text Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.textEditor_FormClosing);
            this.wholeStatus.ResumeLayout(false);
            this.wholeStatus.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip wholeStatus;
        private System.Windows.Forms.ToolStripStatusLabel StatusRow;
        private System.Windows.Forms.ToolStripStatusLabel StatusLetter;
        private System.Windows.Forms.ToolStripStatusLabel WordsCount;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMenu;
        private System.Windows.Forms.ToolStripMenuItem saveAsMenu;
        private System.Windows.Forms.ToolStripMenuItem closeMenu;
        private System.Windows.Forms.ToolStripMenuItem newMenu;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel StatusLetterWithSpace;
    }
}

