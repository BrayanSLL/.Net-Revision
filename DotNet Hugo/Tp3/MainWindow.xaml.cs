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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            listBox.Items.Clear();
            
            FolderBrowserDialog browserDialog = new FolderBrowserDialog();
            if(browserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK )
            { 
                DirectoryInfo directory = new DirectoryInfo(browserDialog.SelectedPath);
                textBox.Text = directory.FullName;

                foreach (FileInfo file in directory.GetFiles() ) 
                {
                    if (file.Extension == ".jpg")
                    {
                        listBox.Items.Add(file.FullName);
                    }
                }
            }
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(listBox.SelectedItem != null)
            {
                Photo photo = new Photo(listBox.SelectedItem.ToString());

                lb1.Content = photo.Source;
                lb2.Content = photo.Metadata.DateTaken.ToString();
                lb3.Content = photo.Metadata.Title;
                lb4.Content = photo.Metadata.Model;
                lb5.Content = photo.Metadata.Application;
                lb6.Content = photo.Metadata.IsoSpeed;
                lb7.Content = photo.Metadata.Ouverture;
                lb8.Content = photo.Metadata.Focal;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Diaporama diaporama = new Diaporama();

            diaporama.sDiapo.Clear();

            foreach (String item in listBox.Items)
            {
                diaporama.sDiapo.Add(item);
            }

            diaporama.ShowDialog();
        }
    }
}
