


public static class BubbleSort
{
    public static int[] SortArray(int[] data) // O(n^2) quadratic time
    {
        int n = data.Length;

        int[] sorted = (int[])data.Clone(); // avoid changing the original

        for (int i = 0; i < n; i++) // outer loop: runs n times
        {
            for (int j = 0; j < n - i - 1; j++) // inner loop: up to n times (shrinks per pass) 
            {
                if (sorted[j] > sorted[j + 1])
                {
                    (sorted[j], sorted[j + 1]) = (sorted[j + 1], sorted[j]);
                }
            }
        }

        return sorted;


    }

    public static void Run()
    {
        int[] data = { 1, 3, 5, 7, 2, 0, 4, 8, 10, 9 };
        int[] results = SortArray(data);

        Console.WriteLine("Bubble Sort example");
        Console.WriteLine("Sorted array: " + string.Join(", ", results));


    }
}