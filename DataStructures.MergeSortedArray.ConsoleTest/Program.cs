namespace DataStructures.MergeSortedArray.ConsoleTest
{
    public static class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 3, 5, 7, 9};
            int n1 = arr1.Length;

            int[] arr2 = { 2, 4, 6, 8, 10 };
            int n2 = arr2.Length;

            int[] arr3 = new int[n1 + n2];

            Implementations.MergeSortedArrays.MergeArrays(arr1, arr2, n1, n2, arr3);

            Console.Write("Array after merging\n");
            for (int i = 0; i < n1 + n2; i++)
                Console.Write(arr3[i] + " ");
        }
    }
}