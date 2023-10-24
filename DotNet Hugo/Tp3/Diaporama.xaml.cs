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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Tp3
{
    /// <summary>
    /// Logique d'interaction pour Diaporama.xaml
    /// </summary>
    public partial class Diaporama : Window // Diaporama
    {
        public Diaporama() 
        {
            InitializeComponent(); 
        }
        
        public List<String> sDiapo = new List<String>(); // Liste des images du diaporama

        private int currentImage; // Image courante

        private void Window_Activated(object sender, EventArgs e) // Lorsque la fenêtre est activée
        {
            if(sDiapo.Count > 0) // Si la liste contient des images
            {
                ImageSourceConverter s = new ImageSourceConverter(); // Convertisseur d'image
                Image1.Source = (ImageSource)s.ConvertFromString(sDiapo[1]); // On affiche la première image
                Image1.Source = (ImageSource)s.ConvertFromString(sDiapo[0]); // On affiche la deuxième image
                currentImage = 1; // On initialise l'image courante
            }
        }

        private void VisibleToInvisible_Completed(object sender, EventArgs e) // Lorsque l'image devient invisible
        {
            Storyboard sb = (Storyboard)this.FindResource("InvisibleToVisible"); // On récupère l'animation
            sb.Begin(); // On l'a lance

            if (currentImage >= sDiapo.Count) // Si on est à la fin de la liste
            {
                currentImage = 0; // On revient au début
            }
            else // Sinon
            {
                currentImage++; // On passe à l'image suivante
            }

            ImageSourceConverter s = new ImageSourceConverter(); // Convertisseur d'image
            Image2.Source = (ImageSource)s.ConvertFromString(sDiapo[currentImage]); // On affiche l'image suivante

        }

        private void InvisibleToVisible_Completed(object sender, EventArgs e) // Lorsque l'image devient visible
        {
            if(currentImage >= sDiapo.Count) // Si on est à la fin de la liste
            {
                currentImage= 0; // On revient au début
            } else
            {
                currentImage++ ; // On passe à l'image suivante
            }

            ImageSourceConverter s = new ImageSourceConverter(); // Convertisseur d'image
            Image1.Source = (ImageSource)s.ConvertFromString(sDiapo[currentImage]); // On affiche l'image suivante

            Storyboard sb = (Storyboard)this.FindResource("VisibleToInvisible"); // On récupère l'animation
            sb.Begin(); // On l'a lance

        }
    }
}
