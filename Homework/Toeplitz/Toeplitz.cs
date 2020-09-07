using System;

namespace Toeplitz
{
    public class Toeplitz
    {
        private int[,] p;
        private int row;
        private int col;

        public Toeplitz(int[,] p, int row, int col)
        {
            this.p = p;
            this.row = row;
            this.col = col;

            for (int x = row - 1; x >= 0; x--)
            {
                check(x, 0);
            }

            for (int y = 1; y < col; y++)
            {
                check(0, y);
            }
        }

        void check(int x, int y)
        {
            int p = this.p[x, y];

            x++;
            y++;

            while (x < this.row && y < this.col)
            {
                if (this.p[x, y] != p) throw new Exception();
                x++;
                y++;
            }
        }
    };

}