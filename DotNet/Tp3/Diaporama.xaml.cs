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
    public partial class Diaporama : Window
    {
        public Diaporama()
        {
            InitializeComponent();
        }
        
        public List<String> sDiapo = new List<String>();

        private int currentImage;

        private void Window_Activated(object sender, EventArgs e)
        {
            if(sDiapo.Count > 0)
            {
                ImageSourceConverter s = new ImageSourceConverter();
                Image1.Source = (ImageSource)s.ConvertFromString(sDiapo[1]);
                Image1.Source = (ImageSource)s.ConvertFromString(sDiapo[0]);
                currentImage = 1;
            }
        }

        private void VisibleToInvisible_Completed(object sender, EventArgs e)
        {
            Storyboard sb = (Storyboard)this.FindResource("InvisibleToVisible");
            sb.Begin();

            if (currentImage >= sDiapo.Count)
            {
                currentImage = 0;
            }
            else
            {
                currentImage++;
            }

            ImageSourceConverter s = new ImageSourceConverter();
            Image2.Source = (ImageSource)s.ConvertFromString(sDiapo[currentImage]);

        }

        private void InvisibleToVisible_Completed(object sender, EventArgs e)
        {
            if(currentImage >= sDiapo.Count)
            {
                currentImage= 0;
            } else
            {
                currentImage++ ;
            }

            ImageSourceConverter s = new ImageSourceConverter();
            Image1.Source = (ImageSource)s.ConvertFromString(sDiapo[currentImage]);

            Storyboard sb = (Storyboard)this.FindResource("VisibleToInvisible");
            sb.Begin();

        }
    }
}
