﻿namespace CodeAdvisor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.exitTSBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.loadFileTSBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.saveFileTSBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.compileTSBtn = new System.Windows.Forms.ToolStripButton();
            this.comNRunTSBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.settingTSBtn = new System.Windows.Forms.ToolStripButton();
            this.aboutTSBtn = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.loadingProg = new System.Windows.Forms.ToolStripProgressBar();
            this.statusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.fileList = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainImageList = new System.Windows.Forms.ImageList(this.components);
            this.fileInfoText = new System.Windows.Forms.RichTextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.editorTab = new System.Windows.Forms.TabControl();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consoleTabs = new System.Windows.Forms.TabControl();
            this.outputTabPage = new System.Windows.Forms.TabPage();
            this.consoleText = new System.Windows.Forms.RichTextBox();
            this.errorTabPage = new System.Windows.Forms.TabPage();
            this.errorText = new System.Windows.Forms.RichTextBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.lookupTSBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteTSBtn = new System.Windows.Forms.ToolStripButton();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.stackList = new System.Windows.Forms.ListView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.question = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.score = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.consoleTabs.SuspendLayout();
            this.outputTabPage.SuspendLayout();
            this.errorTabPage.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitTSBtn,
            this.toolStripSeparator1,
            this.loadFileTSBtn,
            this.toolStripSeparator5,
            this.saveFileTSBtn,
            this.toolStripSeparator2,
            this.compileTSBtn,
            this.comNRunTSBtn,
            this.toolStripSeparator3,
            this.settingTSBtn,
            this.aboutTSBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1512, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // exitTSBtn
            // 
            this.exitTSBtn.Image = global::CodeAdvisor.Properties.Resources.gnome_panel_force_quit;
            this.exitTSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exitTSBtn.Name = "exitTSBtn";
            this.exitTSBtn.Size = new System.Drawing.Size(57, 24);
            this.exitTSBtn.Text = "Exit";
            this.exitTSBtn.Click += new System.EventHandler(this.exitTSBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // loadFileTSBtn
            // 
            this.loadFileTSBtn.Image = global::CodeAdvisor.Properties.Resources.generic_folder;
            this.loadFileTSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.loadFileTSBtn.Name = "loadFileTSBtn";
            this.loadFileTSBtn.Size = new System.Drawing.Size(93, 24);
            this.loadFileTSBtn.Text = "Load File";
            this.loadFileTSBtn.Click += new System.EventHandler(this.loadFileTSBtn_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // saveFileTSBtn
            // 
            this.saveFileTSBtn.Image = global::CodeAdvisor.Properties.Resources.save;
            this.saveFileTSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveFileTSBtn.Name = "saveFileTSBtn";
            this.saveFileTSBtn.Size = new System.Drawing.Size(64, 24);
            this.saveFileTSBtn.Text = "Save";
            this.saveFileTSBtn.Click += new System.EventHandler(this.saveFileTSBtn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // compileTSBtn
            // 
            this.compileTSBtn.Image = global::CodeAdvisor.Properties.Resources.exec;
            this.compileTSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.compileTSBtn.Name = "compileTSBtn";
            this.compileTSBtn.Size = new System.Drawing.Size(89, 24);
            this.compileTSBtn.Text = "Compile";
            this.compileTSBtn.Click += new System.EventHandler(this.compileTSBtn_Click);
            // 
            // comNRunTSBtn
            // 
            this.comNRunTSBtn.Image = global::CodeAdvisor.Properties.Resources.start_here_gnome_blue;
            this.comNRunTSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.comNRunTSBtn.Name = "comNRunTSBtn";
            this.comNRunTSBtn.Size = new System.Drawing.Size(58, 24);
            this.comNRunTSBtn.Text = "Run";
            this.comNRunTSBtn.Click += new System.EventHandler(this.comNRunTSBtn_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // settingTSBtn
            // 
            this.settingTSBtn.Image = global::CodeAdvisor.Properties.Resources.advancedsettings;
            this.settingTSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.settingTSBtn.Name = "settingTSBtn";
            this.settingTSBtn.Size = new System.Drawing.Size(86, 24);
            this.settingTSBtn.Text = "Settings";
            // 
            // aboutTSBtn
            // 
            this.aboutTSBtn.Image = global::CodeAdvisor.Properties.Resources.dialog_question;
            this.aboutTSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aboutTSBtn.Name = "aboutTSBtn";
            this.aboutTSBtn.Size = new System.Drawing.Size(94, 24);
            this.aboutTSBtn.Text = "About Us";
            this.aboutTSBtn.Click += new System.EventHandler(this.aboutTSBtn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadingProg,
            this.statusText});
            this.statusStrip1.Location = new System.Drawing.Point(0, 792);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1512, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // loadingProg
            // 
            this.loadingProg.Name = "loadingProg";
            this.loadingProg.Size = new System.Drawing.Size(267, 20);
            this.loadingProg.Visible = false;
            // 
            // statusText
            // 
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(0, 17);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer5);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1512, 765);
            this.splitContainer1.SplitterDistance = 228;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 2;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.fileList);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.fileInfoText);
            this.splitContainer5.Size = new System.Drawing.Size(228, 765);
            this.splitContainer5.SplitterDistance = 375;
            this.splitContainer5.SplitterWidth = 5;
            this.splitContainer5.TabIndex = 0;
            // 
            // fileList
            // 
            this.fileList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fileList.ContextMenuStrip = this.contextMenuStrip1;
            this.fileList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileList.Location = new System.Drawing.Point(0, 0);
            this.fileList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fileList.MultiSelect = false;
            this.fileList.Name = "fileList";
            this.fileList.Size = new System.Drawing.Size(228, 375);
            this.fileList.SmallImageList = this.mainImageList;
            this.fileList.TabIndex = 1;
            this.fileList.UseCompatibleStateImageBehavior = false;
            this.fileList.View = System.Windows.Forms.View.List;
            this.fileList.DoubleClick += new System.EventHandler(this.fileList_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(129, 56);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openToolStripMenuItem.Image = global::CodeAdvisor.Properties.Resources.folder_yellow_open;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::CodeAdvisor.Properties.Resources.deletered;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // mainImageList
            // 
            this.mainImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("mainImageList.ImageStream")));
            this.mainImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.mainImageList.Images.SetKeyName(0, "java_1.png");
            // 
            // fileInfoText
            // 
            this.fileInfoText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fileInfoText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileInfoText.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileInfoText.Location = new System.Drawing.Point(0, 0);
            this.fileInfoText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fileInfoText.Name = "fileInfoText";
            this.fileInfoText.Size = new System.Drawing.Size(228, 385);
            this.fileInfoText.TabIndex = 2;
            this.fileInfoText.Text = "";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer2.Size = new System.Drawing.Size(1279, 765);
            this.splitContainer2.SplitterDistance = 782;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.editorTab);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.consoleTabs);
            this.splitContainer3.Panel2.Controls.Add(this.toolStrip2);
            this.splitContainer3.Size = new System.Drawing.Size(782, 765);
            this.splitContainer3.SplitterDistance = 484;
            this.splitContainer3.SplitterWidth = 5;
            this.splitContainer3.TabIndex = 0;
            // 
            // editorTab
            // 
            this.editorTab.ContextMenuStrip = this.contextMenuStrip2;
            this.editorTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editorTab.Location = new System.Drawing.Point(0, 0);
            this.editorTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editorTab.Name = "editorTab";
            this.editorTab.SelectedIndex = 0;
            this.editorTab.Size = new System.Drawing.Size(782, 484);
            this.editorTab.TabIndex = 0;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.closeAllToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.Size = new System.Drawing.Size(148, 56);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Image = global::CodeAdvisor.Properties.Resources.no;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(147, 26);
            this.toolStripMenuItem1.Text = "Close Tab";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.closeAllToolStripMenuItem.Text = "Close All";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.closeAllToolStripMenuItem_Click);
            // 
            // consoleTabs
            // 
            this.consoleTabs.Controls.Add(this.outputTabPage);
            this.consoleTabs.Controls.Add(this.errorTabPage);
            this.consoleTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consoleTabs.Location = new System.Drawing.Point(0, 27);
            this.consoleTabs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.consoleTabs.Name = "consoleTabs";
            this.consoleTabs.SelectedIndex = 0;
            this.consoleTabs.Size = new System.Drawing.Size(782, 249);
            this.consoleTabs.TabIndex = 1;
            // 
            // outputTabPage
            // 
            this.outputTabPage.Controls.Add(this.consoleText);
            this.outputTabPage.Location = new System.Drawing.Point(4, 25);
            this.outputTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.outputTabPage.Name = "outputTabPage";
            this.outputTabPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.outputTabPage.Size = new System.Drawing.Size(774, 220);
            this.outputTabPage.TabIndex = 0;
            this.outputTabPage.Text = "Output";
            this.outputTabPage.UseVisualStyleBackColor = true;
            // 
            // consoleText
            // 
            this.consoleText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.consoleText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consoleText.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consoleText.Location = new System.Drawing.Point(4, 4);
            this.consoleText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.consoleText.Name = "consoleText";
            this.consoleText.Size = new System.Drawing.Size(766, 212);
            this.consoleText.TabIndex = 1;
            this.consoleText.Text = "";
            // 
            // errorTabPage
            // 
            this.errorTabPage.Controls.Add(this.errorText);
            this.errorTabPage.Location = new System.Drawing.Point(4, 25);
            this.errorTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.errorTabPage.Name = "errorTabPage";
            this.errorTabPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.errorTabPage.Size = new System.Drawing.Size(775, 210);
            this.errorTabPage.TabIndex = 1;
            this.errorTabPage.Text = "Error";
            this.errorTabPage.UseVisualStyleBackColor = true;
            // 
            // errorText
            // 
            this.errorText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.errorText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.errorText.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errorText.Location = new System.Drawing.Point(4, 4);
            this.errorText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.errorText.Name = "errorText";
            this.errorText.Size = new System.Drawing.Size(767, 202);
            this.errorText.TabIndex = 2;
            this.errorText.Text = "";
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lookupTSBtn,
            this.toolStripSeparator4,
            this.deleteTSBtn});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(782, 27);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // lookupTSBtn
            // 
            this.lookupTSBtn.Image = global::CodeAdvisor.Properties.Resources.find;
            this.lookupTSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lookupTSBtn.Name = "lookupTSBtn";
            this.lookupTSBtn.Size = new System.Drawing.Size(88, 24);
            this.lookupTSBtn.Text = "Look Up";
            this.lookupTSBtn.Click += new System.EventHandler(this.lookupTSBtn_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // deleteTSBtn
            // 
            this.deleteTSBtn.Image = global::CodeAdvisor.Properties.Resources.edit_clear;
            this.deleteTSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteTSBtn.Name = "deleteTSBtn";
            this.deleteTSBtn.Size = new System.Drawing.Size(67, 24);
            this.deleteTSBtn.Text = "Clear";
            this.deleteTSBtn.Click += new System.EventHandler(this.deleteTSBtn_Click);
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.stackList);
            this.splitContainer4.Size = new System.Drawing.Size(492, 765);
            this.splitContainer4.SplitterDistance = 313;
            this.splitContainer4.SplitterWidth = 5;
            this.splitContainer4.TabIndex = 0;
            // 
            // stackList
            // 
            this.stackList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stackList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.author,
            this.question,
            this.score});
            this.stackList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stackList.Location = new System.Drawing.Point(0, 0);
            this.stackList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stackList.MinimumSize = new System.Drawing.Size(411, 359);
            this.stackList.Name = "stackList";
            this.stackList.Size = new System.Drawing.Size(492, 359);
            this.stackList.TabIndex = 1;
            this.stackList.UseCompatibleStateImageBehavior = false;
            this.stackList.View = System.Windows.Forms.View.Details;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Java files (*.java)|*.java|All files (*.*)|*.*";
            // 
            // author
            // 
            this.author.Text = "author";
            this.author.Width = 100;
            // 
            // question
            // 
            this.question.Text = "question";
            this.question.Width = 200;
            // 
            // score
            // 
            this.score.Text = "score";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1512, 814);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1527, 851);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code Avisor v1.0";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.consoleTabs.ResumeLayout(false);
            this.outputTabPage.ResumeLayout(false);
            this.errorTabPage.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.splitContainer4.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton exitTSBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton loadFileTSBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton compileTSBtn;
        private System.Windows.Forms.ToolStripButton comNRunTSBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton settingTSBtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar loadingProg;
        private System.Windows.Forms.ToolStripStatusLabel statusText;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TabControl editorTab;
        private System.Windows.Forms.RichTextBox consoleText;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.ListView stackList;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.ListView fileList;
        private System.Windows.Forms.ToolStripButton deleteTSBtn;
        private System.Windows.Forms.ToolStripButton lookupTSBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton aboutTSBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ImageList mainImageList;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.TabControl consoleTabs;
        private System.Windows.Forms.TabPage outputTabPage;
        private System.Windows.Forms.TabPage errorTabPage;
        private System.Windows.Forms.RichTextBox errorText;
        private System.Windows.Forms.RichTextBox fileInfoText;
        private System.Windows.Forms.ToolStripButton saveFileTSBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ColumnHeader author;
        private System.Windows.Forms.ColumnHeader question;
        private System.Windows.Forms.ColumnHeader score;
    }
}

