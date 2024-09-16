using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Алгоритм_решения_задачи_коммивояжера
{
    public static class SolutionClass
    {
        /// <summary>
        /// Функция для поиска минимального расстояния, где <paramref name="N"/> - количество строк и столбцов, <paramref name="dist"/> - расстояния между вершинами.
        /// </summary>
        /// <param name="mask"></param>
        /// <param name="pos"></param>
        /// <param name="N"></param>
        /// <param name="dp"></param>
        /// <param name="dist"></param>
        /// <returns></returns>
        public static int TSP(int mask, int pos, int N, int[,] dp, int[,] dist)
        {
            const int INF = int.MaxValue;
            if (mask == (1 << N) - 1)
            {
                return dist[pos, 0];
            }
            if (dp[mask, pos] != -1)
            {
                return dp[mask, pos];
            }
            int ans = INF;
            for (int city = 0; city < N; city++)
            {
                if ((mask & (1 << city)) == 0)
                {
                    int newAns = dist[pos, city] + TSP(mask | (1 << city), city, N, dp, dist);
                    ans = Math.Min(ans, newAns);
                }
            }
            return dp[mask, pos] = ans;
        }
    }
}
