public class KnapSackSolver
{
    public int GetMax(int[] weights, int[] profits, int capacity)
    {
        return GetMax(weights, profits, capacity, 0);
    }

    private int GetMax(int[] weights, int[] profits, int capacity, int currentIndex)
    {
        if (capacity <= 0 || currentIndex >= profits.Length)
        {
            return 0;
        }

        int profit1 = 0, profit2 = 0;
        if (weights[currentIndex] <= capacity)
        {
            profit1 = profits[currentIndex] + GetMax(weights, profits,
                capacity - weights[currentIndex], currentIndex + 1);
        }
        profit2 = GetMax(weights, profits, capacity, currentIndex + 1);
        return Math.Max(profit1, profit2);
    }


}