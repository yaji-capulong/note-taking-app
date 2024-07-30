using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteTakingApp
{
    internal class NoteSystem : INoteLibrary
    {
        private List<Note> notes = new List<Note>();

        public void AddNewNote()
        {
            Console.Write("New Note\n");
            Console.Write("Title: ");
            string title = Console.ReadLine();
            Console.Write("Note: ");
            string content = Console.ReadLine();

            Note newNote = new Note { NoteTitle = title, NoteContent = content };
            notes.Add(newNote);
            Console.WriteLine("Note added successfully!");
        }

        public void ViewNotes()
        {
            if (notes.Count == 0)
            {
                Console.WriteLine("No notes available.");
            }
            else
            {
                Console.WriteLine("NOTES\n");
                foreach (var note in notes)
                {
                    Console.WriteLine(note);
                }
            }
            Console.ReadKey();
        }

        public void DeleteNote()
        {
            Console.Write("Enter note title to delete: ");
            string titleToDelete = Console.ReadLine();

            var noteRemove = notes.FirstOrDefault(b => b.NoteTitle.Equals(titleToDelete, StringComparison.OrdinalIgnoreCase));
            if (noteRemove != null)
            {
                notes.Remove(noteRemove);
                Console.WriteLine("Note deleted successfully!");
            }
            else
            {
                Console.WriteLine("Note not found.");
            }
        }
    }
}
