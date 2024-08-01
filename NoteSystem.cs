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
            Console.WriteLine("\nNote added successfully!");


            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
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
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
        }
        public void EditNote()
        {
            Console.Write("Edit Note\n");
            Console.Write("Enter Current Note Title: ");
            var currentTitle = Console.ReadLine();

            var note = notes.Find(b => b.NoteTitle.Equals(currentTitle, StringComparison.OrdinalIgnoreCase));

            if (note != null)
            {
                Console.Write("Title: ");
                var newTitle = Console.ReadLine();
                Console.Write("Note: ");
                var newContent = Console.ReadLine();

                note.NoteTitle = newTitle;
                note.NoteContent = newContent;

                Console.WriteLine("Note edited successfully.");
            }
            else
            {
                Console.WriteLine("Note not found.");
            }

            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
        }
        public void DeleteNote()
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
                Console.Write("\nEnter note title to delete: ");
                string titleToDelete = Console.ReadLine();

                var noteRemove = notes.FirstOrDefault(b => b.NoteTitle.Equals(titleToDelete, StringComparison.OrdinalIgnoreCase));

                if (noteRemove != null)
                {
                    notes.Remove(noteRemove);
                    Console.WriteLine("\nNote deleted successfully!");
                }
                else
                {
                    Console.WriteLine("Note not found.");
                }
            }

            
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
        }
    }
}
