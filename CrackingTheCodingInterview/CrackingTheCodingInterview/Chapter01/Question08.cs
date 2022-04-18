using NUnit.Framework;
using System.Collections.Generic;

namespace com.fabioscagliola.CrackingTheCodingInterview.Chapter01
{
    /// <summary>
    /// 
    /// ### 1.8 Zero Matrix 
    /// 
    /// Write an algorithm such that if an element in an M x N matrix is 0, its entire row and column are set to 0. 
    /// 
    /// </summary>
    class Question08
    {
        class Zero
        {
            public int X { get; protected set; }
            public int Y { get; protected set; }

            public Zero(int x, int y)
            {
                X = x;
                Y = y;
            }
        }

        static void ZeroMatrix(int[,] matrix)
        {
            int M = matrix.GetLength(0);
            int N = matrix.GetLength(1);

            List<Zero> zeroes = new();

            for (int x = 0; x < M; x++)
            {
                for (int y = 0; y < N; y++)
                {
                    if (matrix[x, y] == 0)
                    {
                        zeroes.Add(new Zero(x, y));
                    }
                }
            }

            foreach (Zero zero in zeroes)
            {
                for (int x = 0; x < M; x++)
                {
                    matrix[x, zero.Y] = 0;
                }

                for (int y = 0; y < N; y++)
                {
                    matrix[zero.X, y] = 0;
                }
            }
        }

        [TestFixture]
        class Question09Test
        {
            [Test]
            public void Question09_ZeroMatrix()
            {
                int[,] matrix = new int[4, 5] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 0, 14, 15 }, { 16, 17, 18, 19, 20 } };
                Question08.ZeroMatrix(matrix);
                CollectionAssert.AreEqual(new int[4, 5] { { 1, 2, 0, 4, 5 }, { 6, 7, 0, 9, 10 }, { 0, 0, 0, 0, 0 }, { 16, 17, 0, 19, 20 } }, matrix);
            }

        }

    }
}

