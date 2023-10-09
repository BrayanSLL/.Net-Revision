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

namespace TP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadTreeView();
        }

        // Création de la fonction qui va lister les sous-dossiers et les fichiers du dossier sélectionné
        private void ListRepertoire(TreeNode _node)
        {
            _node.Nodes.Clear(); // Suppression des nodes existants
            DirectoryInfo dir = new DirectoryInfo(_node.Tag.ToString()); // Création d'un objet de type DirectoryInfo qui va contenir les informations du dossier sélectionné

            // Création d'une boucle foreach qui va parcourir les sous-dossiers du dossier sélectionné
            foreach (DirectoryInfo dif in dir.GetDirectories())
            {
                try
                {
                    TreeNode node = new TreeNode(dif.Name); // Création d'un node
                    node.Tag = dif.FullName; // Affectation du chemin complet
                    node.ImageIndex = 0; // Affectation de l'image
                    _node.Nodes.Add(node); // Ajout du node au node sélectionné

                    if (dif.GetDirectories().Count() > 0) // Si le dossier contient des sous-dossiers
                    {
                        node.Nodes.Add("_"); // Ajout d'un node vide pour avoir un "+" devant le dossier
                    }
                }
                catch { }
        }
        }

        // Création de la fonction LoadTreeView qui permet de charger les données dans le TreeView qui sera appelé à la création de la fenêtre
        private void LoadTreeView()
        {
        
            // Dans cette fonction, créez le node racine de votre « TreeView » (classe TreeNode, texte et tag valant « racine »),et ajoutez-le à votre « TreeView »
            //création d'un node racine
            TreeNode racine = new TreeNode("racine");
            treeView1.Nodes.Add(racine);
            //création d'une boucle for each qui permet de parcourir les dossiers du dossier
            //Dans la boucle pour chaque entrée (disque local ou réseau, lecteur) créez un nouveau objet node, affectez lui son nom, affectez à sa propriété tag le chemin complet, et ajoutez le au node racine

            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                try
                {
                    TreeNode node = new TreeNode(drive.Name); //création d'un node
                    node.Tag = drive.Name; //affectation du chemin complet

                    //Associez chaque node à une image adéquate de l'objet ImageList
                    if (drive.DriveType == DriveType.Fixed) // si c'est un DD
                    {
                        node.ImageIndex = 32;
                    }
                    else if (drive.DriveType == DriveType.Removable) // Si clé USB
                    {
                        node.ImageIndex = 75;
                    }
                    else if (drive.DriveType == DriveType.Network) // Si Réseau
                    {
                        node.ImageIndex = 28;
                    }
                    else
                    {
                        node.ImageIndex = 77;
                    }
                    racine.Nodes.Add(node); //ajout du node à la racine
                    ListRepertoire(node); //appel de la fonction ListRepertoire


                }
                catch (System.Exception)
                {
                    
                    throw;
                }
                
            }
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e) // Evenement qui se déclenche avant l'expansion d'un node
        {
            if (e.Node.Level > 1) // evite le node racine et les lecteurs deja chargés
            {
                ListRepertoire(e.Node); // e.Node = le node sur lequel l'utilisateur a cliqué sur +

            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        { // Evenement déclanché apès la selection d'un node
            if (e.Node.Level > 0) // Evite le node Racine qui n'a pas de fichiers
            {
                LoadListView(e.Node.Tag.ToString()); // Appel de la fonction LoadListView
            }

        }

        private void LoadListView(String sPathDirectory) // Fonction qui va charger les fichiers du dossier sélectionné dans la ListView
        {
            listView1.Items.Clear(); // Suppression des items existants
            DirectoryInfo dir = new DirectoryInfo(sPathDirectory); // Création d'un objet de type DirectoryInfo qui va contenir les informations du dossier sélectionné
            try
            {
                // Création d'une boucle foreach qui va parcourir les fichiers du dossier sélectionné
                foreach (FileInfo file in dir.GetFiles())
                {
                    int i = 0;
                    // listview1 = la list view qui va affihcer les fichiers elle a une collection d'items
                    if (file.Name.Substring(file.Name.LastIndexOf(".")).ToLower() == ".pdf")
                    {
                        i = 11;
                    }

                    listView1.Items.Add(file.Name, 11); // Ajout du fichier à la ListView

                    // Autre méthode pour affecter le bon icône
                    string ext = System.IO.Path.GetExtension(file.Name);
                    // récupère l'extension du fichier
                    if (ext.ToLower() == ".pdf") { i = 11; }
                    if ((ext.ToLower() == ".doc") || (ext.ToLower() == ".docx")) { i = 12; }
                    if ((ext.ToLower() == ".xls") || (ext.ToLower() == ".xlsx")) { i = 13; }
                    if ((ext.ToLower() == ".jpg") || (ext.ToLower() == ".jpeg")) { i = 14; }
                    if ((ext.ToLower() == ".txt")) { i = 15; }
                    listView1.Items[listView1.Items.Count - 1].ImageIndex = i;
                }
            }
            catch { }
            }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Code qui va afficher les sous-dossiers/fichiers sous forme de liste
            listView1.View = View.List;
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Code qui va afficher les icones en petit
            listView1.View = View.SmallIcon;
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // code qui va afficher les icones en grand
            listView1.View = View.LargeIcon;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count > 0) // Si un fichier est sélectionné
                {
                    String sPath = treeView1.SelectedNode.Tag.ToString(); // Chemin complet du fichier
                    sPath += "\\" + listView1.SelectedItems[0].Text; // Ajout du nom du fichier au chemin complet + nom du fichier sélectionné
                    textBox1.Text = sPath; // Affichage du chemin complet dans la TextBox

                    FileInfo fi = new FileInfo(sPath); // Création d'un objet de type FileInfo qui va contenir les informations du fichier sélectionné
                    textBox3.Text = fi.LastWriteTime.ToString("dd/MM/YYYY hh:mm"); // Affichage de la date de dernière modification du fichier dans la TextBox
                    double dSize = fi.Length; // Taille du fichier

                    if(dSize<1024){
                        textBox2.Text = dSize.ToString("0.00") + " octets"; // Affichage de la taille du fichier dans la TextBox
                    }else{
                        dSize = dSize / 1024;
                        if (dSize < 1024)
                        {
                            textBox2.Text = dSize.ToString("0.00") + " Ko"; // Affichage de la taille du fichier dans la TextBox
                        }
                        else
                        {
                            dSize = dSize / 1024;
                            if (dSize < 1024)
                            {
                                textBox2.Text = dSize.ToString("0.00") + " Mo"; // Affichage de la taille du fichier dans la TextBox
                            }
                            else
                            {
                                dSize = dSize / 1024;
                                textBox2.Text = dSize.ToString("0.00") + " Go"; // Affichage de la taille du fichier dans la TextBox
                            }
                        }  
                    }
                }
            }
            catch{ }
        }
    }
    }
