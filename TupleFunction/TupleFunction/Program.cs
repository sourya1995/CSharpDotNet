using System;

namespace TuplesWork;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[] { 54, 21, 21, 65, 76, 9, 3, 99 };

        var minAndMax = GetMinAndMax(numbers);

        Console.WriteLine(minAndMax.Item1); // Prints min value
        Console.WriteLine(minAndMax.Item2);
    }

    static (int, int) GetMinAndMax(int[] nums)
    {
        int min = nums[0];
        int max = nums[0];

        for(int i=0; i < nums.Length; i++)
        {
            if (nums[i] < min)
            {
                min = nums[i];
            }

            if(nums[i] > max)
            {
                max = nums[i];
            }
        }

        return (min, max);
    }
}