using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace TP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadTreeView();
        }

        private void quittezToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Vérifiez si un élément est sélectionné.
            if (listView1.SelectedItems.Count > 0)
            {
                // Récupérez le premier élément sélectionné.
                ListViewItem item = listView1.SelectedItems[0];

                // Récupérez le chemin du répertoire à partir du Tag du nœud sélectionné.
                string FilePath = item.Tag.ToString();

                // Affichez le chemin du fichier dans la textBox.
                textBox1.Text = FilePath;

                //affichez la date de la dernière modification du fichier
                textBox2.Text = File.GetLastWriteTime(FilePath).Date.ToShortDateString();

                // Affichez la taille du fichier dans la textBox et en fonction de sa taille changer l'unite
                long size = new FileInfo(FilePath).Length;
                if (size < 1024)
                {
                    textBox3.Text = size.ToString() + " octets";
                }
                else if (size < 1048576)
                {
                    textBox3.Text = (size / 1024).ToString() + " Ko";
                }
                else if (size < 1073741824)
                {
                    textBox3.Text = (size / 1048576).ToString() + " Mo";
                }
                else
                {
                    textBox3.Text = (size / 1073741824).ToString() + " Go";
                }
                

            }
        }

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Récupérez le node sélectionné.
            TreeNode SelectedNode = e.Node;

            // Vérifier que le noeud sélectionné est un repertoire
            if (Directory.Exists(SelectedNode.Tag.ToString()))
            {

                // Récupérez le chemin du répertoire à partir du Tag du nœud sélectionné.
                string DirectoryPath = SelectedNode.Tag.ToString();

                LoadFilesIntoListView(DirectoryPath);
            }


        }

        private void LoadFilesIntoListView(string DirectoryPath)
        {
            // Effacez les éléments de la liste.
            listView1.Items.Clear();

            // Créez un objet DirectoryInfo pour le répertoire sélectionné.
            DirectoryInfo SelectedDirectory = new DirectoryInfo(DirectoryPath);

            //Liste des fichiers
            try
            {
                FileInfo[] Files = SelectedDirectory.GetFiles();

                // Parcourez les fichiers et ajoutez-les à la liste.
                foreach (FileInfo file in Files)
                {
                    // Créez un objet ListViewItem avec le nom du fichier.
                    ListViewItem item = new ListViewItem(file.Name);
                    //Le tag = le path du fichier
                    item.Tag = file.FullName;
                    // Associez l'image en fonction de l'extension du fichier.
                    switch (file.Extension.ToLower())
                    {
                        case ".txt":
                            item.ImageIndex = 0;
                            break;
                        case ".doc":
                        case ".docx":
                            item.ImageIndex = 16;
                            break;
                        case ".xls":
                        case ".xlsx":
                            item.ImageIndex = 28;
                            break;
                        case ".jpg":
                        case ".jpeg":
                        case ".png":
                        case ".gif":
                            item.ImageIndex = 19;
                            break;
                        case ".pdf":
                            item.ImageIndex = 22;
                            break;
                        case ".mp3":
                        case ".wav":
                            item.ImageIndex = 50;
                            break;
                        case ".avi":
                        case ".mp4":
                        case ".wmv":
                            item.ImageIndex = 50;
                            break;
                        default:
                            item.ImageIndex = 3;
                            break;
                    }
                    // Ajoutez d'autres informations si nécessaire.
                    item.SubItems.Add(file.Length.ToString());
                    // Ajoutez le fichier à la liste.
                    listView1.Items.Add(item);
                }
            }
            catch (Exception)
            { }

        }

        private void treeView2_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Level > 1)
            {
                TreeNode SelectNode = e.Node;
                SelectNode.Nodes.Clear();// Efface la node Vide
                ListRepertory(SelectNode);
            }
        }
        private void loadTreeView()
        {
            // Créez un node racine pour le TreeView.
            TreeNode rootNode = new TreeNode("Lecteurs");
            rootNode.Tag = "Lecteurs";

            // Associez une image au node racine si nécessaire.
            // rootNode.ImageIndex = ...;
            // rootNode.SelectedImageIndex = ...;

            // Ajoutez le node racine au TreeView.
            treeView2.Nodes.Add(rootNode);

            // Parcourez les lecteurs disponibles.
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                // Créez un node pour chaque lecteur.
                TreeNode driveNode = new TreeNode(drive.Name);

                // Associez l'image en fonction du type de lecteur.
                if (drive.DriveType == DriveType.CDRom)
                {
                    driveNode.ImageIndex = 1; // Index de l'icône de lecteur de DVD/CD dans l'ImageList
                    driveNode.SelectedImageIndex = 1; // Image sélectionnée pour le lecteur de DVD/CD
                }
                else
                {
                    driveNode.ImageIndex = 4; // Index de l'icône pour les autres lecteurs dans l'ImageList
                    driveNode.SelectedImageIndex = 4; // Image sélectionnée pour les autres lecteurs
                }

                // Associez le chemin complet à la propriété Tag.
                driveNode.Tag = drive.Name;

                // Ajoutez le node du lecteur sous le node racine.
                rootNode.Nodes.Add(driveNode);

                ListRepertory(driveNode);
            }

            // Définissez le TreeView comme étant la vue par défaut.
            treeView2.SelectedNode = rootNode;
        }

        private void ListRepertory(TreeNode ParentNode)
        {

            string DirectoryPath = ParentNode.Tag.ToString();

            DirectoryInfo ParentDirectory = new DirectoryInfo(DirectoryPath);

            foreach (DirectoryInfo SubDirectory in ParentDirectory.GetDirectories())
            {
                try
                {
                    // Node pour le répertoire 
                    TreeNode SubDirectoryNode = new TreeNode(SubDirectory.Name);
                    // Associez le chemin complet à la propriété Tag du node enfant.
                    SubDirectoryNode.Tag = SubDirectory.FullName;
                    try
                    {
                        if (SubDirectory.GetDirectories().Count() > 0)
                        {
                            SubDirectoryNode.Nodes.Add(new TreeNode());// Crée une Node Vide pour afficher les sous-dossier
                            SubDirectoryNode.ImageIndex = 4;
                            SubDirectoryNode.SelectedImageIndex = 4;

                        }
                    }
                    catch (Exception) { }
                    // Ajoutez le node enfant au node parent.
                    ParentNode.Nodes.Add(SubDirectoryNode);
                    //appel récursif pour les sous-répertoires

                }
                catch (Exception) { }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
            listView1.Refresh();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //Méthode lister les fichiers
        private void button1_Click(object sender, EventArgs e)
        {
            listView1.View = View.List;
            listView1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
            listView1.Refresh();
        }

        private void applicationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void listView1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {


                ListViewHitTestInfo hitTestInfo = listView1.HitTest(e.X, e.Y);
                if (hitTestInfo.Item != null)
                {
                    contextMenuStrip1.Show(listView1,e.X,e.Y);
                }else
                {
                    contextMenuStrip2.Show(listView1, e.X, e.Y);
                }
            }
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // Récupérez le premier élément sélectionné.
                ListViewItem item = listView1.SelectedItems[0];

                // Récupérez le chemin du répertoire à partir du Tag du nœud sélectionné.
                string FilePath = item.Tag.ToString();

                String tondirectory = new FileInfo(FilePath).Directory.FullName;
                //supprimer le fichier
                File.Delete(FilePath);

                LoadFilesIntoListView(tondirectory);
            }
        }

        private void copierToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count > 0)
            {
              
                    
                
                // Récupérez le premier élément sélectionné.
                ListViewItem item = listView1.SelectedItems[0];

                // Récupérez le chemin du répertoire à partir du Tag du nœud sélectionné.
                string FilePath = item.Tag.ToString();

                //copier le fichier
                File.Copy(FilePath, FilePath + " - Copie");

                //copier le fichier dans la liste
                listView1.Items.Add(item);
                
            }
        }

        private void collerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // Récupérez le premier élément sélectionné.
                ListViewItem item = listView1.SelectedItems[0];

                // Récupérez le chemin du répertoire à partir du Tag du nœud sélectionné.
                string FilePath = item.Tag.ToString();

                //coller le fichier
                File.Copy(FilePath, FilePath + " - Copie");

                //coller le fichier dans la liste
                listView1.Items.Add(item);
            }
        }
    }
}
