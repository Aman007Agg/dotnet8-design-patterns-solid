using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPattern
{
    internal class RemoteControl
    {
        private ICommand command;
        public RemoteControl(ICommand command)
        {
            this.command = command;
        }

        public void PressButton()
        {
            command.Execute();
        }
    }
}
