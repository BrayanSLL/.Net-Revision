using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadTreeView();
        }

        private void LoadTreeView()
        {
            TreeNode racine = new TreeNode("racine");
            racine.Tag = "racine";
            racine.ImageIndex = 0;
            treeView1.Nodes.Add(racine);
            DriveInfo[] drives = DriveInfo.GetDrives();

            try
            {
                foreach (DriveInfo drive in drives)
                {
                    TreeNode treeNode = new TreeNode(drive.Name);
                    treeNode.Tag = drive.Name;
                    switch (drive.DriveType)
                    {
                        case DriveType.Removable:
                            treeNode.ImageIndex = 2;
                            treeNode.SelectedImageIndex = 2;
                            break;
                        case DriveType.Fixed:
                            treeNode.ImageIndex = 1;
                            treeNode.SelectedImageIndex = 1;
                            break;
                        case DriveType.Network:
                            treeNode.ImageIndex = 4;
                            treeNode.SelectedImageIndex = 4;
                            break;
                        case DriveType.CDRom:
                            treeNode.ImageIndex = 3;
                            treeNode.SelectedImageIndex = 3;
                            break;
                        default:
                            break;
                    }

                    treeView1.Nodes[0].Nodes.Add(treeNode);
                    directoryList(treeNode);
                }
            }
            catch (Exception)
            {}
            


        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void directoryList(TreeNode parentDirectory)
        {
            DirectoryInfo info = new DirectoryInfo(parentDirectory.Tag.ToString());
            foreach (DirectoryInfo directory in info.EnumerateDirectories())
            {
                try
                {
                    TreeNode node = new TreeNode(directory.Name);
                    node.Tag = directory.FullName;
                    node.ImageIndex = 5;
                    node.SelectedImageIndex = 6;
                    try
                    {
                        if (directory.GetDirectories().Count() > 0)
                        {
                            node.Nodes.Add(new TreeNode());
                        }
                        parentDirectory.Nodes.Add(node);
                    }
                    catch (Exception)
                    {}
                
                }
                catch (Exception)
                {}    
            }
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if(e.Node.Level > 1)
            {
                e.Node.Nodes.Clear();
                directoryList(e.Node);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            loadListView(new DirectoryInfo(e.Node.Tag.ToString()));
        }

        private void loadListView(DirectoryInfo directory)
        {
            listView1.Items.Clear();
            try
            {
                foreach (FileInfo file in directory.GetFiles())
                {
                    ListViewItem item = new ListViewItem(file.Name);
                    item.Name = file.Name;
                    item.Tag = file.FullName;
                    item.ImageIndex = getImage(file.Extension);
                    listView1.Items.Add(item);
                }
            }
            catch (Exception)
            {}
        }

        private int getImage(string ext)
        {
            switch (ext)
            {
                case ".zip":
                    return 1;
                case ".exe":
                    return 0;
                case ".pdf":
                    return 3;
                case ".txt":
                    return 5;
                case ".jpg":
                case ".png":
                    return 4;
                default:
                    return 2;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.View = View.List;
            listView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
            listView1.Refresh();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
            listView1.Refresh();

        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            FileInfo file = new FileInfo(e.Item.Tag.ToString());
            textPath.Text = file.FullName;
            textDate.Text = file.LastWriteTime.ToShortDateString();
            if (file.Length < 1000)
            {
                textSize.Text = file.Length.ToString() + " o";
            } else if (file.Length < 1000000 && file.Length >= 1000)
            {
                textSize.Text = (file.Length/ 1000).ToString() + " ko";
            }
            else if (file.Length < 1000000000 && file.Length >= 1000000)
            {
                textSize.Text = (file.Length / 1000000).ToString() + " Mo";
            }
            else if (file.Length < 1000000000000 && file.Length >= 1000000000)
            {
                textSize.Text = (file.Length / 1000000000).ToString() + " Go";
            }
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo(listView1.SelectedItems[0].Tag.ToString());
            string message = "Voulez vous supprimer ce fichier ?";
            string caption = "Confirmation suppression";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                DirectoryInfo parentDirectory = file.Directory;
                try
                {
                    file.Delete();
                }
                catch (Exception)
                { }
                loadListView(parentDirectory);
                listView1.Refresh();
               
            }
        }

        private void copierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringCollection data = new StringCollection();
            data.Add(listView1.SelectedItems[0].Tag.ToString());
            Clipboard.SetFileDropList(data);
        }

        private void collerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringCollection data = Clipboard.GetFileDropList();
            
            try
            {
                FileInfo file = new FileInfo(data[0]);
                DirectoryInfo parentDirectory = new DirectoryInfo(treeView1.SelectedNode.Tag.ToString());
                if(parentDirectory.GetFiles(file.Name).Count() > 0)
                {
                    file.CopyTo(parentDirectory.FullName + "\\Copie de " + file.Name);
                }
                else
                {
                    file.CopyTo(parentDirectory.FullName + "\\" + file.Name);
                }

                loadListView(parentDirectory);
                listView1.Refresh();
            }
            catch (Exception)
            { }
            
        }

        private void listView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ListViewHitTestInfo hitTestInfo = listView1.HitTest(e.X, e.Y);
                if (hitTestInfo.Item != null)
                {
                    contextMenuStrip1.Show(listView1, e.X, e.Y);
                }
                else
                {
                    contextMenuStrip2.Show(listView1, e.X, e.Y);
                }
            }
        }

        private void listView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(e.Item, DragDropEffects.Move);

        }

        private void treeView1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void treeView1_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void treeView1_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode node = treeView1.GetNodeAt(treeView1.PointToClient(new Point(e.X, e.Y)));
            if (node != null)
            {
                ListViewItem item = (ListViewItem)e.Data.GetData(typeof(ListViewItem));
                if (item != null)
                {
                    DirectoryInfo parentDirectory = new DirectoryInfo(node.Tag.ToString());
                    if (parentDirectory.GetFiles(item.Name).Count() > 0)
                    {
                        try
                        {
                            String source = item.Tag.ToString();
                            String destination = node.Tag.ToString() + "\\" + item.Name.ToString();
                            File.Move(source, destination);
                            loadListView(new DirectoryInfo(node.Tag.ToString()));
                            listView1.Refresh();

                        }
                        catch (Exception)
                        { }
                    }
                }
            }
        }
    }
}
