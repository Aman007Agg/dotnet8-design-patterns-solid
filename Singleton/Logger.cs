using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    internal sealed class Logger
    {
        private static readonly Lazy<Logger> lazyInstance = new Lazy<Logger>(() => new Logger());

        private Logger()
        {

        }

        public static Logger Instance
        {
            get
            {
                return lazyInstance.Value;
            }
        }

        public void Log(string message)
        {
            Console.WriteLine($"[{DateTime.Now}] {message}");
        }
    }
}
