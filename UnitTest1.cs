using NUnit.Framework;
using System;
using ��������_�������_������_������������;

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
        /// ������� ��� ��������� ������.
        /// </summary>
        [SetUp]
        public void Setup()
        {
        }
        /// <summary>
        /// ���� ��� ������� 3�3.
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
            Assert.AreEqual(45, result, "����������� ���������� ��� 3 ������� ������ ���� 45.");
        }
        /// <summary>
        /// ���� ������� 4�4.
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
            Assert.AreEqual(85, result, "����������� ���������� ��� 4 ������� ������ ���� 85.");
        }
        /// <summary>
        /// ���� ��� ������� 5�5.
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
            Assert.AreEqual(21, result, "����������� ���������� ��� 5 ������� ������ ���� 21.");
        }
    }
}
