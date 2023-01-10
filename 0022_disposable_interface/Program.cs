using System.Diagnostics;

namespace __0022_disposable_interface
{
    public class OperationTimer : IDisposable
    {
        private Stopwatch _sw = new();
        private bool _disposed = false;

        public OperationTimer()
        {
            _sw.Start();
        }

        ~OperationTimer()
        {
            Dispose(disposing: false);
        }    
        
        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);            
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    // Cleanup managed resources
                    _sw.Stop();

                    var elapsed = _sw.ElapsedMilliseconds;
                    if (elapsed > 10)
                        Console.WriteLine($"Warning: {elapsed}ms");
                }

                // Cleanup unmanaged resources

                _disposed = true;
            }
        }
    }

    class StartupClass
    {
        static void Main(string[] args)
        {
            using(var timer = new OperationTimer())
            {
                for(int i=0, t=0; i<10_000_000; i++, t++);
            }
        }
   }
}
