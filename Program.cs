namespace ProjectEuler
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class Program
    {
        static void Main(string[] args)
        {
            // Run all tests  ..
            var instance = new Solution();

            foreach (MethodInfo mi in typeof(Solution).GetMethods())
            {
                var attr = mi.GetCustomAttribute(typeof(TestMethod));
                if (attr != null && ((TestMethod)attr).Ignored != true)
                {
                    using (new Logger.Scope(mi.Name))
                    {
                        mi.Invoke(instance, new object[] { });
                    }
                }
            }
        }
    }
}
