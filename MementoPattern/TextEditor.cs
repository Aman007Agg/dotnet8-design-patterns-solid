using System;
using System.Collections.Generic;
using System.Text;

namespace MementoPattern
{
    internal class TextEditor
    {
        public string Content { get; set; } /*Property to represent the content of the text editor.*/

        public EditorMemento Save()
        {
            return new EditorMemento(Content); /*Creates a new memento object with the current content of the text editor and returns it.*/
        }

        public void Restore(EditorMemento memento)
        {
            Content = memento.Content;
        }
    }
}

