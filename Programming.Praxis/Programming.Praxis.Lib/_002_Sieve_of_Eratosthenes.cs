using System;
using System.Collections.Generic;

namespace Programming.Praxis.Lib
{
	public class _002_Sieve_of_Eratosthenes
	{
		public static List<int> GetPrimes(int n)
		{
			if (n < 0)
			{
				throw new ArgumentException("Invalid value of n : " + n, "n");
			}

			List<int> result = new List<int>();

			// Create two arrays of (n + 1) members
			// but we only consider the members in [2, n]
			int[] allNumbers = new int[n + 1];
			bool[] allMarks = new bool[n + 1];

			for (int i = 2; i <= n; i++)
			{
				allNumbers[i] = i;
			 	allMarks[i] = true;
			}

			// OPTIMIZE : sieve to sqrt(n)
			double sqrtOfN = Math.Sqrt(n);

			for (int i = 2; i <= sqrtOfN; i++)
			{
				if (allMarks[i])
				{
					// i is a prime number

					// eliminate all multiplies by i
					// OPTIMIZED : start with i * i
					for (int j = i * i; j <= n; j += i)
					{
						allMarks[j] = false;
					}
				}
			}

			for (int i = 2; i <= n; i++)
			{
				if (allMarks[i])
				{
					result.Add(i);
				}
			}

			return result;
		}
	}
}
