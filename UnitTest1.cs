using NUnit.Framework;
using System;
using Алгоритм_решения_задачи_коммивояжера;

namespace TestProject
{
    public class Tests
    {
        #region Values
        private int[,] dist;
        private int N;
        private int[,] dp;
        #endregion
        /// <summary>
        /// Функция для настройки тестов.
        /// </summary>
        [SetUp]
        public void Setup()
        {
        }
        /// <summary>
        /// Тест для матрицы 3х3.
        /// </summary>
        [Test]
        public void Test_SmallMatrix()
        {
            N = 3;
            dist = new int[,]
            {
                { 0, 10, 15 },
                { 10, 0, 35 },
                { 15, 35, 0 }
            };
            dp = new int[1 << N, N];
            for (int i = 0; i < (1 << N); i++)
            {
                for (int j = 0; j < N; j++)
                {
                    dp[i, j] = -1;
                }
            }
            int result = SolutionClass.TSP(1, 0, N, dp, dist);
            Assert.AreEqual(45, result, "Минимальное расстояние для 3 городов должно быть 45.");
        }
        /// <summary>
        /// Тест матрицы 4х4.
        /// </summary>
        [Test]
        public void Test_MediumMatrix()
        {
            N = 4;
            dist = new int[,]
            {
                { 0, 20, 42, 25 },
                { 20, 0, 30, 34 },
                { 42, 30, 0, 10 },
                { 25, 34, 10, 0 }
            };
            dp = new int[1 << N, N];
            for (int i = 0; i < (1 << N); i++)
            {
                for (int j = 0; j < N; j++)
                {
                    dp[i, j] = -1;
                }
            }
            int result = SolutionClass.TSP(1, 0, N, dp, dist);
            Assert.AreEqual(85, result, "Минимальное расстояние для 4 городов должно быть 85.");
        }
        /// <summary>
        /// Тест для матрицы 5х5.
        /// </summary>
        [Test]
        public void Test_LargeMatrix()
        {
            N = 5;
            dist = new int[,]
            {
                { 0, 2, 9, 10, 7 },
                { 1, 0, 6, 4, 3 },
                { 15, 7, 0, 8, 4 },
                { 6, 3, 12, 0, 5 },
                { 10, 4, 8, 6, 0 }
            };
            dp = new int[1 << N, N];
            for (int i = 0; i < (1 << N); i++)
            {
                for (int j = 0; j < N; j++)
                {
                    dp[i, j] = -1;
                }
            }
            int result = SolutionClass.TSP(1, 0, N, dp, dist);
            Assert.AreEqual(21, result, "Минимальное расстояние для 5 городов должно быть 21.");
        }
    }
}
