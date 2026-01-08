using System;
using System.Collections.Generic;
using System.Text;

namespace redo_texteditor
{
    internal class Utility
    {
        public static void Main()
        {
            TextEditor editor = new TextEditor();
            int choice;

            do
            {
                Console.WriteLine("\n--- Text Editor ---");
                Console.WriteLine("1. Add Text");
                Console.WriteLine("2. Undo");
                Console.WriteLine("3. Redo");
                Console.WriteLine("4. Show Current Text");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter text: ");
                        string text = Console.ReadLine();
                        editor.AddState(text);
                        Console.WriteLine("Text added");
                        break;

                    case 2:
                        editor.Undo();
                        editor.ShowContent();
                        break;

                    case 3:
                        editor.Redo();
                        editor.ShowContent();
                        break;

                    case 4:
                        editor.ShowContent();
                        break;

                    case 5:
                        Console.WriteLine("Exiting Text Editor...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

            } while (choice != 5);
        }
    }
}
