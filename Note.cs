using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteTakingApp
{
    public class Note
    {
        public string NoteTitle { get; set; }
        public string NoteContent { get; set; }

        public override string ToString()
        {
            return string.Format("Title: " + NoteTitle + "\nNote: " + NoteContent + "\n------------------------");
        }
    }
}
