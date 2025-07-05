public static class ConstantTimeExample {
    public static void Run() {
        int[] arr = { 10, 20, 30, 40 };
        Console.WriteLine(arr[2]); // O(1)
    }
}