using System;
using System.Collections.Generic;

namespace Fibonacci
{
   public class FibonacciSeries
    {
        
            static void Main(string[] args)
        {
            int n;
            // int[] memo = new int[n + 1];
            Dictionary<int, long> dict = new Dictionary<int, long>();
            Console.WriteLine("ENTER NUMBER::");
            n = Convert.ToInt32(Console.ReadLine());
            for (int j = 0; j <= n; j++)
            {
                Console.WriteLine(Fib(j, dict));
            }
        }

       

        public static long Fib(int n, Dictionary<int, long> dict)
        {
            //int value;
           // Dictionary<int, long> dict = new Dictionary<int, long>();
            if (n <= 1)
                return n;
            if (dict.ContainsKey(n))
                return dict[n]; 
           
            var value = Fib(n - 1,dict) + Fib(n - 2,dict);
            dict[n] = value;
            return value;
        }

    }

    // public static long[] dp = new long[60];
    // public static long fib(int n)
    // {
    //     if (n <= 1)
    //         return n;

    //     // Temporary variables to store
    //     // values of fib(n-1) & fib(n-2)
    //     long first, second;

    //     if (dp[n - 1] != -1)
    //         first = dp[n - 1];
    //     else
    //         first = fib(n - 1);

    //     if (dp[n - 2] != -1)
    //         second = dp[n - 2];
    //     else
    //         second = fib(n - 2);

    //     // Memoization
    //     return dp[n] = first + second;
    // }

    //public static void Main()
    // {
    //     int n = 50;
    //     Array.Fill(dp, -1);
    //     Console.Write(fib(n));
    // }

    //static Dictionary<int, long> _memo =
    //  new() { { 0, 0 }, { 1, 1 } };

    //static Dictionary<int, long> _memo = new Dictionary<int, long>();

    //static void Main(string[] args)
    //{
    //    //for (int i = 0; i < 51; i++)
    //    //{
    //    //    Console.WriteLine($"Fib({i}) = {Fib(i)}");
    //    //}

    //    Console.WriteLine(Fib(50));
    //}

    //static long Fib(int n)
    //{
    //    if (_memo.ContainsKey(n))
    //        return _memo[n];

    //    var value = Fib(n - 1) + Fib(n - 2);

    //    _memo[n] = value;

    //    return value;
    //}
}

