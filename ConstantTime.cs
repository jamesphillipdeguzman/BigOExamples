public static class ConstantTimeExample
{
    public static void Run()
    {
        int[] numbers = { 10, 20, 30, 40 };
        string[] names = { "James", "Angel", "Jarom", "Ethan", "Caleb" };
        Console.WriteLine("Constant Time Example");
        Console.WriteLine("Found name " + names[1]);
        Console.WriteLine("Found number " + numbers[2]); // O(1)
    }
}