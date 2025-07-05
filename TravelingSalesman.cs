public static class TravelingSalesmanExample {
    public static int TravelingSalesman(int[,] graph, bool[] visited, int pos, int count, int cost, int n, int start) {
        if (count == n && graph[pos, start] > 0)
            return cost + graph[pos, start];

        int min = int.MaxValue;
        for (int city = 0; city < n; city++) {
            if (!visited[city] && graph[pos, city] > 0) {
                visited[city] = true;
                int result = TravelingSalesman(graph, visited, city, count + 1, cost + graph[pos, city], n, start);
                min = Math.Min(min, result);
                visited[city] = false;
            }
        }
        return min;
    }
}