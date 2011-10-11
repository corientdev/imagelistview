﻿namespace ImageListViewTests
{
    partial class TestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForm));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.imageListView = new Manina.Windows.Forms.ImageListView();
            this.ItemContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cloneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logEventsCheckbox = new System.Windows.Forms.CheckBox();
            this.EventsListBox = new System.Windows.Forms.ListBox();
            this.EventListContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ClearEventList = new System.Windows.Forms.ToolStripMenuItem();
            this.TestToolStrip = new System.Windows.Forms.ToolStrip();
            this.ChooseImageSource = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.AddOneItem = new System.Windows.Forms.ToolStripButton();
            this.AddItems = new System.Windows.Forms.ToolStripButton();
            this.AddVirtualItems = new System.Windows.Forms.ToolStripButton();
            this.AddURIItems = new System.Windows.Forms.ToolStripButton();
            this.InsertItemAtIndex0 = new System.Windows.Forms.ToolStripButton();
            this.RemoveItemAtIndex0 = new System.Windows.Forms.ToolStripButton();
            this.ClearItems = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.RebuildThumbnails = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.SetEnabled = new System.Windows.Forms.ToolStripButton();
            this.ViewMode = new System.Windows.Forms.ToolStripDropDownButton();
            this.ViewThumbnails = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewGallery = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewPane = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectRenderer = new System.Windows.Forms.ToolStripDropDownButton();
            this.ShowFileIcons = new System.Windows.Forms.ToolStripButton();
            this.ShowCheckboxes = new System.Windows.Forms.ToolStripButton();
            this.ShowScrollbars = new System.Windows.Forms.ToolStripButton();
            this.GroupByName = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.CacheOnDemand = new System.Windows.Forms.ToolStripButton();
            this.AllowDuplicateFilenames = new System.Windows.Forms.ToolStripButton();
            this.IntegralScroll = new System.Windows.Forms.ToolStripButton();
            this.MultiSelect = new System.Windows.Forms.ToolStripButton();
            this.UseWIC = new System.Windows.Forms.ToolStripButton();
            this.UseEmbeddedThumbnails = new System.Windows.Forms.ToolStripButton();
            this.AutoRotateThumbnails = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.StartBenchmark = new System.Windows.Forms.ToolStripButton();
            this.ChooseBenchmarkPath = new System.Windows.Forms.FolderBrowserDialog();
            this.CheckBenchmarkEndTimer = new System.Windows.Forms.Timer(this.components);
            this.ChooseSourcePath = new System.Windows.Forms.FolderBrowserDialog();
            this.UsePersistentCache = new System.Windows.Forms.ToolStripButton();
            this.OpenCacheFile = new System.Windows.Forms.OpenFileDialog();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.LeftToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.ItemContextMenu.SuspendLayout();
            this.EventListContextMenu.SuspendLayout();
            this.TestToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.StatusStrip);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.splitContainer1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(619, 574);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // toolStripContainer1.LeftToolStripPanel
            // 
            this.toolStripContainer1.LeftToolStripPanel.Controls.Add(this.TestToolStrip);
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(758, 621);
            this.toolStripContainer1.TabIndex = 2;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // StatusStrip
            // 
            this.StatusStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 0);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(758, 22);
            this.StatusStrip.TabIndex = 0;
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(38, 17);
            this.StatusLabel.Text = "Ready";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.imageListView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.logEventsCheckbox);
            this.splitContainer1.Panel2.Controls.Add(this.EventsListBox);
            this.splitContainer1.Size = new System.Drawing.Size(619, 574);
            this.splitContainer1.SplitterDistance = 425;
            this.splitContainer1.TabIndex = 1;
            // 
            // imageListView
            // 
            this.imageListView.AllowDuplicateFileNames = true;
            this.imageListView.ColumnHeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.imageListView.Columns.AddRange(new Manina.Windows.Forms.ImageListView.ImageListViewColumnHeader[] {
            new Manina.Windows.Forms.ImageListView.ImageListViewColumnHeader(Manina.Windows.Forms.ColumnType.Name, "", 100, 0, true),
            new Manina.Windows.Forms.ImageListView.ImageListViewColumnHeader(Manina.Windows.Forms.ColumnType.FileType, "", 100, 1, true),
            new Manina.Windows.Forms.ImageListView.ImageListViewColumnHeader(Manina.Windows.Forms.ColumnType.FileSize, "", 100, 2, true),
            new Manina.Windows.Forms.ImageListView.ImageListViewColumnHeader(Manina.Windows.Forms.ColumnType.DateModified, "", 100, 3, true),
            new Manina.Windows.Forms.ImageListView.ImageListViewColumnHeader(Manina.Windows.Forms.ColumnType.DateTaken, "", 100, 4, true),
            new Manina.Windows.Forms.ImageListView.ImageListViewColumnHeader(Manina.Windows.Forms.ColumnType.ExposureTime, "", 100, 5, true),
            new Manina.Windows.Forms.ImageListView.ImageListViewColumnHeader(Manina.Windows.Forms.ColumnType.FNumber, "", 100, 6, true),
            new Manina.Windows.Forms.ImageListView.ImageListViewColumnHeader(Manina.Windows.Forms.ColumnType.ISOSpeed, "", 100, 7, true),
            new Manina.Windows.Forms.ImageListView.ImageListViewColumnHeader(Manina.Windows.Forms.ColumnType.Rating, "", 100, 8, true)});
            this.imageListView.ContextMenuStrip = this.ItemContextMenu;
            this.imageListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageListView.GroupHeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.imageListView.Location = new System.Drawing.Point(0, 0);
            this.imageListView.Name = "imageListView";
            this.imageListView.PersistentCacheFile = "";
            this.imageListView.PersistentCacheSize = ((long)(100));
            this.imageListView.Size = new System.Drawing.Size(425, 574);
            this.imageListView.TabIndex = 0;
            // 
            // ItemContextMenu
            // 
            this.ItemContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cloneToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.rotateToolStripMenuItem});
            this.ItemContextMenu.Name = "ItemContextMenu";
            this.ItemContextMenu.Size = new System.Drawing.Size(108, 70);
            // 
            // cloneToolStripMenuItem
            // 
            this.cloneToolStripMenuItem.Name = "cloneToolStripMenuItem";
            this.cloneToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.cloneToolStripMenuItem.Text = "Clone";
            this.cloneToolStripMenuItem.Click += new System.EventHandler(this.cloneToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // rotateToolStripMenuItem
            // 
            this.rotateToolStripMenuItem.Name = "rotateToolStripMenuItem";
            this.rotateToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.rotateToolStripMenuItem.Text = "Rotate";
            this.rotateToolStripMenuItem.Click += new System.EventHandler(this.rotateToolStripMenuItem_Click);
            // 
            // logEventsCheckbox
            // 
            this.logEventsCheckbox.AutoSize = true;
            this.logEventsCheckbox.Checked = true;
            this.logEventsCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.logEventsCheckbox.Location = new System.Drawing.Point(4, 4);
            this.logEventsCheckbox.Name = "logEventsCheckbox";
            this.logEventsCheckbox.Size = new System.Drawing.Size(80, 17);
            this.logEventsCheckbox.TabIndex = 1;
            this.logEventsCheckbox.Text = "Log Events";
            this.logEventsCheckbox.UseVisualStyleBackColor = true;
            // 
            // EventsListBox
            // 
            this.EventsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.EventsListBox.ContextMenuStrip = this.EventListContextMenu;
            this.EventsListBox.FormattingEnabled = true;
            this.EventsListBox.IntegralHeight = false;
            this.EventsListBox.Location = new System.Drawing.Point(0, 26);
            this.EventsListBox.Name = "EventsListBox";
            this.EventsListBox.Size = new System.Drawing.Size(190, 548);
            this.EventsListBox.TabIndex = 0;
            // 
            // EventListContextMenu
            // 
            this.EventListContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClearEventList});
            this.EventListContextMenu.Name = "EventListContextMenu";
            this.EventListContextMenu.ShowImageMargin = false;
            this.EventListContextMenu.Size = new System.Drawing.Size(75, 26);
            // 
            // ClearEventList
            // 
            this.ClearEventList.Name = "ClearEventList";
            this.ClearEventList.Size = new System.Drawing.Size(74, 22);
            this.ClearEventList.Text = "Clear";
            this.ClearEventList.Click += new System.EventHandler(this.ClearEventList_Click);
            // 
            // TestToolStrip
            // 
            this.TestToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.TestToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.TestToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChooseImageSource,
            this.toolStripSeparator5,
            this.toolStripLabel2,
            this.AddOneItem,
            this.AddItems,
            this.AddVirtualItems,
            this.AddURIItems,
            this.InsertItemAtIndex0,
            this.RemoveItemAtIndex0,
            this.ClearItems,
            this.toolStripSeparator1,
            this.toolStripLabel3,
            this.RebuildThumbnails,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.SetEnabled,
            this.ViewMode,
            this.SelectRenderer,
            this.ShowFileIcons,
            this.ShowCheckboxes,
            this.ShowScrollbars,
            this.GroupByName,
            this.toolStripSeparator3,
            this.toolStripLabel4,
            this.CacheOnDemand,
            this.UsePersistentCache,
            this.AllowDuplicateFilenames,
            this.IntegralScroll,
            this.MultiSelect,
            this.UseWIC,
            this.UseEmbeddedThumbnails,
            this.AutoRotateThumbnails,
            this.toolStripSeparator4,
            this.toolStripLabel5,
            this.StartBenchmark});
            this.TestToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.TestToolStrip.Location = new System.Drawing.Point(0, 3);
            this.TestToolStrip.Name = "TestToolStrip";
            this.TestToolStrip.Size = new System.Drawing.Size(139, 571);
            this.TestToolStrip.TabIndex = 2;
            this.TestToolStrip.Text = "Test Toolbar";
            // 
            // ChooseImageSource
            // 
            this.ChooseImageSource.Image = ((System.Drawing.Image)(resources.GetObject("ChooseImageSource.Image")));
            this.ChooseImageSource.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ChooseImageSource.Name = "ChooseImageSource";
            this.ChooseImageSource.Size = new System.Drawing.Size(137, 20);
            this.ChooseImageSource.Text = "Choose Image Source";
            this.ChooseImageSource.Click += new System.EventHandler(this.ChooseImageSource_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(137, 6);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(137, 13);
            this.toolStripLabel2.Text = "Items:";
            this.toolStripLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddOneItem
            // 
            this.AddOneItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AddOneItem.Image = ((System.Drawing.Image)(resources.GetObject("AddOneItem.Image")));
            this.AddOneItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddOneItem.Name = "AddOneItem";
            this.AddOneItem.Size = new System.Drawing.Size(137, 17);
            this.AddOneItem.Text = "Add One Item";
            this.AddOneItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddOneItem.Click += new System.EventHandler(this.AddOneItem_Click);
            // 
            // AddItems
            // 
            this.AddItems.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AddItems.Image = ((System.Drawing.Image)(resources.GetObject("AddItems.Image")));
            this.AddItems.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddItems.Name = "AddItems";
            this.AddItems.Size = new System.Drawing.Size(137, 17);
            this.AddItems.Text = "Add 1000 Items";
            this.AddItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddItems.Click += new System.EventHandler(this.AddItems_Click);
            // 
            // AddVirtualItems
            // 
            this.AddVirtualItems.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AddVirtualItems.Image = ((System.Drawing.Image)(resources.GetObject("AddVirtualItems.Image")));
            this.AddVirtualItems.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddVirtualItems.Name = "AddVirtualItems";
            this.AddVirtualItems.Size = new System.Drawing.Size(137, 17);
            this.AddVirtualItems.Text = "Add 1000 Virtual Items";
            this.AddVirtualItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddVirtualItems.Click += new System.EventHandler(this.AddVirtualItems_Click);
            // 
            // AddURIItems
            // 
            this.AddURIItems.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AddURIItems.Image = ((System.Drawing.Image)(resources.GetObject("AddURIItems.Image")));
            this.AddURIItems.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddURIItems.Name = "AddURIItems";
            this.AddURIItems.Size = new System.Drawing.Size(137, 17);
            this.AddURIItems.Text = "Add URI Items";
            this.AddURIItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddURIItems.Click += new System.EventHandler(this.AddURIItems_Click);
            // 
            // InsertItemAtIndex0
            // 
            this.InsertItemAtIndex0.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.InsertItemAtIndex0.Image = ((System.Drawing.Image)(resources.GetObject("InsertItemAtIndex0.Image")));
            this.InsertItemAtIndex0.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.InsertItemAtIndex0.Name = "InsertItemAtIndex0";
            this.InsertItemAtIndex0.Size = new System.Drawing.Size(137, 17);
            this.InsertItemAtIndex0.Text = "Insert Item At Index 0";
            this.InsertItemAtIndex0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InsertItemAtIndex0.Click += new System.EventHandler(this.InsertItemAtIndex0_Click);
            // 
            // RemoveItemAtIndex0
            // 
            this.RemoveItemAtIndex0.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.RemoveItemAtIndex0.Image = ((System.Drawing.Image)(resources.GetObject("RemoveItemAtIndex0.Image")));
            this.RemoveItemAtIndex0.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RemoveItemAtIndex0.Name = "RemoveItemAtIndex0";
            this.RemoveItemAtIndex0.Size = new System.Drawing.Size(137, 17);
            this.RemoveItemAtIndex0.Text = "Remove Item At Index 0";
            this.RemoveItemAtIndex0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoveItemAtIndex0.Click += new System.EventHandler(this.RemoveItemAtIndex0_Click);
            // 
            // ClearItems
            // 
            this.ClearItems.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ClearItems.Image = ((System.Drawing.Image)(resources.GetObject("ClearItems.Image")));
            this.ClearItems.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClearItems.Name = "ClearItems";
            this.ClearItems.Size = new System.Drawing.Size(137, 17);
            this.ClearItems.Text = "Clear Items";
            this.ClearItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClearItems.Click += new System.EventHandler(this.ClearItems_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(137, 6);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(137, 13);
            this.toolStripLabel3.Text = "Thumbnails:";
            this.toolStripLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RebuildThumbnails
            // 
            this.RebuildThumbnails.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.RebuildThumbnails.Image = ((System.Drawing.Image)(resources.GetObject("RebuildThumbnails.Image")));
            this.RebuildThumbnails.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RebuildThumbnails.Name = "RebuildThumbnails";
            this.RebuildThumbnails.Size = new System.Drawing.Size(137, 17);
            this.RebuildThumbnails.Text = "Rebuild Thumbnails";
            this.RebuildThumbnails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RebuildThumbnails.Click += new System.EventHandler(this.RebuildThumbnails_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(137, 6);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(137, 13);
            this.toolStripLabel1.Text = "Appearance Settings:";
            this.toolStripLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SetEnabled
            // 
            this.SetEnabled.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SetEnabled.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SetEnabled.Name = "SetEnabled";
            this.SetEnabled.Size = new System.Drawing.Size(137, 17);
            this.SetEnabled.Text = "Enabled";
            this.SetEnabled.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SetEnabled.Click += new System.EventHandler(this.SetEnabled_Click);
            // 
            // ViewMode
            // 
            this.ViewMode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ViewMode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewThumbnails,
            this.ViewGallery,
            this.ViewPane,
            this.ViewDetails});
            this.ViewMode.Image = ((System.Drawing.Image)(resources.GetObject("ViewMode.Image")));
            this.ViewMode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ViewMode.Name = "ViewMode";
            this.ViewMode.Size = new System.Drawing.Size(137, 17);
            this.ViewMode.Text = "View Mode";
            this.ViewMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ViewThumbnails
            // 
            this.ViewThumbnails.Name = "ViewThumbnails";
            this.ViewThumbnails.Size = new System.Drawing.Size(127, 22);
            this.ViewThumbnails.Text = "Thumbnails";
            this.ViewThumbnails.Click += new System.EventHandler(this.ViewThumbnails_Click);
            // 
            // ViewGallery
            // 
            this.ViewGallery.Name = "ViewGallery";
            this.ViewGallery.Size = new System.Drawing.Size(127, 22);
            this.ViewGallery.Text = "Gallery";
            this.ViewGallery.Click += new System.EventHandler(this.ViewGallery_Click);
            // 
            // ViewPane
            // 
            this.ViewPane.Name = "ViewPane";
            this.ViewPane.Size = new System.Drawing.Size(127, 22);
            this.ViewPane.Text = "Pane";
            this.ViewPane.Click += new System.EventHandler(this.ViewPane_Click);
            // 
            // ViewDetails
            // 
            this.ViewDetails.Name = "ViewDetails";
            this.ViewDetails.Size = new System.Drawing.Size(127, 22);
            this.ViewDetails.Text = "Details";
            this.ViewDetails.Click += new System.EventHandler(this.ViewDetails_Click);
            // 
            // SelectRenderer
            // 
            this.SelectRenderer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SelectRenderer.Image = ((System.Drawing.Image)(resources.GetObject("SelectRenderer.Image")));
            this.SelectRenderer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SelectRenderer.Name = "SelectRenderer";
            this.SelectRenderer.Size = new System.Drawing.Size(137, 17);
            this.SelectRenderer.Text = "Renderer";
            this.SelectRenderer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ShowFileIcons
            // 
            this.ShowFileIcons.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ShowFileIcons.Image = ((System.Drawing.Image)(resources.GetObject("ShowFileIcons.Image")));
            this.ShowFileIcons.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ShowFileIcons.Name = "ShowFileIcons";
            this.ShowFileIcons.Size = new System.Drawing.Size(137, 17);
            this.ShowFileIcons.Text = "Show File Icons";
            this.ShowFileIcons.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowFileIcons.Click += new System.EventHandler(this.ShowFileIcons_Click);
            // 
            // ShowCheckboxes
            // 
            this.ShowCheckboxes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ShowCheckboxes.Image = ((System.Drawing.Image)(resources.GetObject("ShowCheckboxes.Image")));
            this.ShowCheckboxes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ShowCheckboxes.Name = "ShowCheckboxes";
            this.ShowCheckboxes.Size = new System.Drawing.Size(137, 17);
            this.ShowCheckboxes.Text = "Show Checkboxes";
            this.ShowCheckboxes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowCheckboxes.Click += new System.EventHandler(this.ShowCheckboxes_Click);
            // 
            // ShowScrollbars
            // 
            this.ShowScrollbars.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ShowScrollbars.Image = ((System.Drawing.Image)(resources.GetObject("ShowScrollbars.Image")));
            this.ShowScrollbars.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ShowScrollbars.Name = "ShowScrollbars";
            this.ShowScrollbars.Size = new System.Drawing.Size(137, 17);
            this.ShowScrollbars.Text = "Show Scrollbars";
            this.ShowScrollbars.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowScrollbars.Click += new System.EventHandler(this.ShowScrollbars_Click);
            // 
            // GroupByName
            // 
            this.GroupByName.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.GroupByName.Image = ((System.Drawing.Image)(resources.GetObject("GroupByName.Image")));
            this.GroupByName.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GroupByName.Name = "GroupByName";
            this.GroupByName.Size = new System.Drawing.Size(137, 17);
            this.GroupByName.Text = "Group by Name";
            this.GroupByName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GroupByName.Click += new System.EventHandler(this.GroupByName_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(137, 6);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(137, 13);
            this.toolStripLabel4.Text = "Behavior Settings:";
            this.toolStripLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CacheOnDemand
            // 
            this.CacheOnDemand.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CacheOnDemand.Image = ((System.Drawing.Image)(resources.GetObject("CacheOnDemand.Image")));
            this.CacheOnDemand.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CacheOnDemand.Name = "CacheOnDemand";
            this.CacheOnDemand.Size = new System.Drawing.Size(137, 17);
            this.CacheOnDemand.Text = "Cache On Demand";
            this.CacheOnDemand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CacheOnDemand.Click += new System.EventHandler(this.CacheOnDemand_Click);
            // 
            // AllowDuplicateFilenames
            // 
            this.AllowDuplicateFilenames.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AllowDuplicateFilenames.Image = ((System.Drawing.Image)(resources.GetObject("AllowDuplicateFilenames.Image")));
            this.AllowDuplicateFilenames.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AllowDuplicateFilenames.Name = "AllowDuplicateFilenames";
            this.AllowDuplicateFilenames.Size = new System.Drawing.Size(137, 17);
            this.AllowDuplicateFilenames.Text = "Allow Duplicate Filenames";
            this.AllowDuplicateFilenames.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AllowDuplicateFilenames.Click += new System.EventHandler(this.AllowDuplicateFilenames_Click);
            // 
            // IntegralScroll
            // 
            this.IntegralScroll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.IntegralScroll.Image = ((System.Drawing.Image)(resources.GetObject("IntegralScroll.Image")));
            this.IntegralScroll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.IntegralScroll.Name = "IntegralScroll";
            this.IntegralScroll.Size = new System.Drawing.Size(137, 17);
            this.IntegralScroll.Text = "Integral Scroll";
            this.IntegralScroll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IntegralScroll.Click += new System.EventHandler(this.IntegralScroll_Click);
            // 
            // MultiSelect
            // 
            this.MultiSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.MultiSelect.Image = ((System.Drawing.Image)(resources.GetObject("MultiSelect.Image")));
            this.MultiSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MultiSelect.Name = "MultiSelect";
            this.MultiSelect.Size = new System.Drawing.Size(137, 17);
            this.MultiSelect.Text = "Multi Select";
            this.MultiSelect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MultiSelect.Click += new System.EventHandler(this.MultiSelect_Click);
            // 
            // UseWIC
            // 
            this.UseWIC.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.UseWIC.Image = ((System.Drawing.Image)(resources.GetObject("UseWIC.Image")));
            this.UseWIC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UseWIC.Name = "UseWIC";
            this.UseWIC.Size = new System.Drawing.Size(137, 17);
            this.UseWIC.Text = "Use WIC";
            this.UseWIC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UseWIC.Click += new System.EventHandler(this.UseWIC_Click);
            // 
            // UseEmbeddedThumbnails
            // 
            this.UseEmbeddedThumbnails.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.UseEmbeddedThumbnails.Image = ((System.Drawing.Image)(resources.GetObject("UseEmbeddedThumbnails.Image")));
            this.UseEmbeddedThumbnails.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UseEmbeddedThumbnails.Name = "UseEmbeddedThumbnails";
            this.UseEmbeddedThumbnails.Size = new System.Drawing.Size(137, 17);
            this.UseEmbeddedThumbnails.Text = "Use Embedded Thumbnails";
            this.UseEmbeddedThumbnails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UseEmbeddedThumbnails.Click += new System.EventHandler(this.UseEmbeddedThumbnails_Click);
            // 
            // AutoRotateThumbnails
            // 
            this.AutoRotateThumbnails.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AutoRotateThumbnails.Image = ((System.Drawing.Image)(resources.GetObject("AutoRotateThumbnails.Image")));
            this.AutoRotateThumbnails.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AutoRotateThumbnails.Name = "AutoRotateThumbnails";
            this.AutoRotateThumbnails.Size = new System.Drawing.Size(126, 17);
            this.AutoRotateThumbnails.Text = "Auto Rotate Thumbnails";
            this.AutoRotateThumbnails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AutoRotateThumbnails.Click += new System.EventHandler(this.AutoRotateThumbnails_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(137, 6);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(63, 13);
            this.toolStripLabel5.Text = "Benchmark:";
            this.toolStripLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StartBenchmark
            // 
            this.StartBenchmark.BackColor = System.Drawing.SystemColors.Control;
            this.StartBenchmark.Image = ((System.Drawing.Image)(resources.GetObject("StartBenchmark.Image")));
            this.StartBenchmark.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StartBenchmark.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StartBenchmark.Name = "StartBenchmark";
            this.StartBenchmark.Size = new System.Drawing.Size(106, 20);
            this.StartBenchmark.Text = "Start Benchmark";
            this.StartBenchmark.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StartBenchmark.Click += new System.EventHandler(this.StartBenchmark_Click);
            // 
            // ChooseBenchmarkPath
            // 
            this.ChooseBenchmarkPath.Description = "Select a folder containing JPEG images.";
            this.ChooseBenchmarkPath.ShowNewFolderButton = false;
            // 
            // CheckBenchmarkEndTimer
            // 
            this.CheckBenchmarkEndTimer.Interval = 2000;
            this.CheckBenchmarkEndTimer.Tick += new System.EventHandler(this.CheckBenchmarkEndTimer_Tick);
            // 
            // ChooseSourcePath
            // 
            this.ChooseSourcePath.ShowNewFolderButton = false;
            // 
            // UsePersistentCache
            // 
            this.UsePersistentCache.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.UsePersistentCache.Image = ((System.Drawing.Image)(resources.GetObject("UsePersistentCache.Image")));
            this.UsePersistentCache.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UsePersistentCache.Name = "UsePersistentCache";
            this.UsePersistentCache.Size = new System.Drawing.Size(137, 17);
            this.UsePersistentCache.Text = "Use Persistent Cache";
            this.UsePersistentCache.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UsePersistentCache.Click += new System.EventHandler(this.UsePersistentCache_Click);
            // 
            // OpenCacheFile
            // 
            this.OpenCacheFile.AddExtension = false;
            this.OpenCacheFile.CheckFileExists = false;
            this.OpenCacheFile.Filter = "All Files|*.*";
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 621);
            this.Controls.Add(this.toolStripContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TestForm";
            this.Text = "ImageListView Tests";
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.LeftToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.LeftToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.ItemContextMenu.ResumeLayout(false);
            this.EventListContextMenu.ResumeLayout(false);
            this.TestToolStrip.ResumeLayout(false);
            this.TestToolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Manina.Windows.Forms.ImageListView imageListView;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip TestToolStrip;
        private System.Windows.Forms.ToolStripButton AddItems;
        private System.Windows.Forms.ToolStripButton InsertItemAtIndex0;
        private System.Windows.Forms.ToolStripButton RemoveItemAtIndex0;
        private System.Windows.Forms.ToolStripButton ClearItems;
        private System.Windows.Forms.ToolStripButton AddVirtualItems;
        private System.Windows.Forms.ToolStripButton RebuildThumbnails;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton ShowFileIcons;
        private System.Windows.Forms.ToolStripButton ShowCheckboxes;
        private System.Windows.Forms.ToolStripButton CacheOnDemand;
        private System.Windows.Forms.ToolStripButton AllowDuplicateFilenames;
        private System.Windows.Forms.ToolStripButton IntegralScroll;
        private System.Windows.Forms.ToolStripButton ShowScrollbars;
        private System.Windows.Forms.ToolStripDropDownButton ViewMode;
        private System.Windows.Forms.ToolStripMenuItem ViewThumbnails;
        private System.Windows.Forms.ToolStripMenuItem ViewGallery;
        private System.Windows.Forms.ToolStripMenuItem ViewPane;
        private System.Windows.Forms.ToolStripMenuItem ViewDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripButton MultiSelect;
        private System.Windows.Forms.ToolStripButton UseEmbeddedThumbnails;
        private System.Windows.Forms.ToolStripButton AutoRotateThumbnails;
        private System.Windows.Forms.ToolStripButton AddOneItem;
		private System.Windows.Forms.ToolStripButton SetEnabled;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox EventsListBox;
        private System.Windows.Forms.ContextMenuStrip EventListContextMenu;
        private System.Windows.Forms.ToolStripMenuItem ClearEventList;
        private System.Windows.Forms.FolderBrowserDialog ChooseBenchmarkPath;
        private System.Windows.Forms.Timer CheckBenchmarkEndTimer;
        private System.Windows.Forms.ToolStripButton UseWIC;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripButton StartBenchmark;
        private System.Windows.Forms.CheckBox logEventsCheckbox;
        private System.Windows.Forms.ToolStripDropDownButton SelectRenderer;
        private System.Windows.Forms.ContextMenuStrip ItemContextMenu;
        private System.Windows.Forms.ToolStripMenuItem cloneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton AddURIItems;
        private System.Windows.Forms.ToolStripButton ChooseImageSource;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.FolderBrowserDialog ChooseSourcePath;
        private System.Windows.Forms.ToolStripButton GroupByName;
        private System.Windows.Forms.ToolStripMenuItem rotateToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton UsePersistentCache;
        private System.Windows.Forms.OpenFileDialog OpenCacheFile;
    }
}

