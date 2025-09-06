namespace AddonsLoadHelperGUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            mainToolStrip = new ToolStrip();
            lbl_location = new ToolStripLabel();
            tb_location = new ToolStripTextBox();
            toolStripSeparator1 = new ToolStripSeparator();
            btn_browser = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btn_language = new ToolStripDropDownButton();
            btn_language_chinese = new ToolStripMenuItem();
            btn_language_english = new ToolStripMenuItem();
            btn_read = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            btn_write = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            folderBrowserDialog = new FolderBrowserDialog();
            mainStatusStrip = new StatusStrip();
            lbl_author = new ToolStripStatusLabel();
            pb_read = new ToolStripProgressBar();
            columnHeader1 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            lv_addons = new ListView();
            columnHeader2 = new ColumnHeader();
            mainToolStrip.SuspendLayout();
            mainStatusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // mainToolStrip
            // 
            mainToolStrip.BackColor = SystemColors.Control;
            mainToolStrip.GripStyle = ToolStripGripStyle.Hidden;
            mainToolStrip.ImageScalingSize = new Size(32, 32);
            mainToolStrip.Items.AddRange(new ToolStripItem[] { lbl_location, tb_location, toolStripSeparator1, btn_browser, toolStripSeparator2, btn_language, btn_read, toolStripSeparator3, btn_write, toolStripSeparator4 });
            resources.ApplyResources(mainToolStrip, "mainToolStrip");
            mainToolStrip.Name = "mainToolStrip";
            // 
            // lbl_location
            // 
            lbl_location.Name = "lbl_location";
            resources.ApplyResources(lbl_location, "lbl_location");
            // 
            // tb_location
            // 
            tb_location.Name = "tb_location";
            resources.ApplyResources(tb_location, "tb_location");
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(toolStripSeparator1, "toolStripSeparator1");
            // 
            // btn_browser
            // 
            btn_browser.BackColor = SystemColors.ButtonFace;
            btn_browser.DisplayStyle = ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(btn_browser, "btn_browser");
            btn_browser.Margin = new Padding(0);
            btn_browser.Name = "btn_browser";
            btn_browser.Click += btn_browser_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(toolStripSeparator2, "toolStripSeparator2");
            // 
            // btn_language
            // 
            btn_language.Alignment = ToolStripItemAlignment.Right;
            btn_language.BackColor = SystemColors.Control;
            btn_language.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btn_language.DropDownItems.AddRange(new ToolStripItem[] { btn_language_chinese, btn_language_english });
            resources.ApplyResources(btn_language, "btn_language");
            btn_language.Margin = new Padding(0);
            btn_language.Name = "btn_language";
            // 
            // btn_language_chinese
            // 
            btn_language_chinese.Name = "btn_language_chinese";
            resources.ApplyResources(btn_language_chinese, "btn_language_chinese");
            btn_language_chinese.Click += btn_language_chinese_Click;
            // 
            // btn_language_english
            // 
            btn_language_english.Name = "btn_language_english";
            resources.ApplyResources(btn_language_english, "btn_language_english");
            btn_language_english.Click += btn_language_english_Click;
            // 
            // btn_read
            // 
            btn_read.DisplayStyle = ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(btn_read, "btn_read");
            btn_read.Margin = new Padding(0);
            btn_read.Name = "btn_read";
            btn_read.Click += btn_read_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(toolStripSeparator3, "toolStripSeparator3");
            // 
            // btn_write
            // 
            btn_write.DisplayStyle = ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(btn_write, "btn_write");
            btn_write.Margin = new Padding(0);
            btn_write.Name = "btn_write";
            btn_write.Click += btn_write_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(toolStripSeparator4, "toolStripSeparator4");
            // 
            // folderBrowserDialog
            // 
            folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // mainStatusStrip
            // 
            mainStatusStrip.ImageScalingSize = new Size(32, 32);
            mainStatusStrip.Items.AddRange(new ToolStripItem[] { lbl_author, pb_read });
            mainStatusStrip.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            resources.ApplyResources(mainStatusStrip, "mainStatusStrip");
            mainStatusStrip.Name = "mainStatusStrip";
            // 
            // lbl_author
            // 
            lbl_author.Name = "lbl_author";
            resources.ApplyResources(lbl_author, "lbl_author");
            // 
            // pb_read
            // 
            pb_read.Alignment = ToolStripItemAlignment.Right;
            pb_read.Name = "pb_read";
            resources.ApplyResources(pb_read, "pb_read");
            pb_read.Step = 1;
            // 
            // columnHeader1
            // 
            resources.ApplyResources(columnHeader1, "columnHeader1");
            // 
            // columnHeader3
            // 
            resources.ApplyResources(columnHeader3, "columnHeader3");
            // 
            // columnHeader4
            // 
            resources.ApplyResources(columnHeader4, "columnHeader4");
            // 
            // columnHeader5
            // 
            resources.ApplyResources(columnHeader5, "columnHeader5");
            // 
            // lv_addons
            // 
            lv_addons.CheckBoxes = true;
            lv_addons.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            resources.ApplyResources(lv_addons, "lv_addons");
            lv_addons.Name = "lv_addons";
            lv_addons.UseCompatibleStateImageBehavior = false;
            lv_addons.View = View.Details;
            // 
            // columnHeader2
            // 
            resources.ApplyResources(columnHeader2, "columnHeader2");
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lv_addons);
            Controls.Add(mainStatusStrip);
            Controls.Add(mainToolStrip);
            Name = "MainForm";
            Load += mainForm_Load;
            mainToolStrip.ResumeLayout(false);
            mainToolStrip.PerformLayout();
            mainStatusStrip.ResumeLayout(false);
            mainStatusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip mainToolStrip;
        private ToolStripTextBox tb_location;
        private ToolStripLabel lbl_location;
        private ToolStripButton btn_browser;
        private FolderBrowserDialog folderBrowserDialog;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btn_read;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton btn_write;
        private ToolStripSeparator toolStripSeparator4;
        private StatusStrip mainStatusStrip;
        private ToolStripDropDownButton btn_language;
        private ToolStripMenuItem btn_language_chinese;
        private ToolStripMenuItem btn_language_english;
        private ToolStripProgressBar pb_read;
        private ToolStripStatusLabel lbl_author;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ListView lv_addons;
        private ColumnHeader columnHeader2;
    }
}