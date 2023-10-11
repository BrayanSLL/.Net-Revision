using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms; // Pour FolderBrowserDialog
using System.IO;

namespace TP_3
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog(); // Création de la boite de dialogue
            DialogResult dr = fbd.ShowDialog(); // Affiche la boite de dialogue

            if (dr == System.Windows.Forms.DialogResult.OK) // Si l'utilisateur clique sur OK
            {
                DirectoryInfo di = new DirectoryInfo(fbd.SelectedPath.ToString()); // Création d'un objet DirectoryInfo
                textBox1.Text = di.FullName; // Affiche le chemin du dossier sélectionné

                foreach (FileInfo fi in di.GetFiles("*.jpg").Concat(di.GetFiles("*.png"))) // Parcours les fichiers du dossier sélectionné
                {
                    lb1.Items.Add(fi.FullName); // Ajoute le nom du fichier dans la listBox
                }
            }
        }
    }
}
