using System;

namespace magic_square_grid_problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] input = new int[][]{
                new int[]{3,10,2,3,4},
                new int[]{4,5,6,8,1},
                new int[]{8,8,1,6,8},
                new int[]{1,3,5,7,1},
                new int[]{9,4,9,2,9},
            };

            int res = NumMagicSquaresInside(input);
        }

        public static int NumMagicSquaresInside(int[][] grid)
        {
            int result = 0;
            for (int i = 0; i < grid.Length - 2; i++)
            {
                for (int j = 0; j < grid[i].Length - 2; j++)
                {

                    if (isMagicGrid(grid[i][j], grid[i + 1][j], grid[i + 2][j],
                                    grid[i][j + 1], grid[i + 1][j + 1], grid[i + 2][j + 1],
                                    grid[i][j + 2], grid[i + 1][j + 2], grid[i + 2][j + 2]))
                    result++;
                }
            }
            return result;
        }

        private static bool isMagicGrid(params int[] values)
        {
            int[] count = new int[16];
            foreach (var value in values)
            {
                count[value] = 1;
            }
            for (int i = 1; i <= values.Length; i++)
            {
                if (count[i] != 1)
                    return false;
            }
            return (values[0] + values[1] + values[2] == 15 &&
                    values[3] + values[4] + values[5] == 15 &&
                    values[6] + values[7] + values[8] == 15 &&
                    values[0] + values[3] + values[6] == 15 &&
                    values[1] + values[4] + values[7] == 15 &&
                    values[2] + values[5] + values[8] == 15 &&
                    values[0] + values[4] + values[8] == 15 &&
                    values[2] + values[4] + values[6] == 15);
        }
    }
}
