using System;


namespace Lab3
{
    public class ConsoleLogger : WriterLogger
    {
        public ConsoleLogger()
        {
            writer = Console.Out;
        }

        public override void Dispose()
        {
            
        }
    }
}
