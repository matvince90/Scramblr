namespace Scramblr
{
    partial class Scramblr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Scramblr));
            this.qBox = new System.Windows.Forms.TextBox();
            this.qLabel = new System.Windows.Forms.Label();
            this.a1 = new System.Windows.Forms.TextBox();
            this.a2 = new System.Windows.Forms.TextBox();
            this.cb3 = new System.Windows.Forms.CheckBox();
            this.a3 = new System.Windows.Forms.TextBox();
            this.cb4 = new System.Windows.Forms.CheckBox();
            this.a4 = new System.Windows.Forms.TextBox();
            this.cb5 = new System.Windows.Forms.CheckBox();
            this.a5 = new System.Windows.Forms.TextBox();
            this.addQ = new System.Windows.Forms.Button();
            this.qList = new System.Windows.Forms.ListBox();
            this.editQ = new System.Windows.Forms.Button();
            this.remQ = new System.Windows.Forms.Button();
            this.generate = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.openDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // qBox
            // 
            this.qBox.Location = new System.Drawing.Point(12, 40);
            this.qBox.Multiline = true;
            this.qBox.Name = "qBox";
            this.qBox.Size = new System.Drawing.Size(260, 43);
            this.qBox.TabIndex = 0;
            this.qBox.TextChanged += new System.EventHandler(this.qBox_TextChanged);
            // 
            // qLabel
            // 
            this.qLabel.AutoSize = true;
            this.qLabel.Location = new System.Drawing.Point(12, 24);
            this.qLabel.Name = "qLabel";
            this.qLabel.Size = new System.Drawing.Size(49, 13);
            this.qLabel.TabIndex = 1;
            this.qLabel.Text = "Question";
            // 
            // a1
            // 
            this.a1.Location = new System.Drawing.Point(32, 89);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(240, 20);
            this.a1.TabIndex = 2;
            this.a1.TextChanged += new System.EventHandler(this.a1_TextChanged);
            // 
            // a2
            // 
            this.a2.Location = new System.Drawing.Point(32, 115);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(240, 20);
            this.a2.TabIndex = 3;
            this.a2.TextChanged += new System.EventHandler(this.a2_TextChanged);
            // 
            // cb3
            // 
            this.cb3.AutoSize = true;
            this.cb3.Location = new System.Drawing.Point(12, 143);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(15, 14);
            this.cb3.TabIndex = 4;
            this.cb3.UseVisualStyleBackColor = true;
            this.cb3.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // a3
            // 
            this.a3.Enabled = false;
            this.a3.Location = new System.Drawing.Point(32, 141);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(240, 20);
            this.a3.TabIndex = 5;
            // 
            // cb4
            // 
            this.cb4.AutoSize = true;
            this.cb4.Location = new System.Drawing.Point(12, 170);
            this.cb4.Name = "cb4";
            this.cb4.Size = new System.Drawing.Size(15, 14);
            this.cb4.TabIndex = 6;
            this.cb4.UseVisualStyleBackColor = true;
            this.cb4.Visible = false;
            this.cb4.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // a4
            // 
            this.a4.Enabled = false;
            this.a4.Location = new System.Drawing.Point(32, 167);
            this.a4.Name = "a4";
            this.a4.Size = new System.Drawing.Size(240, 20);
            this.a4.TabIndex = 7;
            this.a4.Visible = false;
            // 
            // cb5
            // 
            this.cb5.AutoSize = true;
            this.cb5.Location = new System.Drawing.Point(12, 196);
            this.cb5.Name = "cb5";
            this.cb5.Size = new System.Drawing.Size(15, 14);
            this.cb5.TabIndex = 8;
            this.cb5.UseVisualStyleBackColor = true;
            this.cb5.Visible = false;
            this.cb5.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // a5
            // 
            this.a5.Enabled = false;
            this.a5.Location = new System.Drawing.Point(32, 193);
            this.a5.Name = "a5";
            this.a5.Size = new System.Drawing.Size(240, 20);
            this.a5.TabIndex = 9;
            this.a5.Visible = false;
            // 
            // addQ
            // 
            this.addQ.Enabled = false;
            this.addQ.Location = new System.Drawing.Point(82, 220);
            this.addQ.Name = "addQ";
            this.addQ.Size = new System.Drawing.Size(120, 23);
            this.addQ.TabIndex = 10;
            this.addQ.Text = "Add";
            this.addQ.UseVisualStyleBackColor = true;
            this.addQ.Click += new System.EventHandler(this.addQ_Click);
            // 
            // qList
            // 
            this.qList.FormattingEnabled = true;
            this.qList.Location = new System.Drawing.Point(277, 31);
            this.qList.Name = "qList";
            this.qList.Size = new System.Drawing.Size(120, 212);
            this.qList.TabIndex = 12;
            this.qList.SelectedIndexChanged += new System.EventHandler(this.qList_SelectedIndexChanged);
            // 
            // editQ
            // 
            this.editQ.Enabled = false;
            this.editQ.Location = new System.Drawing.Point(277, 248);
            this.editQ.Name = "editQ";
            this.editQ.Size = new System.Drawing.Size(56, 23);
            this.editQ.TabIndex = 13;
            this.editQ.Text = "Edit";
            this.editQ.UseVisualStyleBackColor = true;
            this.editQ.Click += new System.EventHandler(this.editQ_Click);
            // 
            // remQ
            // 
            this.remQ.Enabled = false;
            this.remQ.Location = new System.Drawing.Point(339, 249);
            this.remQ.Name = "remQ";
            this.remQ.Size = new System.Drawing.Size(58, 22);
            this.remQ.TabIndex = 14;
            this.remQ.Text = "Remove";
            this.remQ.UseVisualStyleBackColor = true;
            this.remQ.Click += new System.EventHandler(this.remQ_Click);
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(12, 248);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(260, 23);
            this.generate.TabIndex = 11;
            this.generate.Text = "Generate Test";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(408, 24);
            this.menu.TabIndex = 15;
            this.menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.saveToolStripMenuItem.Text = "Save...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.X)));
            this.clearToolStripMenuItem.ShowShortcutKeys = false;
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // saveDialog
            // 
            this.saveDialog.FileName = "Untitled1.scm";
            this.saveDialog.Filter = "Scramblr Files|*.scm|All files|*.*";
            this.saveDialog.InitialDirectory = "C:\\Scramblr";
            // 
            // openDialog
            // 
            this.openDialog.Filter = "Scramblr Files|*.scm|All files|*.*";
            this.openDialog.InitialDirectory = "C:\\Scramblr";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // Scramblr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(408, 280);
            this.Controls.Add(this.cb5);
            this.Controls.Add(this.cb4);
            this.Controls.Add(this.cb3);
            this.Controls.Add(this.editQ);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.remQ);
            this.Controls.Add(this.qList);
            this.Controls.Add(this.a5);
            this.Controls.Add(this.a4);
            this.Controls.Add(this.a3);
            this.Controls.Add(this.addQ);
            this.Controls.Add(this.a2);
            this.Controls.Add(this.a1);
            this.Controls.Add(this.qLabel);
            this.Controls.Add(this.qBox);
            this.Controls.Add(this.menu);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Name = "Scramblr";
            this.Text = "Scramblr";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox qBox;
        private System.Windows.Forms.Label qLabel;
        private System.Windows.Forms.TextBox a1;
        private System.Windows.Forms.TextBox a2;
        private System.Windows.Forms.Button addQ;
        private System.Windows.Forms.TextBox a3;
        private System.Windows.Forms.TextBox a4;
        private System.Windows.Forms.ListBox qList;
        private System.Windows.Forms.Button remQ;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Button editQ;
        private System.Windows.Forms.TextBox a5;
        private System.Windows.Forms.CheckBox cb3;
        private System.Windows.Forms.CheckBox cb4;
        private System.Windows.Forms.CheckBox cb5;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveDialog;
        private System.Windows.Forms.OpenFileDialog openDialog;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
    }
}

