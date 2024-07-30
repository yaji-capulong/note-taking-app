using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteTakingApp
{
    public interface INoteLibrary
    {
        void AddNewNote();
        void ViewNotes();
        void DeleteNote();
    }
}
