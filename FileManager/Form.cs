using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace FileManager
{
    public partial class File_Manager : Form
    {
        private string filePath = "D:/";
        private bool isFile = false;
        private string currentlySelectedItemName = "";
        public File_Manager()
        {
            InitializeComponent();

            treeView.BeforeSelect += treeView_BeforeSelect;
            treeView.BeforeExpand += treeView_BeforeExpand;
            // заполняем дерево дисками
            FillDriveNodes();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            filePathTextBox.Text = filePath;
            loadFilesAndDirectories();
        }

        public void loadFilesAndDirectories()
        {
            DirectoryInfo fileList;
            string tempFilePath = "";
            FileAttributes fileAttr;

            try
            {
                if (isFile)
                {
                    tempFilePath = filePath + "/" + currentlySelectedItemName;
                    FileInfo fileDetails = new FileInfo(tempFilePath);
                    fileNameLabel.Text = fileDetails.Name;
                    fileTypeLabel.Text = fileDetails.Extension;
                    fileAttr = File.GetAttributes(tempFilePath);
                    Process.Start(tempFilePath);
                }
                else
                {
                    fileAttr = File.GetAttributes(filePath);

                }

                if ((fileAttr & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    fileList = new DirectoryInfo(filePath);
                    FileInfo[] files = fileList.GetFiles(); // get all files
                    DirectoryInfo[] dirs = fileList.GetDirectories(); // get all dirs
                    string fileExtension = "";
                    listView.Items.Clear();

                    for (int i = 0; i < files.Length; i++)
                    {
                        fileExtension = files[i].Extension.ToUpper();
                        switch (fileExtension)
                        {
                            case ".MP3":
                            case ".MP2":
                                listView.Items.Add(files[i].Name, 5);
                                break;
                            case ".EXE":
                            case ".COM":
                                listView.Items.Add(files[i].Name, 1);
                                break;

                            case ".MP4":
                            case ".AVI":
                            case ".MKV":
                                listView.Items.Add(files[i].Name, 9);
                                break;
                            case ".PDF":
                                listView.Items.Add(files[i].Name, 7);
                                break;
                            case ".DOC":
                            case ".DOCX":
                            case ".TXT":
                                listView.Items.Add(files[i].Name, 2);
                                break;
                            case ".PNG":
                            case ".JPG":
                            case ".JPEG":
                                listView.Items.Add(files[i].Name, 8);
                                break;

                            default:
                                listView.Items.Add(files[i].Name, 4);
                                break;
                        }

                    }

                    for (int i = 0; i < dirs.Length; i++)
                    {
                        listView.Items.Add(dirs[i].Name, 3);
                    }
                }
                else
                {
                    fileNameLabel.Text = this.currentlySelectedItemName;
                }

            }
            catch (Exception e)
            {

            }
        }

        public void loadButtonAction()
        {
            //removeBackSlash();
            filePath = filePathTextBox.Text;
            loadFilesAndDirectories();
            isFile = false;
        }

        public void removeBackSlash()
        {
            string path = filePathTextBox.Text;
            if (path.LastIndexOf("/") == path.Length - 1)
            {
                filePathTextBox.Text = path.Substring(0, path.Length - 1);
            }
        }

        string going;
        public void goBack()
        {
            try
            {
                //removeBackSlash();
                string path = filePathTextBox.Text;
                going = path;
                path = path.Substring(0, path.LastIndexOf("/"));
                this.isFile = false;
                filePathTextBox.Text = path;
                //removeBackSlash();
            }
            catch (Exception e)
            {

            }
        }

        public void goForward()
        {
            try
            {
                //removeBackSlash();
                string path = filePathTextBox.Text;
                path = path.Substring(0, path.LastIndexOf("/"));
                isFile = false;
                filePathTextBox.Text = going;
                //removeBackSlash();
            }
            catch (Exception e)
            {

            }
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            loadButtonAction();
        }

        private void listView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            currentlySelectedItemName = e.Item.Text;

            FileAttributes fileAttr = File.GetAttributes(filePath + "/" + currentlySelectedItemName);
            if ((fileAttr & FileAttributes.Directory) == FileAttributes.Directory)
            {
                isFile = false;
                filePathTextBox.Text = filePath + "/" + currentlySelectedItemName;
            }
            else
            {
                isFile = true;
            }
        }

        private void listView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            loadButtonAction();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            goBack();
            loadButtonAction();
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            goForward();
            loadButtonAction();
        }


        // событие перед раскрытием узла
        void treeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.Nodes.Clear();
            string[] dirs;
            try
            {
                if (Directory.Exists(e.Node.FullPath))
                {
                    dirs = Directory.GetDirectories(e.Node.FullPath);
                    if (dirs.Length != 0)
                    {
                        for (int i = 0; i < dirs.Length; i++)
                        {
                            TreeNode dirNode = new TreeNode(new DirectoryInfo(dirs[i]).Name);
                            FillTreeNode(dirNode, dirs[i]);
                            e.Node.Nodes.Add(dirNode);
                        }
                    }
                }
            }
            catch (Exception ex) { }
        }
        // событие перед выделением узла
        void treeView_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.Nodes.Clear();
            string[] dirs;
            try
            {
                if (Directory.Exists(e.Node.FullPath))
                {
                    dirs = Directory.GetDirectories(e.Node.FullPath);
                    if (dirs.Length != 0)
                    {
                        for (int i = 0; i < dirs.Length; i++)
                        {
                            TreeNode dirNode = new TreeNode(new DirectoryInfo(dirs[i]).Name);
                            FillTreeNode(dirNode, dirs[i]);
                            e.Node.Nodes.Add(dirNode);
                        }
                    }
                }
            }
            catch (Exception ex) { }
        }

        // получаем все диски на компьютере
        private void FillDriveNodes()
        {
            try
            {
                foreach (DriveInfo drive in DriveInfo.GetDrives())
                {
                    TreeNode driveNode = new TreeNode { Text = drive.Name };
                    FillTreeNode(driveNode, drive.Name);
                    treeView.Nodes.Add(driveNode);
                }
            }
            catch (Exception ex) { }
        }
        // получаем дочерние узлы для определенного узла
        private void FillTreeNode(TreeNode driveNode, string path)
        {
            try
            {
                string[] dirs = Directory.GetDirectories(path);
                foreach (string dir in dirs)
                {
                    TreeNode dirNode = new TreeNode();
                    dirNode.Text = dir.Remove(0, dir.LastIndexOf("\\") + 1);
                    driveNode.Nodes.Add(dirNode);
                }
            }
            catch (Exception ex) 
            { 
            }
        }
       


        public void CreatingDirectory()
        {
            try
            {
                Directory.CreateDirectory(tST_Create_Directory.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreatingDirectory();    
        }
        //filePathTextBox.Text

        public void Choosing_CreateDirectoryButton()
        {
            try
            {
                Directory.CreateDirectory(filePathTextBox.Text + tST_Create_Directory.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }
        }
        private void Choose_CreateDirectoryButton_Click(object sender, EventArgs e)
        {
            Choosing_CreateDirectoryButton();
        }

        public void tSTing_forCreateFolder()
        {
            try
            {
                File.Create(tST_forCreateFolder.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }
        }

        private void tST_forCreateFolder_Click(object sender, EventArgs e)
        {
            tSTing_forCreateFolder();
        }

        public void tSTing_Choose_Create_Folder()
        {
            try
            {
                File.Create(filePathTextBox.Text + tST_Create_Directory.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }
        }

        private void tST_Choose_Create_Folder_DoubleClick(object sender, EventArgs e)
        {
            tSTing_Choose_Create_Folder();
        }

        public void tSTing_Delete()
        {
            try
            {
                File.Delete(tST_Delete.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }
        }

        private void tST_Delete_DoubleClick(object sender, EventArgs e)
        {
            tSTing_Delete();
        }

        public void tsTing_CopyFile_To()
        {
            try
            {
                File.Copy(toolStripTextBox7.Text, tST_CopyFile_To.Text, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }
        }

        private void tST_CopyFile_To_DoubleClick(object sender, EventArgs e)
        {
            tsTing_CopyFile_To();
        }


        public void tSTing_Directory_Move()
        {
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(toolStripTextBox9.Text);
                if (dirInfo.Exists && Directory.Exists(tST_Directory_Move.Text) == false)
                {
                    dirInfo.MoveTo(tST_Directory_Move.Text);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message);
            }
        }
        private void tST_Directory_Move_DoubleClick(object sender, EventArgs e)
        {
            tSTing_Directory_Move();
        }


        public void tSTing_Rename()
        {
            try
            {
                Directory.Move("D:\\" + tsT_tBox_Rename.Text, "D:\\" + tST_Rename.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message);
            }
        }
        private void tST_Rename_DoubleClick(object sender, EventArgs e)
        {
            tSTing_Rename();
        }
    }

}
