using System;
using System.Collections.Generic;
using System.Text;

namespace MementoPattern
{
    /// <summary>
    ///  Caretaker - it manager and keeps track of the memento objects. 
    ///  It is responsible for saving and restoring the state of the text editor by interacting with the memento objects.
    ///  The caretaker does not modify or access the content of the memento directly;
    ///  it only stores and retrieves them as needed.
    /// </summary>
    internal class History
    {
        private Stack<EditorMemento> history = new Stack<EditorMemento>();

        public void Push(EditorMemento memento)
        {
            history.Push(memento);
        }

        public EditorMemento Pop()
        {
            if(history.Count <= 1)
            {
                return history.Peek();
            }
            
            history.Pop();
            return history.Peek();
        }
    }
}
