using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPattern
{
    /// <summary>
    /// Class LightOnCommand implements the ICommand interface and represents a command to turn on the light.
    /// </summary>
    internal class LightOnCommand: ICommand
    {
        private readonly Light light;
        public LightOnCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.TurnOn();
        }
    }
}
