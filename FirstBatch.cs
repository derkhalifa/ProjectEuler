using System;
namespace ProjectEuler
{
    public partial class Solution
    {
        // https://projecteuler.net/problem=1
        //[TestMethod]
        public void Sum_of_MultiplesOf_Three_And_Five()
        {
            long sum = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (i % 5 == 0 || i % 3 == 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine(sum);
        }

        // https://projecteuler.net/problem=2
        //[TestMethod]
        public void Sum_of_Even_Fib_nums()
        {
            long res = 0;

            int prev_prev = 1;
            int prev = 1;
            int curr = 0;
            while (prev <= 4000000)
            {
                curr = prev_prev + prev;
                prev_prev = prev;
                if (curr % 2 == 0) res += curr;
                prev = curr;
            }

            Console.WriteLine(res);
        }

        // https://projecteuler.net/problem=3
        [TestMethod]
        public void Largest_Prime_Factor()
        {
            ulong target = 600851475143;
            ulong res = 0;

            for (ulong i = (ulong)Math.Sqrt(target); i > 1; i--)
            {
                if (target % i == 0)
                {
                    bool isPrime = !(i % 2 == 0);
                    if (isPrime)
                    {
                        for (ulong j = 3; j < (ulong)Math.Sqrt(i); j += 2)
                        {
                            if (i % j == 0) 
                            {
                                isPrime = false; break;
                            }
                        }
                    }

                    if(isPrime) 
                    {
                        res = i;
                        break;
                    }

                }
            }

            Console.WriteLine(res);
        }
    }
}