using NUnit.Framework;

namespace com.fabioscagliola.CrackingTheCodingInterview.Chapter01
{
    /// <summary>
    /// 
    /// ### 1.7 Rotate Matrix 
    /// 
    /// Given an image represented by an N x N matrix, where each pixel in the image is represented by an integer, write a method to rotate the image by 90 degrees. Can you do this in place? 
    /// 
    /// </summary>
    class Question07
    {
        static void RotateMatrix(int[,] matrix)
        {
            int size = matrix.GetLength(0);

            for (int x = 0; x < size / 2; x++)
            {
                for (int y = x; y < size - x - 1; y++)
                {
                    int temp = matrix[x, y];

                    matrix[x, y] = matrix[y, size - 1 - x];

                    matrix[y, size - 1 - x] = matrix[size - 1 - x, size - 1 - y];

                    matrix[size - 1 - x, size - 1 - y] = matrix[size - 1 - y, x];

                    matrix[size - 1 - y, x] = temp;
                }
            }
        }

        [TestFixture]
        class Question07Test
        {
            [Test]
            public void Question07_RotateMatrix()
            {
                int[,] matrix = new int[4, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };
                Question07.RotateMatrix(matrix);
                CollectionAssert.AreEqual(new int[4, 4] { { 4, 8, 12, 16 }, { 3, 7, 11, 15 }, { 2, 6, 10, 14 }, { 1, 5, 9, 13 } }, matrix);
            }

        }

    }
}

