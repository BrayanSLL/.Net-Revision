namespace TP1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quittezToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.collerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quittezToolStripMenuItem});
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.applicationToolStripMenuItem.Text = "Application";
            this.applicationToolStripMenuItem.Click += new System.EventHandler(this.applicationToolStripMenuItem_Click);
            // 
            // quittezToolStripMenuItem
            // 
            this.quittezToolStripMenuItem.Name = "quittezToolStripMenuItem";
            this.quittezToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.quittezToolStripMenuItem.Text = "Quittez";
            this.quittezToolStripMenuItem.Click += new System.EventHandler(this.quittezToolStripMenuItem_Click);
            // 
            // treeView2
            // 
            this.treeView2.ImageIndex = 0;
            this.treeView2.ImageList = this.imageList1;
            this.treeView2.Location = new System.Drawing.Point(0, 43);
            this.treeView2.Name = "treeView2";
            this.treeView2.SelectedImageIndex = 0;
            this.treeView2.Size = new System.Drawing.Size(383, 395);
            this.treeView2.TabIndex = 2;
            this.treeView2.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView2_BeforeExpand);
            this.treeView2.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView2_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "txt-icon.png");
            this.imageList1.Images.SetKeyName(1, "vista-034.ico");
            this.imageList1.Images.SetKeyName(2, "arrow-disque-telecharger-disque-dur-hdd-icone-7580-32.png");
            this.imageList1.Images.SetKeyName(3, "042.ICO");
            this.imageList1.Images.SetKeyName(4, "043.ICO");
            this.imageList1.Images.SetKeyName(5, "FOLDER04.ICO");
            this.imageList1.Images.SetKeyName(6, "icon1.png");
            this.imageList1.Images.SetKeyName(7, "icon2.png");
            this.imageList1.Images.SetKeyName(8, "icon4.bmp");
            this.imageList1.Images.SetKeyName(9, "Computer-icon.png");
            this.imageList1.Images.SetKeyName(10, "USB-icon - Copie.png");
            this.imageList1.Images.SetKeyName(11, "app-x-yaml-icon (1).png");
            this.imageList1.Images.SetKeyName(12, "app-x-yaml-icon (2).png");
            this.imageList1.Images.SetKeyName(13, "app-x-yaml-icon (3).png");
            this.imageList1.Images.SetKeyName(14, "app-x-yaml-icon.png");
            this.imageList1.Images.SetKeyName(15, "doc-icon (1).png");
            this.imageList1.Images.SetKeyName(16, "doc-icon.png");
            this.imageList1.Images.SetKeyName(17, "docx-icon (1).png");
            this.imageList1.Images.SetKeyName(18, "docx-icon.png");
            this.imageList1.Images.SetKeyName(19, "jpeg-image-icon (1).png");
            this.imageList1.Images.SetKeyName(20, "jpeg-image-icon (2).png");
            this.imageList1.Images.SetKeyName(21, "jpeg-image-icon.png");
            this.imageList1.Images.SetKeyName(22, "pdf-icon (1).png");
            this.imageList1.Images.SetKeyName(23, "pdf-icon (2).png");
            this.imageList1.Images.SetKeyName(24, "pdf-icon.png");
            this.imageList1.Images.SetKeyName(25, "txt-icon (1).png");
            this.imageList1.Images.SetKeyName(26, "txt-icon (2).png");
            this.imageList1.Images.SetKeyName(27, "txt-icon.png");
            this.imageList1.Images.SetKeyName(28, "xlsx-icon (1).png");
            this.imageList1.Images.SetKeyName(29, "xlsx-icon (2).png");
            this.imageList1.Images.SetKeyName(30, "xlsx-icon.png");
            this.imageList1.Images.SetKeyName(31, "liste.png");
            this.imageList1.Images.SetKeyName(32, "vista-013.ico");
            this.imageList1.Images.SetKeyName(33, "vista-014.ico");
            this.imageList1.Images.SetKeyName(34, "vista-015.ico");
            this.imageList1.Images.SetKeyName(35, "vista-016.ico");
            this.imageList1.Images.SetKeyName(36, "vista-017.ico");
            this.imageList1.Images.SetKeyName(37, "vista-018.ico");
            this.imageList1.Images.SetKeyName(38, "vista-019.ico");
            this.imageList1.Images.SetKeyName(39, "vista-020.ico");
            this.imageList1.Images.SetKeyName(40, "vista-021.ico");
            this.imageList1.Images.SetKeyName(41, "vista-022.ico");
            this.imageList1.Images.SetKeyName(42, "vista-023.ico");
            this.imageList1.Images.SetKeyName(43, "vista-024.ico");
            this.imageList1.Images.SetKeyName(44, "vista-025.ico");
            this.imageList1.Images.SetKeyName(45, "vista-026.ico");
            this.imageList1.Images.SetKeyName(46, "vista-027.ico");
            this.imageList1.Images.SetKeyName(47, "vista-028.ico");
            this.imageList1.Images.SetKeyName(48, "vista-029.ico");
            this.imageList1.Images.SetKeyName(49, "vista-030.ico");
            this.imageList1.Images.SetKeyName(50, "vista-031.ico");
            this.imageList1.Images.SetKeyName(51, "vista-032.ico");
            this.imageList1.Images.SetKeyName(52, "vista-033.ico");
            this.imageList1.Images.SetKeyName(53, "vista-034.ico");
            this.imageList1.Images.SetKeyName(54, "vista-035.ico");
            this.imageList1.Images.SetKeyName(55, "vista-036.ico");
            this.imageList1.Images.SetKeyName(56, "vista-037.ico");
            this.imageList1.Images.SetKeyName(57, "vista-038.ico");
            this.imageList1.Images.SetKeyName(58, "vista-039.ico");
            this.imageList1.Images.SetKeyName(59, "vista-040.ico");
            this.imageList1.Images.SetKeyName(60, "vista-041.ico");
            this.imageList1.Images.SetKeyName(61, "vista-042.ico");
            this.imageList1.Images.SetKeyName(62, "vista-043.ico");
            this.imageList1.Images.SetKeyName(63, "vista-044.ico");
            this.imageList1.Images.SetKeyName(64, "vista-045.ico");
            this.imageList1.Images.SetKeyName(65, "vista-046.ico");
            this.imageList1.Images.SetKeyName(66, "vista-047.ico");
            this.imageList1.Images.SetKeyName(67, "vista-048.ico");
            this.imageList1.Images.SetKeyName(68, "vista-121.ico");
            this.imageList1.Images.SetKeyName(69, "vista-122.ico");
            this.imageList1.Images.SetKeyName(70, "vista-123.ico");
            this.imageList1.Images.SetKeyName(71, "vista-124.ico");
            this.imageList1.Images.SetKeyName(72, "application-un-fichier-icone-6489-16.png");
            this.imageList1.Images.SetKeyName(73, "application-un-fichier-icone-6489-32.png");
            this.imageList1.Images.SetKeyName(74, "arrow-disque-telecharger-disque-dur-hdd-icone-7580-16.png");
            this.imageList1.Images.SetKeyName(75, "arrow-disque-telecharger-disque-dur-hdd-icone-7580-32.png");
            this.imageList1.Images.SetKeyName(76, "blanc-fichier-un-dossier-icone-9522-16.png");
            this.imageList1.Images.SetKeyName(77, "blanc-fichier-un-dossier-icone-9522-32.png");
            this.imageList1.Images.SetKeyName(78, "disque-go-icone-8759-16.png");
            this.imageList1.Images.SetKeyName(79, "disque-go-icone-8759-32.png");
            this.imageList1.Images.SetKeyName(80, "document-bleu-fichier-g98-papier-icone-9569-16.png");
            this.imageList1.Images.SetKeyName(81, "document-bleu-fichier-g98-papier-icone-9569-32.png");
            this.imageList1.Images.SetKeyName(82, "document-un-fichier-icone-9015-16.png");
            this.imageList1.Images.SetKeyName(83, "document-un-fichier-icone-9015-32.png");
            this.imageList1.Images.SetKeyName(84, "dossier-de-la-page-icone-5144-16.png");
            this.imageList1.Images.SetKeyName(85, "dossier-de-la-page-icone-5144-32.png");
            this.imageList1.Images.SetKeyName(86, "dossier-vert-icone-6633-16.png");
            this.imageList1.Images.SetKeyName(87, "dossier-vert-icone-6633-32.png");
            this.imageList1.Images.SetKeyName(88, "dossier-vert-ouvert-icone-8269-16.png");
            this.imageList1.Images.SetKeyName(89, "dossier-vert-ouvert-icone-8269-128.png");
            this.imageList1.Images.SetKeyName(90, "dvd-go-icone-5554-16.png");
            this.imageList1.Images.SetKeyName(91, "dvd-go-icone-5554-32.png");
            this.imageList1.Images.SetKeyName(92, "fichier-depot-un-dossier-complet-papier-icone-3848-16.png");
            this.imageList1.Images.SetKeyName(93, "fichier-depot-un-dossier-complet-papier-icone-3848-32.png");
            this.imageList1.Images.SetKeyName(94, "fichier-windows-icone-9317-16.png");
            this.imageList1.Images.SetKeyName(95, "fichier-windows-icone-9317-32.png");
            this.imageList1.Images.SetKeyName(96, "hd-fenetres-icone-4421-16.png");
            this.imageList1.Images.SetKeyName(97, "hd-fenetres-icone-4421-32.png");
            this.imageList1.Images.SetKeyName(98, "lecteur-dvd-dvd-icone-9537-16.png");
            this.imageList1.Images.SetKeyName(99, "lecteur-dvd-dvd-icone-9537-32.png");
            this.imageList1.Images.SetKeyName(100, "lecteur-optique-icone-8106-16.png");
            this.imageList1.Images.SetKeyName(101, "lecteur-optique-icone-8106-32.png");
            this.imageList1.Images.SetKeyName(102, "ordinateur-pc-icone-6183-16.png");
            this.imageList1.Images.SetKeyName(103, "ordinateur-pc-icone-6183-48.png");
            this.imageList1.Images.SetKeyName(104, "042.ICO");
            this.imageList1.Images.SetKeyName(105, "043.ICO");
            this.imageList1.Images.SetKeyName(106, "119.ICO");
            this.imageList1.Images.SetKeyName(107, "CD-ROM Drive.ico");
            this.imageList1.Images.SetKeyName(108, "CRDFLE07.ICO");
            this.imageList1.Images.SetKeyName(109, "DRAG2PG.ICO");
            this.imageList1.Images.SetKeyName(110, "DRIVE.ICO");
            this.imageList1.Images.SetKeyName(111, "DRIVE-C1.ICO");
            this.imageList1.Images.SetKeyName(112, "Empty Recycle Bin.ico");
            this.imageList1.Images.SetKeyName(113, "EXPLORER.ICO");
            this.imageList1.Images.SetKeyName(114, "FOLDER04.ICO");
            this.imageList1.Images.SetKeyName(115, "INSDISK.ICO");
            this.imageList1.Images.SetKeyName(116, "network.bmp");
            this.imageList1.Images.SetKeyName(117, "network.png");
            this.imageList1.Images.SetKeyName(118, "icon_accueil.png");
            this.imageList1.Images.SetKeyName(119, "icon1 - Copie.png");
            this.imageList1.Images.SetKeyName(120, "icon1.png");
            this.imageList1.Images.SetKeyName(121, "icon2.png");
            this.imageList1.Images.SetKeyName(122, "icon3.bmp");
            this.imageList1.Images.SetKeyName(123, "icon4.bmp");
            this.imageList1.Images.SetKeyName(124, "icone_precedent.png");
            this.imageList1.Images.SetKeyName(125, "icon-up-images.png");
            this.imageList1.Images.SetKeyName(126, "inav.bmp");
            this.imageList1.Images.SetKeyName(127, "irefresh.bmp");
            this.imageList1.Images.SetKeyName(128, "open.bmp");
            this.imageList1.Images.SetKeyName(129, "save.bmp");
            this.imageList1.Images.SetKeyName(130, "Computer-icon.png");
            this.imageList1.Images.SetKeyName(131, "logo-3il-part.png");
            this.imageList1.Images.SetKeyName(132, "USB-icon - Copie.png");
            this.imageList1.Images.SetKeyName(133, "USB-icon.png");
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(469, 77);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(329, 215);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(459, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(562, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Small";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(678, 48);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Large";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(521, 322);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 22);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(521, 368);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(110, 22);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(701, 365);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(75, 22);
            this.textBox3.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(466, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Path";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Last Modification";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(628, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Taille";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copierToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(148, 52);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // copierToolStripMenuItem
            // 
            this.copierToolStripMenuItem.Name = "copierToolStripMenuItem";
            this.copierToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.copierToolStripMenuItem.Text = "Copier";
            this.copierToolStripMenuItem.Click += new System.EventHandler(this.copierToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.collerToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(211, 56);
            // 
            // collerToolStripMenuItem
            // 
            this.collerToolStripMenuItem.Name = "collerToolStripMenuItem";
            this.collerToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.collerToolStripMenuItem.Text = "Coller";
            this.collerToolStripMenuItem.Click += new System.EventHandler(this.collerToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.treeView2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quittezToolStripMenuItem;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem collerToolStripMenuItem;
    }
}

