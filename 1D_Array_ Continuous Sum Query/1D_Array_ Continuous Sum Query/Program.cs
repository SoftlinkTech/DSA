/**
There are A beggars sitting in a row outside a temple. Each beggar initially has an empty pot. When the devotees come to the temple, 
    they donate some amount of coins to these beggars. Each devotee gives a fixed amount of coin(according to their faith and ability) to some K beggars sitting next to each other.

Given the amount P donated by each devotee to the beggars ranging from L to R index, where 1 <= L <= R <= A, find out 
the final amount of money in each beggar's pot at the end of the day, provided they don't fill their pots by any other means.
For ith devotee B[i][0] = L, B[i][1] = R, B[i][2] = P, given by the 2D array B

 **/

// Here Approch will be prefix sum

namespace _1D_Array__Continuous_Sum_Query
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = 5; // Number of beggars
            List<List<int>> B = new List<List<int>>
            {
                new List<int>{1, 2, 10},  // Donate 10 coins to beggar 1 to 2
                new List<int>{2, 3, 20},  // Donate 20 coins to beggar 2 to 3
                new List<int>{3, 5, 30}   // Donate 30 coins to beggar 3 to 5
            };

            List<int> result = solve(A, B);
        }

        public static List<int> solve(int A, List<List<int>> B)
        {
            int[] arr = new int[A + 1];

            foreach (var donation in B)
            {
                int L = donation[0] - 1; // Convert 1-based index to 0-based
                int R = donation[1] - 1;
                int P = donation[2];

                arr[L] += P;  // Start the donation at L
                if (R + 1 < A)
                    arr[R + 1] -= P; // Remove the donation effect after R
            }
            List<int> result = new List<int>(new int[A]);
            result[0] = arr[0];

            for (int i = 1; i < A; i++)
            {
                result[i] = result[i - 1] + arr[i];
            }

            return result;
        }
    }
}
