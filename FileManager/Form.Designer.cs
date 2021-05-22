
namespace FileManager
{
    partial class File_Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(File_Manager));
            this.backButton = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.goButton = new System.Windows.Forms.Button();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.fileTypeLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.treeView = new System.Windows.Forms.TreeView();
            this.forwardButton = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseWayForCreateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tST_Create_Directory = new System.Windows.Forms.ToolStripTextBox();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.choosingCreateFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tST_Choose_Create_Folder = new System.Windows.Forms.ToolStripTextBox();
            this.createFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tST_forCreateFolder = new System.Windows.Forms.ToolStripTextBox();
            this.Delete_ToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.tST_Delete = new System.Windows.Forms.ToolStripTextBox();
            this.copyToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tST_CopyFile_To = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox7 = new System.Windows.Forms.ToolStripTextBox();
            this.directoryMoveToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tST_Directory_Move = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox9 = new System.Windows.Forms.ToolStripTextBox();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tST_Rename = new System.Windows.Forms.ToolStripTextBox();
            this.tsT_tBox_Rename = new System.Windows.Forms.ToolStripTextBox();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Create_Directory = new System.Windows.Forms.ToolStripTextBox();
            this.Create_Folder = new System.Windows.Forms.ToolStripTextBox();
            this.Delete = new System.Windows.Forms.ToolStripTextBox();
            this.File_CopyTo = new System.Windows.Forms.ToolStripTextBox();
            this.Directory_MoveTo = new System.Windows.Forms.ToolStripTextBox();
            this.Rename = new System.Windows.Forms.ToolStripTextBox();
            this.menuStrip.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 41);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(78, 30);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // listView
            // 
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.ContextMenuStrip = this.contextMenu;
            this.listView.HideSelection = false;
            this.listView.LargeImageList = this.iconList;
            this.listView.Location = new System.Drawing.Point(322, 114);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(465, 297);
            this.listView.SmallImageList = this.iconList;
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Tile;
            this.listView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView_ItemSelectionChanged);
            this.listView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_MouseDoubleClick);
            // 
            // iconList
            // 
            this.iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList.ImageStream")));
            this.iconList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconList.Images.SetKeyName(0, "icons8_doc.ico");
            this.iconList.Images.SetKeyName(1, "icons8_exe.ico");
            this.iconList.Images.SetKeyName(2, "icons8_file.ico");
            this.iconList.Images.SetKeyName(3, "icons8_folder.ico");
            this.iconList.Images.SetKeyName(4, "icons8_kawaii_folders.ico");
            this.iconList.Images.SetKeyName(5, "icons8_mp3.ico");
            this.iconList.Images.SetKeyName(6, "icons8_opened_folder.ico");
            this.iconList.Images.SetKeyName(7, "icons8_pdf.ico");
            this.iconList.Images.SetKeyName(8, "icons8_png.ico");
            this.iconList.Images.SetKeyName(9, "icons8_video_file_1.ico");
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(723, 81);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(77, 22);
            this.goButton.TabIndex = 2;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Location = new System.Drawing.Point(106, 83);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(611, 20);
            this.filePathTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "FileName";
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(82, 414);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(15, 15);
            this.fileNameLabel.TabIndex = 5;
            this.fileNameLabel.Text = "--";
            // 
            // fileTypeLabel
            // 
            this.fileTypeLabel.AutoSize = true;
            this.fileTypeLabel.Location = new System.Drawing.Point(750, 414);
            this.fileTypeLabel.Name = "fileTypeLabel";
            this.fileTypeLabel.Size = new System.Drawing.Size(15, 15);
            this.fileTypeLabel.TabIndex = 7;
            this.fileTypeLabel.Tag = "";
            this.fileTypeLabel.Text = "--";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(694, 414);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "File Type";
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(11, 114);
            this.treeView.Margin = new System.Windows.Forms.Padding(2);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(306, 297);
            this.treeView.TabIndex = 9;
            // 
            // forwardButton
            // 
            this.forwardButton.Location = new System.Drawing.Point(11, 77);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(77, 31);
            this.forwardButton.TabIndex = 10;
            this.forwardButton.Text = "Forward";
            this.forwardButton.UseVisualStyleBackColor = true;
            this.forwardButton.Click += new System.EventHandler(this.forwardButton_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 28);
            this.menuStrip.TabIndex = 11;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseWayForCreateToolStripMenuItem,
            this.createToolStripMenuItem,
            this.choosingCreateFolderToolStripMenuItem,
            this.createFolderToolStripMenuItem,
            this.Delete_ToolStrip,
            this.copyToToolStripMenuItem,
            this.directoryMoveToToolStripMenuItem,
            this.renameToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // chooseWayForCreateToolStripMenuItem
            // 
            this.chooseWayForCreateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tST_Create_Directory});
            this.chooseWayForCreateToolStripMenuItem.Name = "chooseWayForCreateToolStripMenuItem";
            this.chooseWayForCreateToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.chooseWayForCreateToolStripMenuItem.Text = "Create Directory";
            // 
            // tST_Create_Directory
            // 
            this.tST_Create_Directory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tST_Create_Directory.Name = "tST_Create_Directory";
            this.tST_Create_Directory.Size = new System.Drawing.Size(100, 27);
            this.tST_Create_Directory.DoubleClick += new System.EventHandler(this.createToolStripMenuItem_Click);
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox});
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.createToolStripMenuItem.Text = "Choosing Create Directory";
            // 
            // toolStripTextBox
            // 
            this.toolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox.Name = "toolStripTextBox";
            this.toolStripTextBox.Size = new System.Drawing.Size(100, 27);
            this.toolStripTextBox.Enter += new System.EventHandler(this.createToolStripMenuItem_Click);
            this.toolStripTextBox.DoubleClick += new System.EventHandler(this.Choose_CreateDirectoryButton_Click);
            // 
            // choosingCreateFolderToolStripMenuItem
            // 
            this.choosingCreateFolderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tST_Choose_Create_Folder});
            this.choosingCreateFolderToolStripMenuItem.Name = "choosingCreateFolderToolStripMenuItem";
            this.choosingCreateFolderToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.choosingCreateFolderToolStripMenuItem.Text = "Choosing Create Folder";
            // 
            // tST_Choose_Create_Folder
            // 
            this.tST_Choose_Create_Folder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tST_Choose_Create_Folder.Name = "tST_Choose_Create_Folder";
            this.tST_Choose_Create_Folder.Size = new System.Drawing.Size(100, 27);
            this.tST_Choose_Create_Folder.DoubleClick += new System.EventHandler(this.tST_Choose_Create_Folder_DoubleClick);
            // 
            // createFolderToolStripMenuItem
            // 
            this.createFolderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tST_forCreateFolder});
            this.createFolderToolStripMenuItem.Name = "createFolderToolStripMenuItem";
            this.createFolderToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.createFolderToolStripMenuItem.Text = "Create Folder";
            // 
            // tST_forCreateFolder
            // 
            this.tST_forCreateFolder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tST_forCreateFolder.Name = "tST_forCreateFolder";
            this.tST_forCreateFolder.Size = new System.Drawing.Size(100, 27);
            this.tST_forCreateFolder.DoubleClick += new System.EventHandler(this.tST_forCreateFolder_Click);
            // 
            // Delete_ToolStrip
            // 
            this.Delete_ToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tST_Delete});
            this.Delete_ToolStrip.Name = "Delete_ToolStrip";
            this.Delete_ToolStrip.Size = new System.Drawing.Size(266, 26);
            this.Delete_ToolStrip.Text = "Delete";
            // 
            // tST_Delete
            // 
            this.tST_Delete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tST_Delete.Name = "tST_Delete";
            this.tST_Delete.Size = new System.Drawing.Size(100, 27);
            this.tST_Delete.DoubleClick += new System.EventHandler(this.tST_Delete_DoubleClick);
            // 
            // copyToToolStripMenuItem
            // 
            this.copyToToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tST_CopyFile_To,
            this.toolStripTextBox7});
            this.copyToToolStripMenuItem.Name = "copyToToolStripMenuItem";
            this.copyToToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.copyToToolStripMenuItem.Text = "Fille CopyTo...";
            // 
            // tST_CopyFile_To
            // 
            this.tST_CopyFile_To.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tST_CopyFile_To.Name = "tST_CopyFile_To";
            this.tST_CopyFile_To.Size = new System.Drawing.Size(100, 27);
            this.tST_CopyFile_To.Text = "to";
            this.tST_CopyFile_To.DoubleClick += new System.EventHandler(this.tST_CopyFile_To_DoubleClick);
            // 
            // toolStripTextBox7
            // 
            this.toolStripTextBox7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox7.Name = "toolStripTextBox7";
            this.toolStripTextBox7.Size = new System.Drawing.Size(100, 27);
            this.toolStripTextBox7.Text = "from";
            // 
            // directoryMoveToToolStripMenuItem
            // 
            this.directoryMoveToToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tST_Directory_Move,
            this.toolStripTextBox9});
            this.directoryMoveToToolStripMenuItem.Name = "directoryMoveToToolStripMenuItem";
            this.directoryMoveToToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.directoryMoveToToolStripMenuItem.Text = "Directory MoveTo...";
            // 
            // tST_Directory_Move
            // 
            this.tST_Directory_Move.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tST_Directory_Move.Name = "tST_Directory_Move";
            this.tST_Directory_Move.Size = new System.Drawing.Size(100, 27);
            this.tST_Directory_Move.Text = "to";
            this.tST_Directory_Move.DoubleClick += new System.EventHandler(this.tST_Directory_Move_DoubleClick);
            // 
            // toolStripTextBox9
            // 
            this.toolStripTextBox9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox9.Name = "toolStripTextBox9";
            this.toolStripTextBox9.Size = new System.Drawing.Size(100, 27);
            this.toolStripTextBox9.Text = "from";
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tST_Rename,
            this.tsT_tBox_Rename});
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.renameToolStripMenuItem.Text = "Rename";
            // 
            // tST_Rename
            // 
            this.tST_Rename.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tST_Rename.Name = "tST_Rename";
            this.tST_Rename.Size = new System.Drawing.Size(100, 27);
            this.tST_Rename.Text = "to";
            this.tST_Rename.DoubleClick += new System.EventHandler(this.tST_Rename_DoubleClick);
            // 
            // tsT_tBox_Rename
            // 
            this.tsT_tBox_Rename.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsT_tBox_Rename.Name = "tsT_tBox_Rename";
            this.tsT_tBox_Rename.Size = new System.Drawing.Size(100, 27);
            this.tsT_tBox_Rename.Text = "from";
            // 
            // contextMenu
            // 
            this.contextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Create_Directory,
            this.Create_Folder,
            this.Delete,
            this.File_CopyTo,
            this.Directory_MoveTo,
            this.Rename});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(161, 178);
            // 
            // Create_Directory
            // 
            this.Create_Directory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Create_Directory.Name = "Create_Directory";
            this.Create_Directory.Size = new System.Drawing.Size(100, 27);
            this.Create_Directory.Text = "Create Directory";
            // 
            // Create_Folder
            // 
            this.Create_Folder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Create_Folder.Name = "Create_Folder";
            this.Create_Folder.Size = new System.Drawing.Size(100, 27);
            this.Create_Folder.Text = "Create Folder";
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(100, 27);
            this.Delete.Text = "Delete";
            // 
            // File_CopyTo
            // 
            this.File_CopyTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.File_CopyTo.Name = "File_CopyTo";
            this.File_CopyTo.Size = new System.Drawing.Size(100, 27);
            this.File_CopyTo.Text = "File CopyTo";
            // 
            // Directory_MoveTo
            // 
            this.Directory_MoveTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Directory_MoveTo.Name = "Directory_MoveTo";
            this.Directory_MoveTo.Size = new System.Drawing.Size(100, 27);
            this.Directory_MoveTo.Text = "Directory MoveTo";
            // 
            // Rename
            // 
            this.Rename.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Rename.Name = "Rename";
            this.Rename.Size = new System.Drawing.Size(100, 27);
            this.Rename.Text = "Rename";
            // 
            // File_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.forwardButton);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.fileTypeLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filePathTextBox);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "File_Manager";
            this.Text = "Form";
            this.Load += new System.EventHandler(this.Form_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.contextMenu.ResumeLayout(false);
            this.contextMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Label fileTypeLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ImageList iconList;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Button forwardButton;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox;
        private System.Windows.Forms.ToolStripMenuItem chooseWayForCreateToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox tST_Create_Directory;
        private System.Windows.Forms.ToolStripMenuItem createFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem choosingCreateFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox tST_forCreateFolder;
        private System.Windows.Forms.ToolStripTextBox tST_Choose_Create_Folder;
        private System.Windows.Forms.ToolStripMenuItem Delete_ToolStrip;
        private System.Windows.Forms.ToolStripTextBox tST_Delete;
        private System.Windows.Forms.ToolStripMenuItem copyToToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox tST_CopyFile_To;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox7;
        private System.Windows.Forms.ToolStripMenuItem directoryMoveToToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox tST_Directory_Move;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox9;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox tST_Rename;
        private System.Windows.Forms.ToolStripTextBox tsT_tBox_Rename;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripTextBox Create_Directory;
        private System.Windows.Forms.ToolStripTextBox Create_Folder;
        private System.Windows.Forms.ToolStripTextBox Delete;
        private System.Windows.Forms.ToolStripTextBox File_CopyTo;
        private System.Windows.Forms.ToolStripTextBox Directory_MoveTo;
        private System.Windows.Forms.ToolStripTextBox Rename;
    }
}

