using System;
using System.Collections.Generic;

namespace NotesApp
{
    class Notes
    {
        public List<string> newNotes = new List<string>();
        Program p = new Program();

        public void App()
        {
            Console.WriteLine("NOTES APP");
            Console.WriteLine("-----------------");
            
            foreach(string note in newNotes)
            {
                Console.WriteLine(newNotes.IndexOf(note) + ": " + note);
            }


            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("1) Add a new note");
            Console.WriteLine("2) Remove a note");
            Console.Write("action: ");
            int action = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            
            if (action == 1)
            {
                AddNote();
            } else
            {
                RemoveNote();
            }
        }

        public void AddNote()
        {
            Console.Write("Note: ");
            string note = Console.ReadLine();
            newNotes.Add(note);
            Console.Clear();
            App();
        }

        public void RemoveNote()
        {
            Console.Write("Note index: ");
            int seletedIndex = Convert.ToInt32(Console.ReadLine());

            newNotes.RemoveAt(seletedIndex); 
            App();
        }
        
    }
}