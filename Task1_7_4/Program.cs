namespace Task1_7_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int maxNumber = FindMax(10, 25, 5, 30, 15);
            Console.WriteLine($"Max number: {maxNumber}");

            maxNumber = FindMax(10, 25, 5, 30, 15, 45, 27);
            Console.WriteLine($"Max number: {maxNumber}");

        }

        static int FindMax(params int[] nums) 
        {
            int max = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if(max < nums[i])
                    max = nums[i];
            }
            return max;
        }
    }
}