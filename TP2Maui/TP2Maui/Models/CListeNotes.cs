using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2Maui.Models
{

    internal class CListeNotes
    {
        public ObservableCollection<CNote> CollNotes { get; set; } = new ObservableCollection<CNote>();

        public CListeNotes() => ChargerNotes();


        private void ChargerNotes()
        {
            string fs = FileSystem.AppDataDirectory;

            IEnumerable<CNote> listenotes = Directory.EnumerateFiles(fs, "*.notes.txt")
                 .Select(filename => new CNote()
                 {
                     Filename = filename,
                     Text = File.ReadAllText(filename),
                     Date = File.GetCreationTime(filename)
                 })
                .OrderBy(note => note.Date);

            foreach (CNote note in listenotes)
            {
                CollNotes.Add(note);
            }

        }
    }
}
