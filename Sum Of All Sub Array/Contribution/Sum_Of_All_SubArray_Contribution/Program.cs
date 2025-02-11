

//Each element A[i] contributes to multiple subarrays.
//We calculate how many subarrays include A[i].
//The number of subarrays including A[i]:

//(i + 1)×(N−i)


//(i+1): The number of ways to start a subarray at or before i.
//(N - i): The number of ways to end a subarray at or after i.
//Thus, each A[i] contributes:

//A[i]×(i + 1)×(N−i)


namespace Sum_Of_All_SubArray_Contribution
{
    internal class Program
    {
        static void Main()
        {
            Program sol = new Program();
            int[] A = { 1, 2, 3 };  
            Console.WriteLine("Sum of all subarrays: " + sol.SumOfAllSubarrays(A));
        }

        public int SumOfAllSubarrays(int[] A)
        {
            int N = A.Length;
            int totalSum = 0;

            for (int i = 0; i < N; i++)
            {
                totalSum += A[i] * (i + 1) * (N - i);
            }

            return totalSum;
        }
    }
}
