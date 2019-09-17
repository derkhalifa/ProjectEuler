namespace ProjectEuler
{
    using System;
    [AttributeUsage(AttributeTargets.Method)]
    public class TestMethod : Attribute
    {
        public bool Ignored {get;}
        public TestMethod(bool ignored = false)
        {
            Ignored = ignored;
        }
    }
}