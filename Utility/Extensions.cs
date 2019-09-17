namespace ProjectEuler
{
    using System;
    using System.Linq;
    using System.Collections;
    public static class Extensions
    {

        public static void ShouldBe(this int[,] a, int[,] b)
        {
            a.GetLength(0).ShouldBe(b.GetLength(0));
            a.GetLength(1).ShouldBe(b.GetLength(1));
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j].ShouldBe(b[i, j]);
                }
            }
        }
        public static void ShouldBe(this char[,] a, char[,] b)
        {
            a.GetLength(0).ShouldBe(b.GetLength(0));
            a.GetLength(1).ShouldBe(b.GetLength(1));
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j].ShouldBe(b[i, j]);
                }
            }
        }

        public static void ShouldBe(this int[] a, int[] b)
        {
            a.Length.ShouldBe(b.Length);
            for (int i = 0; i < a.Length; i++)
            {
                a[i].ShouldBe(b[i]);
            }
        }

        public static void ShouldBe(this double[] a, double[] b)
        {
            a.Length.ShouldBe(b.Length);
            for (int i = 0; i < a.Length; i++)
            {
                a[i].ShouldBe(b[i]);
            }
        }

        public static void ShouldBe(this object[] a, object[] b)
        {
            a.Length.ShouldBe(b.Length);
            for (int i = 0; i < a.Length; i++)
            {
                a[i].ShouldBe(b[i]);
            }
        }

        public static void ShouldThrow(Action x)
        {
            try
            {
                x();
            }
            catch
            {
                Logger.Log("SUCCESS : Method threw as Expected ..");
                return;
            }

            throw new Exception("didn't throw as expected");
        }

        public static void ShouldBe(this object x, object y)
        {
            // guard against null equality .. 
            if (x == null && y == null)
                return;

            if (x == null || y == null || !x.Equals(y))
            {
                Logger.Log("Failed : expected " + y + ", found : " + x);
                throw new System.Exception("Value equal assertion failed. Expected :" + y + " but found :" + x);
            }

            // exit silently ..
        }
    }
}