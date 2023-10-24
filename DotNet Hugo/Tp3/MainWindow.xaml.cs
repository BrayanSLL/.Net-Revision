using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace Tp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window 
    {
        public MainWindow() 
        {
            InitializeComponent(); 
        }

        private void Button_Click(object sender, RoutedEventArgs e) // Bouton Parcourir
        {
            listBox.Items.Clear(); // On vide la liste
            
            FolderBrowserDialog browserDialog = new FolderBrowserDialog(); // On crée une fenêtre de parcours de dossier
            if(browserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK ) // Si l'utilisateur a sélectionné un dossier
            { 
                DirectoryInfo directory = new DirectoryInfo(browserDialog.SelectedPath); // On récupère le dossier sélectionné
                textBox.Text = directory.FullName; // On affiche le chemin du dossier

                foreach (FileInfo file in directory.GetFiles() )  // Pour chaque fichier du dossier
                {
                    if (file.Extension == ".jpg") // Si c'est une image jpg
                    {
                        listBox.Items.Add(file.FullName); // On l'ajoute à la liste
                    }
                }
            }
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e) // Lorsqu'un élément de la liste est sélectionné
        {
            if(listBox.SelectedItem != null) // Si un élément est sélectionné
            {
                Photo photo = new Photo(listBox.SelectedItem.ToString()); // On crée une nouvelle photo avec le chemin de l'image sélectionnée

                lb1.Content = photo.Source; // On affiche les informations de la photo
                lb2.Content = photo.Metadata.DateTaken.ToString(); // On affiche les informations de la photo
                lb3.Content = photo.Metadata.Title; 
                lb4.Content = photo.Metadata.Model;
                lb5.Content = photo.Metadata.Application;
                lb6.Content = photo.Metadata.IsoSpeed;
                lb7.Content = photo.Metadata.Ouverture;
                lb8.Content = photo.Metadata.Focal;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) // Bouton Diaporama
        {
            Diaporama diaporama = new Diaporama(); // On crée une nouvelle fenêtre diaporama

            diaporama.sDiapo.Clear(); // On vide la liste des images

            foreach (String item in listBox.Items) // Pour chaque image de la liste
            {
                diaporama.sDiapo.Add(item); // On l'ajoute à la liste des images du diaporama
            }

            diaporama.ShowDialog(); // On affiche la fenêtre diaporama
        }
    }
}
