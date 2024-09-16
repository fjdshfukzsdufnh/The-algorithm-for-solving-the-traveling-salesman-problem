using System;
using Алгоритм_решения_задачи_коммивояжера;

class MainClass
{
    #region Values
    static int N;
    static int[,] dist;
    static int[,] dp;
    #endregion
    /// <summary>
    /// Главная функция программы
    /// </summary>
    static void Main()
    {
        Console.WriteLine("Введите количество городов: ");
        N = int.Parse(Console.ReadLine());
        dist = new int[N, N];
        Console.WriteLine("Введите матрицу расстояний между городами:");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                dist[i, j] = int.Parse(Console.ReadLine());
            }
        }
        dp = new int[1 << N, N];
        for (int i = 0; i < (1 << N); i++)
        {
            for (int j = 0; j < N; j++)
            {
                dp[i, j] = -1;
            }
        }

        // Вызов решения задачи коммивояжера
        int result = SolutionClass.TSP(1, 0, N, dp, dist);
        Console.WriteLine($"Минимальное расстояние: {result}");
    }
}
