using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Lab3
{
    public class CommonLogger : WriterLogger
    {

        private ILogger[] loggers;

        public CommonLogger(ILogger[] loggers)
        {
            this.loggers = loggers;
        }

        public override void Dispose()
        {

        }

        public void Log(params string[] messages)
        {
            foreach (var logger in loggers)
            {
                logger.Log(messages);
            }
        }

    }


}
