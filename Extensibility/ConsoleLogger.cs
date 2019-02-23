using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Extensibility
{
    class ConsoleLogger : ILogger
    {
        public void LogError(string Message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Message);
        }

        public void LogInfo(string Message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Message);
        }
    }
}
