namespace ProjectEuler
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Threading;

    public static class Logger
    {
        internal class Scope : IDisposable
        {
            private string scopeName;
            public Scope([CallerMemberName] string scopeName = "")
            {
                this.scopeName = scopeName;
                Logger.Log("Enter Scope : " + this.scopeName);
                Logger.IncrementScope();
            }
            void IDisposable.Dispose()
            {
                Logger.DecrementScope();
                Logger.Log("Exit Scope : " + this.scopeName + "\n");
            }
        }

        private static int scopeDepth = 0;
        public static void Log(string msg)
        {
            StringBuilder sb = new StringBuilder();
            for(int i=0;i < Logger.scopeDepth; i++){sb.Append("    ");}
            Console.WriteLine(@"Logger: " + sb.ToString() + msg);
        }

        public static void IncrementScope()
        {
            Logger.scopeDepth++;
        }

        public static void DecrementScope()
        {
            Logger.scopeDepth--;
        }
    }
}