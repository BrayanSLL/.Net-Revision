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
            this.treeView1 = new System.Windows.Forms.TreeView();
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
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(1, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(409, 452);
            this.treeView1.TabIndex = 0;
            this.treeView1.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeExpand);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "app-x-yaml-icon (1).png");
            this.imageList1.Images.SetKeyName(1, "app-x-yaml-icon (2).png");
            this.imageList1.Images.SetKeyName(2, "app-x-yaml-icon (3).png");
            this.imageList1.Images.SetKeyName(3, "app-x-yaml-icon.png");
            this.imageList1.Images.SetKeyName(4, "doc-icon (1).png");
            this.imageList1.Images.SetKeyName(5, "doc-icon.png");
            this.imageList1.Images.SetKeyName(6, "docx-icon (1).png");
            this.imageList1.Images.SetKeyName(7, "docx-icon.png");
            this.imageList1.Images.SetKeyName(8, "jpeg-image-icon (1).png");
            this.imageList1.Images.SetKeyName(9, "jpeg-image-icon (2).png");
            this.imageList1.Images.SetKeyName(10, "jpeg-image-icon.png");
            this.imageList1.Images.SetKeyName(11, "pdf-icon (1).png");
            this.imageList1.Images.SetKeyName(12, "pdf-icon (2).png");
            this.imageList1.Images.SetKeyName(13, "pdf-icon.png");
            this.imageList1.Images.SetKeyName(14, "txt-icon (1).png");
            this.imageList1.Images.SetKeyName(15, "txt-icon (2).png");
            this.imageList1.Images.SetKeyName(16, "txt-icon.png");
            this.imageList1.Images.SetKeyName(17, "xlsx-icon (1).png");
            this.imageList1.Images.SetKeyName(18, "xlsx-icon (2).png");
            this.imageList1.Images.SetKeyName(19, "xlsx-icon.png");
            this.imageList1.Images.SetKeyName(20, "liste.png");
            this.imageList1.Images.SetKeyName(21, "vista-013.ico");
            this.imageList1.Images.SetKeyName(22, "vista-014.ico");
            this.imageList1.Images.SetKeyName(23, "vista-015.ico");
            this.imageList1.Images.SetKeyName(24, "vista-016.ico");
            this.imageList1.Images.SetKeyName(25, "vista-017.ico");
            this.imageList1.Images.SetKeyName(26, "vista-018.ico");
            this.imageList1.Images.SetKeyName(27, "vista-019.ico");
            this.imageList1.Images.SetKeyName(28, "vista-020.ico");
            this.imageList1.Images.SetKeyName(29, "vista-021.ico");
            this.imageList1.Images.SetKeyName(30, "vista-022.ico");
            this.imageList1.Images.SetKeyName(31, "vista-023.ico");
            this.imageList1.Images.SetKeyName(32, "vista-024.ico");
            this.imageList1.Images.SetKeyName(33, "vista-025.ico");
            this.imageList1.Images.SetKeyName(34, "vista-026.ico");
            this.imageList1.Images.SetKeyName(35, "vista-027.ico");
            this.imageList1.Images.SetKeyName(36, "vista-028.ico");
            this.imageList1.Images.SetKeyName(37, "vista-029.ico");
            this.imageList1.Images.SetKeyName(38, "vista-030.ico");
            this.imageList1.Images.SetKeyName(39, "vista-031.ico");
            this.imageList1.Images.SetKeyName(40, "vista-032.ico");
            this.imageList1.Images.SetKeyName(41, "vista-033.ico");
            this.imageList1.Images.SetKeyName(42, "vista-034.ico");
            this.imageList1.Images.SetKeyName(43, "vista-035.ico");
            this.imageList1.Images.SetKeyName(44, "vista-036.ico");
            this.imageList1.Images.SetKeyName(45, "vista-037.ico");
            this.imageList1.Images.SetKeyName(46, "vista-038.ico");
            this.imageList1.Images.SetKeyName(47, "vista-039.ico");
            this.imageList1.Images.SetKeyName(48, "vista-040.ico");
            this.imageList1.Images.SetKeyName(49, "vista-041.ico");
            this.imageList1.Images.SetKeyName(50, "vista-042.ico");
            this.imageList1.Images.SetKeyName(51, "vista-043.ico");
            this.imageList1.Images.SetKeyName(52, "vista-044.ico");
            this.imageList1.Images.SetKeyName(53, "vista-045.ico");
            this.imageList1.Images.SetKeyName(54, "vista-046.ico");
            this.imageList1.Images.SetKeyName(55, "vista-047.ico");
            this.imageList1.Images.SetKeyName(56, "vista-048.ico");
            this.imageList1.Images.SetKeyName(57, "vista-121.ico");
            this.imageList1.Images.SetKeyName(58, "vista-122.ico");
            this.imageList1.Images.SetKeyName(59, "vista-123.ico");
            this.imageList1.Images.SetKeyName(60, "vista-124.ico");
            this.imageList1.Images.SetKeyName(61, "icon_accueil.png");
            this.imageList1.Images.SetKeyName(62, "icon1 - Copie.png");
            this.imageList1.Images.SetKeyName(63, "icon1.png");
            this.imageList1.Images.SetKeyName(64, "icon2.png");
            this.imageList1.Images.SetKeyName(65, "icon3.bmp");
            this.imageList1.Images.SetKeyName(66, "icon4.bmp");
            this.imageList1.Images.SetKeyName(67, "icone_precedent.png");
            this.imageList1.Images.SetKeyName(68, "icon-up-images.png");
            this.imageList1.Images.SetKeyName(69, "inav.bmp");
            this.imageList1.Images.SetKeyName(70, "irefresh.bmp");
            this.imageList1.Images.SetKeyName(71, "open.bmp");
            this.imageList1.Images.SetKeyName(72, "save.bmp");
            this.imageList1.Images.SetKeyName(73, "Computer-icon.png");
            this.imageList1.Images.SetKeyName(74, "logo-3il-part.png");
            this.imageList1.Images.SetKeyName(75, "USB-icon - Copie.png");
            this.imageList1.Images.SetKeyName(76, "USB-icon.png");
            this.imageList1.Images.SetKeyName(77, "vista-123.ico");
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(440, 59);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(348, 182);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(635, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Small";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(554, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "list";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(716, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Large";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(554, 247);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(234, 22);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(691, 299);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(529, 299);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(437, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Emplacement";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(437, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Modifié le";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(641, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Taille";
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
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
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
    }
}

