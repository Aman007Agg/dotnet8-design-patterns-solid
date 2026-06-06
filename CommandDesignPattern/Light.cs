using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPattern
{
    internal class Light
    {
        /// <summary>
        /// The Light class represents a light that can be turned on and off. 
        /// It has two methods: LightOn() and LightOff(), which print messages to the console indicating the state of the light.
        /// Receives commands from the RemoteControl class to change its state.
        /// </summary>
        public void TurnOn()
        {
            Console.WriteLine("The light Turned ON.");
        }

        public void TurnOff() 
        { 
            Console.WriteLine("The light Turned OFF."); 
        }
    }
}
