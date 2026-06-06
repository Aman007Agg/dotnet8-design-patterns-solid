using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPattern
{
    /// <summary>
    /// The Command interface declares a method for executing a command.
    /// </summary>
    internal interface ICommand
    {
        void Execute();
    }
}
