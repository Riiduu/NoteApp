using System;

namespace NotesApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Notes notes = new Notes();
            notes.newNotes.Add("a new note");
            notes.newNotes.Add("another note");

            notes.App();            


        }
    }
}