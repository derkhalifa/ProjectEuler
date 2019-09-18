using System;
namespace ProjectEuler
{
    public partial class Solution
    {
        // https://projecteuler.net/problem=4
        [TestMethod]
        public void Largest_Palindrome_Product()
        {
            long res = 0;
            
            for (int j = 999; j > 99; j--)
                for (int k = 999; k > 99; k--)
                {
                    string candidate = j * k + "";
                    if(candidate.Length < 6 || j*k < res) continue;

                    bool isPalindrome = true;
                    for (int u = 0; u < candidate.Length / 2; u++)
                    {
                        if (candidate[u] != candidate[candidate.Length - 1 - u])
                        {
                            isPalindrome = false;
                            break;
                        }
                    }

                    if (isPalindrome)
                    {
                        res = Math.Max(res, j*k);
                    }
                }

            Console.WriteLine(res);

        }
    }
}