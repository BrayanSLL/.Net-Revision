using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Tp3
{
    internal class Photo // Classe Photo
    {
        private string _path; // Chemin de l'image
        private Uri _source; // Source de l'image
        private PhotoMetadata _phmetadata; // Métadonnées de l'image

        public Photo(string path) // Constructeur
        {
            _path = path; // On initialise le chemin de l'image
            _source = null; // On initialise la source de l'image

            if (path != "")     // Si le chemin n'est pas vide
            {
                _source = new Uri(path); // On initialise la source de l'image
                _phmetadata = new PhotoMetadata(_source); // On initialise les métadonnées de l'image
            }
        }

        public override string ToString() // Méthode ToString
        {
            return _source.ToString(); // On retourne la source de l'image
        }

        public string Source { get { return _path; } } // Propriété Source

        public PhotoMetadata Metadata { get { return _phmetadata; } } // Propriété Metadata

        internal class PhotoMetadata // Classe PhotoMetadata
        {
            BitmapMetadata _metadata; // Métadonnées de l'image

            public PhotoMetadata(Uri imageUri) // Constructeur
            {
                BitmapFrame frame = BitmapFrame.Create(imageUri, BitmapCreateOptions.DelayCreation, BitmapCacheOption.None); // On crée une nouvelle image
                _metadata = (BitmapMetadata)frame.Metadata; // On récupère les métadonnées de l'image
            }

            public DateTime? DateTaken // Propriété DateTaken
            {
                get 
                {
                    Object val = _metadata.DateTaken; // On récupère la date de prise de vue
                    if (val != null) // Si la date n'est pas nulle
                    {
                        return Convert.ToDateTime(_metadata.DateTaken.ToString()); // On retourne la date
                    }
                    else
                    {
                        return null; // Sinon on retourne null
                    }
                }
            }

            public string Title  // Propriété Title
            {
                get
                {
                    Object val = _metadata.Title; // On récupère le titre de l'image
                    return (val != null ? (string)val : String.Empty); // On retourne le titre
                }
            }

            public string Model
            {
                get
                {
                    Object val = _metadata.CameraManufacturer + _metadata.CameraModel; // On récupère le modèle de l'appareil
                    return (val != null ? (string)val : String.Empty); // On retourne le modèle
                }
            }

            public string Application 
            {
                get
                {
                    Object val = _metadata.ApplicationName; // On récupère le nom de l'application
                    return (val != null ? (string)val : String.Empty); // On retourne le nom de l'application
                }
            }

            public string IsoSpeed
            {
                get
                {
                    Object val = QueryMetadata("/app1/ifd/exif/subifd:{uint=34855}"); // On récupère la sensibilité ISO
                    return (val != null ? val.ToString() + " ms" : String.Empty); // On retourne la sensibilité ISO
                }
            }

            public string Ouverture
            {
                get
                {
                    Object val = QueryMetadata("/app1/ifd/exif/subifd:{uint=33437}"); // On récupère l'ouverture
                    return (val != null ? "F/" + ParseUnsignedRational((ulong)val).ToString() : null); // On retourne l'ouverture
                }
            }

            public string Focal
            {
                get
                {
                    Object val = QueryMetadata("/app1/ifd/exif/subifd:{uint=37386}"); // On récupère la focale
                    return (val != null ? ParseUnsignedRational((ulong)val).ToString() + " mm" : String.Empty); // On retourne la focale
                }
            }

            private decimal ParseUnsignedRational(ulong exifValue)
            {
                return (decimal)(exifValue & 0xFFFFFFFFL) / (decimal)((exifValue & 0xFFFFFFFF00000000L) >> 32); // On retourne la valeur
            }
            private decimal ParseSignedRational(long exifValue)
            {
                return (decimal)(exifValue & 0xFFFFFFFFL) / (decimal)((exifValue & 0x7FFFFFFF00000000L) >> 32); // On retourne la valeur
            }
            private object QueryMetadata(string query)
            {
                if (_metadata.ContainsQuery(query)) // Si les métadonnées contiennent la requête
                    return _metadata.GetQuery(query); // On retourne la requête
                else
                    return null;
            }
        }
    }
}
