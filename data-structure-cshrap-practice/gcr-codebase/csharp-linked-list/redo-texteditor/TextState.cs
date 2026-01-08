using System;
using System.Collections.Generic;
using System.Text;

namespace redo_texteditor
{

    /*
     * TextState represents a snapshot of text at a given time.
     * It forms a node of a Doubly Linked List.
     */
    class TextState
    {
        public string Content;
        public TextState Prev, Next;

        // Constructor to store text content
        public TextState(string text)
        {
            Content = text;
            Prev = null;
            Next = null;
        }
    }
}
