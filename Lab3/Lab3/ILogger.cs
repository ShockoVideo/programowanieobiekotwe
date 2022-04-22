using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    public interface ILogger : IDisposable
    {
        public void Log(params string[] messages);
    }
}
