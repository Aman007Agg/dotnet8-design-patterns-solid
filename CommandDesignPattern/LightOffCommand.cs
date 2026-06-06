using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPattern
{
    /// <summary>
    /// The LightOffCommand class implements the ICommand interface and represents a command to turn off the light.
    /// </summary>
    internal class LightOffCommand: ICommand
    {
        private readonly Light light;
        public LightOffCommand(Light light)
        {
            this.light = light;
        }
        public void Execute()
        {
            light.TurnOff();
        }
    }
}
