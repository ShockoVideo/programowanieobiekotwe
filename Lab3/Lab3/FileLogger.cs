using System;
using System.Text;
using System.IO;

namespace Lab3
{
    public class FileLogger : WriterLogger
    {
        private bool disposed;
        protected FileStream stream;

        public FileLogger(string path)
        {
            this.stream = new FileStream(path, FileMode.Append);
            writer = new StreamWriter(stream, Encoding.UTF8);

        }

        ~FileLogger()
        {
            this.Dispose(false);
        }

        protected virtual void Dispose(bool disposing)
        {
            if(!this.disposed)
            {
                if (disposing)
                    this.stream.Dispose();

                this.disposed = true;
            }
        }

        public override void Dispose()
        {
            this.Dispose(disposing: true);

            GC.SuppressFinalize(this);
        }
    }
}
