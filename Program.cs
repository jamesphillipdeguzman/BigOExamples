class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Big O Examples Running...");

        ConstantTimeExample.Run();
        LinearTimeExample.Run();

        int[] arr = { 1, 2, 3, 4, 5, 8, 10, 12 };
        int num = 12;
        int index = BinarySearchExample.BinarySearch(arr, num);
        Console.WriteLine($"Binary search found {num} at index {index}");
    }
}
