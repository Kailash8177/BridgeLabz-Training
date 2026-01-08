using System;
using System.Collections.Generic;
using System.Text;

namespace redo_texteditor
{

    /*
     * TextEditor manages text changes using a Doubly Linked List.
     * - Prev  → Undo
     * - Next  → Redo
     */
    class TextEditor
    {
        private TextState current; // Points to current text state

        // Add a new text state
        public void AddState(string text)
        {
            TextState state = new TextState(text);

            // If there is an existing state
            if (current != null)
            {
                // Break redo chain (important interview point)
                current.Next = state;
                state.Prev = current;
            }

            // Move current pointer to new state
            current = state;
        }

        // Undo operation (move backward)
        public void Undo()
        {
            if (current != null && current.Prev != null)
            {
                current = current.Prev;
            }
            else
            {
                Console.WriteLine("Nothing to undo");
            }
        }

        // Redo operation (move forward)
        public void Redo()
        {
            if (current != null && current.Next != null)
            {
                current = current.Next;
            }
            else
            {
                Console.WriteLine("Nothing to redo");
            }
        }

        // Display current text
        public void ShowContent()
        {
            if (current == null)
            {
                Console.WriteLine("Editor is empty");
            }
            else
            {
                Console.WriteLine($"Current Text: {current.Content}");
            }
        }
    }

}
