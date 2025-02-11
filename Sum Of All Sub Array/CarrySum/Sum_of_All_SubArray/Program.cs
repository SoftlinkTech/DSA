namespace Sum_of_All_SubArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 3 };
            Console.WriteLine("Sum : "+SumOfSubarrays(ints));
        }
        public static int SumOfSubarrays(int[] array)
        {
            int sum = 0;


            for (int i = 0; i < array.Length; i++)
            {
                int CarrySum = 0;

                for (int j = i; j < array.Length; j++)
                {
                    CarrySum += array[j];
                    sum += CarrySum;
                }
            }

            return sum;
        }
    }

    
}


//Carry Forward	O(N²)	O(1)	Single calculation

//Outer loop(i) starts from each index.
//Inner loop (j) extends the subarray while maintaining a running sum (CarrySum).
//This avoids recalculating sums from scratch, making it efficient for an O(N²) solution.
