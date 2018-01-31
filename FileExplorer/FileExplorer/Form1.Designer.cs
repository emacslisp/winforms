namespace FileExplorer
{
    partial class Form1
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
            this.radRibbonBar1 = new Telerik.WinControls.UI.RadRibbonBar();
            this.ribbonTab1 = new Telerik.WinControls.UI.RibbonTab();
            this.radRibbonBarGroup1 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radDropDownButtonElement1 = new Telerik.WinControls.UI.RadDropDownButtonElement();
            this.radRibbonBarButtonGroup1 = new Telerik.WinControls.UI.RadRibbonBarButtonGroup();
            this.cutButton = new Telerik.WinControls.UI.RadButtonElement();
            this.copyButton = new Telerik.WinControls.UI.RadButtonElement();
            this.copyAsPathButton = new Telerik.WinControls.UI.RadButtonElement();
            this.ribbonTab2 = new Telerik.WinControls.UI.RibbonTab();
            this.ribbonTab3 = new Telerik.WinControls.UI.RibbonTab();
            this.ribbonTab4 = new Telerik.WinControls.UI.RibbonTab();
            this.radRibbonBarGroup2 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radButtonElement1 = new Telerik.WinControls.UI.RadButtonElement();
            this.radRibbonBarGroup3 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radNewItems = new Telerik.WinControls.UI.RadDropDownButtonElement();
            this.radDropDownButtonElement2 = new Telerik.WinControls.UI.RadDropDownButtonElement();
            this.radRibbonBarButtonGroup2 = new Telerik.WinControls.UI.RadRibbonBarButtonGroup();
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radRibbonBar1
            // 
            this.radRibbonBar1.CommandTabs.AddRange(new Telerik.WinControls.RadItem[] {
            this.ribbonTab1,
            this.ribbonTab2,
            this.ribbonTab3,
            this.ribbonTab4});
            this.radRibbonBar1.Location = new System.Drawing.Point(0, 0);
            this.radRibbonBar1.Name = "radRibbonBar1";
            this.radRibbonBar1.Size = new System.Drawing.Size(768, 163);
            this.radRibbonBar1.TabIndex = 0;
            this.radRibbonBar1.Text = "Form1";
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.AccessibleDescription = "Home";
            this.ribbonTab1.AccessibleName = "Home";
            this.ribbonTab1.IsSelected = true;
            this.ribbonTab1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarGroup1,
            this.radRibbonBarGroup2,
            this.radRibbonBarGroup3});
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Text = "Home";
            // 
            // radRibbonBarGroup1
            // 
            this.radRibbonBarGroup1.AccessibleDescription = "Clipboard";
            this.radRibbonBarGroup1.AccessibleName = "Clipboard";
            this.radRibbonBarGroup1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radDropDownButtonElement1,
            this.radRibbonBarButtonGroup1});
            this.radRibbonBarGroup1.Name = "radRibbonBarGroup1";
            this.radRibbonBarGroup1.Text = "Clipboard";
            // 
            // radDropDownButtonElement1
            // 
            this.radDropDownButtonElement1.AccessibleDescription = "Paste";
            this.radDropDownButtonElement1.AccessibleName = "Paste";
            this.radDropDownButtonElement1.ArrowButtonMinSize = new System.Drawing.Size(12, 12);
            this.radDropDownButtonElement1.ArrowPosition = Telerik.WinControls.UI.DropDownButtonArrowPosition.Bottom;
            this.radDropDownButtonElement1.DropDownDirection = Telerik.WinControls.UI.RadDirection.Down;
            this.radDropDownButtonElement1.ExpandArrowButton = false;
            this.radDropDownButtonElement1.Image = global::FileExplorer.Properties.Resources._1_paste;
            this.radDropDownButtonElement1.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radDropDownButtonElement1.Name = "radDropDownButtonElement1";
            this.radDropDownButtonElement1.Text = "Paste";
            this.radDropDownButtonElement1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // radRibbonBarButtonGroup1
            // 
            this.radRibbonBarButtonGroup1.AccessibleDescription = "radRibbonBarButtonGroup1";
            this.radRibbonBarButtonGroup1.AccessibleName = "radRibbonBarButtonGroup1";
            this.radRibbonBarButtonGroup1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.cutButton,
            this.copyButton,
            this.copyAsPathButton});
            this.radRibbonBarButtonGroup1.Name = "radRibbonBarButtonGroup1";
            this.radRibbonBarButtonGroup1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.radRibbonBarButtonGroup1.Text = "radRibbonBarButtonGroup1";
            // 
            // cutButton
            // 
            this.cutButton.AccessibleDescription = "Cut";
            this.cutButton.AccessibleName = "Cut";
            this.cutButton.Image = global::FileExplorer.Properties.Resources._1_cut;
            this.cutButton.ImageAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cutButton.Name = "cutButton";
            this.cutButton.ShowBorder = false;
            this.cutButton.Text = "Cut";
            this.cutButton.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // copyButton
            // 
            this.copyButton.AccessibleDescription = "Copy";
            this.copyButton.AccessibleName = "Copy";
            this.copyButton.Image = global::FileExplorer.Properties.Resources._1_copy;
            this.copyButton.Name = "copyButton";
            this.copyButton.ShowBorder = false;
            this.copyButton.Text = "Copy";
            this.copyButton.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.copyButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // copyAsPathButton
            // 
            this.copyAsPathButton.AccessibleDescription = "Copy as path";
            this.copyAsPathButton.AccessibleName = "Copy as path";
            this.copyAsPathButton.Image = global::FileExplorer.Properties.Resources._1_copy_as_path;
            this.copyAsPathButton.Name = "copyAsPathButton";
            this.copyAsPathButton.ShowBorder = false;
            this.copyAsPathButton.Text = "Copy as Path";
            this.copyAsPathButton.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.copyAsPathButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // ribbonTab2
            // 
            this.ribbonTab2.AccessibleDescription = "Share";
            this.ribbonTab2.AccessibleName = "Share";
            this.ribbonTab2.Name = "ribbonTab2";
            this.ribbonTab2.Text = "Share";
            // 
            // ribbonTab3
            // 
            this.ribbonTab3.AccessibleDescription = "View";
            this.ribbonTab3.AccessibleName = "View";
            this.ribbonTab3.Name = "ribbonTab3";
            this.ribbonTab3.Text = "View";
            // 
            // ribbonTab4
            // 
            this.ribbonTab4.AccessibleDescription = "Themes";
            this.ribbonTab4.AccessibleName = "Themes";
            this.ribbonTab4.Image = global::FileExplorer.Properties.Resources._1_copy_as_path;
            this.ribbonTab4.Name = "ribbonTab4";
            this.ribbonTab4.Text = "Themes";
            // 
            // radRibbonBarGroup2
            // 
            this.radRibbonBarGroup2.AccessibleDescription = "New";
            this.radRibbonBarGroup2.AccessibleName = "New";
            this.radRibbonBarGroup2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radButtonElement1,
            this.radNewItems});
            this.radRibbonBarGroup2.Name = "radRibbonBarGroup2";
            this.radRibbonBarGroup2.Text = "New";
            // 
            // radButtonElement1
            // 
            this.radButtonElement1.AccessibleDescription = "New folder";
            this.radButtonElement1.AccessibleName = "New folder";
            this.radButtonElement1.Image = global::FileExplorer.Properties.Resources._1_new_folder;
            this.radButtonElement1.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radButtonElement1.Name = "radButtonElement1";
            this.radButtonElement1.Text = "New folder";
            this.radButtonElement1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // radRibbonBarGroup3
            // 
            this.radRibbonBarGroup3.AccessibleDescription = "Organize";
            this.radRibbonBarGroup3.AccessibleName = "Organize";
            this.radRibbonBarGroup3.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radDropDownButtonElement2,
            this.radRibbonBarButtonGroup2});
            this.radRibbonBarGroup3.Name = "radRibbonBarGroup3";
            this.radRibbonBarGroup3.Text = "Organize";
            // 
            // radNewItems
            // 
            this.radNewItems.AccessibleDescription = "New Items";
            this.radNewItems.AccessibleName = "New Items";
            this.radNewItems.ArrowButtonMinSize = new System.Drawing.Size(12, 12);
            this.radNewItems.ArrowPosition = Telerik.WinControls.UI.DropDownButtonArrowPosition.Bottom;
            this.radNewItems.DropDownDirection = Telerik.WinControls.UI.RadDirection.Down;
            this.radNewItems.ExpandArrowButton = false;
            this.radNewItems.Image = global::FileExplorer.Properties.Resources._1_new_items;
            this.radNewItems.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radNewItems.Name = "radNewItems";
            this.radNewItems.Text = "New Items";
            this.radNewItems.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // radDropDownButtonElement2
            // 
            this.radDropDownButtonElement2.AccessibleDescription = "Delete";
            this.radDropDownButtonElement2.AccessibleName = "Delete";
            this.radDropDownButtonElement2.ArrowButtonMinSize = new System.Drawing.Size(12, 12);
            this.radDropDownButtonElement2.ArrowPosition = Telerik.WinControls.UI.DropDownButtonArrowPosition.Bottom;
            this.radDropDownButtonElement2.DropDownDirection = Telerik.WinControls.UI.RadDirection.Down;
            this.radDropDownButtonElement2.ExpandArrowButton = false;
            this.radDropDownButtonElement2.Image = global::FileExplorer.Properties.Resources._1_delete;
            this.radDropDownButtonElement2.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radDropDownButtonElement2.Name = "radDropDownButtonElement2";
            this.radDropDownButtonElement2.Text = "Delete";
            this.radDropDownButtonElement2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // radRibbonBarButtonGroup2
            // 
            this.radRibbonBarButtonGroup2.AccessibleDescription = "radRibbonBarButtonGroup2";
            this.radRibbonBarButtonGroup2.AccessibleName = "radRibbonBarButtonGroup2";
            this.radRibbonBarButtonGroup2.Name = "radRibbonBarButtonGroup2";
            this.radRibbonBarButtonGroup2.Text = "radRibbonBarButtonGroup2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 461);
            this.Controls.Add(this.radRibbonBar1);
            this.Name = "Form1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadRibbonBar radRibbonBar1;
        private Telerik.WinControls.UI.RibbonTab ribbonTab1;
        private Telerik.WinControls.UI.RibbonTab ribbonTab2;
        private Telerik.WinControls.UI.RibbonTab ribbonTab3;
        private Telerik.WinControls.UI.RibbonTab ribbonTab4;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup1;
        private Telerik.WinControls.UI.RadDropDownButtonElement radDropDownButtonElement1;
        private Telerik.WinControls.UI.RadRibbonBarButtonGroup radRibbonBarButtonGroup1;
        private Telerik.WinControls.UI.RadButtonElement cutButton;
        private Telerik.WinControls.UI.RadButtonElement copyButton;
        private Telerik.WinControls.UI.RadButtonElement copyAsPathButton;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup2;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement1;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup3;
        private Telerik.WinControls.UI.RadDropDownButtonElement radNewItems;
        private Telerik.WinControls.UI.RadDropDownButtonElement radDropDownButtonElement2;
        private Telerik.WinControls.UI.RadRibbonBarButtonGroup radRibbonBarButtonGroup2;
    }
}

