namespace DSA.Algorithms.Arrays
{
    public class Kadane
    {
        // https://en.wikipedia.org/wiki/Maximum_subarray_problem
        public static int Run(int[] arr)
        {
            var length = arr.Length;

            var maxOnIndex = arr[0];
            var result = arr[0];

            for (int i = 1; i < length; i++)
            {
                maxOnIndex = Math.Max(arr[i], maxOnIndex + arr[i]);
                result = Math.Max(result, maxOnIndex);
            }

            return result;
        }
    }
}