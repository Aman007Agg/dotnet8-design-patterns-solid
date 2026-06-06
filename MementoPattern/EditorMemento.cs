using System;
using System.Collections.Generic;
using System.Text;

namespace MementoPattern
{
    internal class EditorMemento
    {
        public string Content { get; } /*Read-only property to store the content of the editor- Memento should be immutable.*/
        public EditorMemento(string content)
        {
            Content = content;
        }
    }
}
