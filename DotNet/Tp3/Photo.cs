﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Tp3
{
    internal class Photo
    {
        private string _path;
        private Uri _source;
        private PhotoMetadata _phmetadata;

        public Photo(string path)
        {
            _path = path;
            _source = null;

            if (path != "") 
            {
                _source = new Uri(path);
                _phmetadata = new PhotoMetadata(_source);
            }
        }

        public override string ToString()
        {
            return _source.ToString();
        }

        public string Source { get { return _path; } }

        public PhotoMetadata Metadata { get { return _phmetadata; } }

        internal class PhotoMetadata
        {
            BitmapMetadata _metadata;

            public PhotoMetadata(Uri imageUri)
            {
                BitmapFrame frame = BitmapFrame.Create(imageUri, BitmapCreateOptions.DelayCreation, BitmapCacheOption.None);
                _metadata = (BitmapMetadata)frame.Metadata;
            }

            public DateTime? DateTaken
            {
                get
                {
                    Object val = _metadata.DateTaken;
                    if (val != null)
                    {
                        return Convert.ToDateTime(_metadata.DateTaken.ToString());
                    }
                    else
                    {
                        return null;
                    }
                }
            }

            public string Title 
            {
                get
                {
                    Object val = _metadata.Title;
                    return (val != null ? (string)val : String.Empty);
                }
            }

            public string Model
            {
                get
                {
                    Object val = _metadata.CameraManufacturer + _metadata.CameraModel;
                    return (val != null ? (string)val : String.Empty);
                }
            }

            public string Application
            {
                get
                {
                    Object val = _metadata.ApplicationName;
                    return (val != null ? (string)val : String.Empty);
                }
            }

            public string IsoSpeed
            {
                get
                {
                    Object val = QueryMetadata("/app1/ifd/exif/subifd:{uint=34855}");
                    return (val != null ? val.ToString() + " ms" : String.Empty);
                }
            }

            public string Ouverture
            {
                get
                {
                    Object val = QueryMetadata("/app1/ifd/exif/subifd:{uint=33437}");
                    return (val != null ? "F/" + ParseUnsignedRational((ulong)val).ToString() : null);
                }
            }

            public string Focal
            {
                get
                {
                    Object val = QueryMetadata("/app1/ifd/exif/subifd:{uint=37386}");
                    return (val != null ? ParseUnsignedRational((ulong)val).ToString() + " mm" : String.Empty);
                }
            }

            private decimal ParseUnsignedRational(ulong exifValue)
            {
                return (decimal)(exifValue & 0xFFFFFFFFL) / (decimal)((exifValue & 0xFFFFFFFF00000000L) >> 32);
            }
            private decimal ParseSignedRational(long exifValue)
            {
                return (decimal)(exifValue & 0xFFFFFFFFL) / (decimal)((exifValue & 0x7FFFFFFF00000000L) >> 32);
            }
            private object QueryMetadata(string query)
            {
                if (_metadata.ContainsQuery(query))
                    return _metadata.GetQuery(query);
                else
                    return null;
            }
        }
    }
}
