namespace DSA.Algorithms.Arrays
{
    public class Pivot
    {
        // https://leetcode.com/problems/find-the-pivot-integer/description/
        public static int Run(int input)
        {
            var length = input + 1;
            var arr = new int[length];
            var sum = 0;
            for (int i = 1; i < length; i++)
            {
                sum += i;
                arr[i] = sum;
            }

            sum = 0;
            for (int i = length - 1; i > 0; i--)
            {
                sum += i;
                if (arr[i] == sum)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}