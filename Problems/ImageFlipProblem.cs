using System;
using System.Collections.Generic;
using System.Text;

namespace Problems
{
    public class ImageFlipProblem
    {
        public int[][] FlipAndInvertImage(int[][] A)
        {
            for (int r = 0; r < A.Length; r++)
            {
                for (int c = 0; c < (A[r].Length + 1) / 2; c++)
                {
                    int temp = 1 - A[r][c];
                    A[r][c] = 1 - A[r][A[r].Length - c - 1];
                    A[r][A[r].Length - c - 1] = temp;
                }
            }
            return A;
        }
    }
}
