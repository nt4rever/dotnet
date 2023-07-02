using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFundamental
{
    public class WriteData : IDisposable
    {
        private bool m_Disposed = false;
        private StreamWriter stream;

        public WriteData(string fileName) {
            stream = new StreamWriter(fileName, true);
        }  
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing) {
            if (!m_Disposed)
            {
                if (disposing)
                {
                    stream.Dispose();
                }
                m_Disposed = true;
            }
        }

        ~WriteData()
        {
            Dispose(false);
        }
    }
}
