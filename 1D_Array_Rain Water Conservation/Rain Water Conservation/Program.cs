/**

Imagine a histogram where the bars' heights are given by the array A. Each bar is of uniform width, which is 1 unit. 
When it rains, water will accumulate in the valleys between the bars.
Your task is to calculate the total amount of water that can be trapped in these valleys.

**/

// Find the MAX from Left and MAX from Right

// Formula : Min(MaxLeft,MaxRight)-Array[i]


namespace Rain_Water_Conservation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
            Console.WriteLine("Water Trapped: " + TrapRainWater(A)); 
        }


        public static int TrapRainWater(int[] A)
        {
            if (A == null || A.Length < 3) return 0;

            int left = 0, right = A.Length - 1;
            int leftMax = 0, rightMax = 0;
            int waterTrapped = 0;

            while (left < right)
            {
                if (A[left] < A[right])
                {
                    if (A[left] >= leftMax)
                        leftMax = A[left];
                    else
                        waterTrapped += leftMax - A[left];

                    left++;
                }
                else
                {
                    if (A[right] >= rightMax)
                        rightMax = A[right];
                    else
                        waterTrapped += rightMax - A[right];

                    right--;
                }
            }

            return waterTrapped;
        }
    }
}


//Instead of maintaining extra arrays for left and right max heights, we use two pointers and a greedy strategy.
