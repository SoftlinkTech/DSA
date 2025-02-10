//Find the maximum sum of contiguous non-empty subarray within an array A of length N.

// Here we use Kadane’s Algorithm

namespace _1D_Array_Max_Sum_Contiguous_Subarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 5, 8, -3, 8, -3, -12, -8, 9, 7, 10 };
            Program program = new Program();
            Console.WriteLine("Sum = " + program.maxSubArray(list));
        }

        public int maxSubArray(List<int> A)
        {
            int length = A.Count();
            int Ans = A[0];
            int CurrentSum = A[0];
            for (int i = 1; i < length; i++)
            {
                CurrentSum = Math.Max(A[i], CurrentSum + A[i]);
                Ans = Math.Max(Ans, CurrentSum);
            }
            return Ans;
        }
    }
}

//Explanation:

//Initialize maxSum and currentSum with the first element of the array.
//Iterate through the array:
//Either start a new subarray at A[i] or extend the existing subarray.
//Update maxSum whenever a larger sum is found.
//Return the maximum found sum.

//Time Complexity:

//O(N) (Single pass through the array)
//O(1) Space (Only a few variables are used)
