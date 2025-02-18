int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

var cache = new Dictionary<Tuple<int, int>, int>();

int CountPaths(int x, int y)
{
    if (x >= n || y >= m)
    {
        return 0;
    }

    int result;
    if (cache.TryGetValue(Tuple.Create(x, y), out result))
    {
        return result;
    }

    if (x == n - 1 && y == m - 1)
    {
        return 1;
    }

    result = CountPaths(x + 1, y) + CountPaths(x, y + 1);
    cache[Tuple.Create(x, y)] = result;
    return result;
}

Console.Write(CountPaths(0, 0));