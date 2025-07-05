public static class LinearTimeExample {
    public static void Run() {
        int[] arr = { 10, 20, 30, 40 };
        foreach (var num in arr) {
            Console.WriteLine(num); // O(n)
        }
    }
}