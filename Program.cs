using NoteTakingApp;

class Program
{
    static void Main()
    {
        INoteLibrary noteLib = new NoteSystem();
        string choice = string.Empty;
        bool run = true;

        while (run) {
            Console.Clear();

            Console.WriteLine("Welcome to Notes. Choose an option:");

            Console.WriteLine("A. Add new note" +
                                "\nB. View notes" +
                                "\nC. Edit note" + 
                                "\nD. Delete note" +
                                "\nE. Exit" +
                                "\nAnswer: ");

            choice = Console.ReadLine().ToLower();

            if (choice == "a")
            {
                Console.Clear();
                noteLib.AddNewNote();
            }
            else if (choice == "b")
            {
                Console.Clear();
                noteLib.ViewNotes();

            }
            else if (choice == "c")
            {
                Console.Clear();
                noteLib.EditNote();
            }
            else if (choice == "d")
            {
                Console.Clear();
                noteLib.DeleteNote();
            }
            else if (choice == "e")
            {
                run = false;
                Console.Clear();
                Console.WriteLine("Exiting...");
            }
        }
    }

}