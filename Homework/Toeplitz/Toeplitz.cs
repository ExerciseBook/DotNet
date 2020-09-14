using System;

namespace Toeplitz
{
    public class Toeplitz
    {
        private readonly int col;
        private readonly int[,] p;
        private readonly int row;

        public Toeplitz(int[,] p, int row, int col)
        {
            this.p = p;
            this.row = row;
            this.col = col;

            for (var x = row - 1; x >= 0; x--) check(x, 0);

            for (var y = 1; y < col; y++) check(0, y);
        }

        private void check(int x, int y)
        {
            var p = this.p[x, y];

            x++;
            y++;

            while (x < row && y < col)
            {
                if (this.p[x, y] != p) throw new Exception();
                x++;
                y++;
            }
        }
    }
}