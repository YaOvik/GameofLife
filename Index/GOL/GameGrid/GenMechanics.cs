using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOL.GameGrid
{
    public class GenLogics
    {
        // X_COLS, Y_ROWS
        public int Rows { get; set; }
        public int Cols { get; set; }

        public bool[,] CurrentGeneration;
        public bool[,] NextGeneration = new bool[10, 10];
        public List<Int32> NeighboringCells = new List<int>();


        public GenLogics()
        {
            Rows = 10;
            Cols = 10;
            CurrentGeneration = new bool[Cols, Rows];
        }
        /// <summary>
        /// Updates MyArra with living & non-living positions.
        /// </summary>
        /// <param name="yPos"></param>
        /// <param name="xPos"></param>
        /// <param name="living"></param>

        public void setPosition(int yPos , int xPos, bool living)
        {   
            if(living == false)
            {
                CurrentGeneration[yPos, xPos] = false;
            }
            else
            {
                CurrentGeneration[yPos, xPos] = true;
            }
        }

        
        /// <summary>
        /// 1. Find all living cells.
        /// 2. Find all non-living cells next to a living cell.
        /// 3. Compare the amount of living and non-living cells nexto each other.
        /// 4. Update living bool.
        /// 4. Push result yPos, xPos, living & color code to a que.
        /// 5. Repat untill process is canceld.
        /// </summary>
        /// <param name="yPos"></param>
        /// <param name="xPos"></param>
        /// <param name="myVal"></param>

        public bool[,] CheckCellNeighboring()
        {
            int nrOfNeighbours = 0;

            for (int xCols = 0; xCols < Cols; xCols++)
            {
                for (int yRows = 0; yRows < Rows; yRows++)
                {
                    // for each neighbour in CurrentGeneration[xCols, Rows]
                    // Count nr of neighbours

                    // Left, upper left, top, top right, right, right down, down, down left
                    nrOfNeighbours = CountNeighbours(xCols - 1, yRows + 0) +  //Left
                                     CountNeighbours(xCols - 1, yRows - 1) +  //LeftCornerUp
                                     CountNeighbours(xCols + 0, yRows - 1) +  //Up
                                     CountNeighbours(xCols + 1, yRows - 1) +  //RightCornerUp
                                     CountNeighbours(xCols + 1, yRows + 0) +  //Right
                                     CountNeighbours(xCols + 0, yRows + 1) +  //RightDownCorner
                                     CountNeighbours(xCols + 0, yRows + 1) +  //Down
                                     CountNeighbours(xCols - 1, yRows + 1);   //DownLeftCorner

                    if (nrOfNeighbours < 2 || nrOfNeighbours > 3)
                    {
                        NextGeneration[xCols, yRows] = false;
                    }
                        
                    if ((nrOfNeighbours == 2) || nrOfNeighbours == 3)
                    {
                        NextGeneration[xCols, yRows] = true;
                    }
                        
                }
            }

            // Copy over all cells in NextGeneration to CurrentGeneration
            for (int xCols = 0; xCols < Cols; xCols++)
            {
                for (int yRows = 0; yRows < Rows; yRows++)
                {
                    CurrentGeneration[xCols, yRows] = NextGeneration[xCols, yRows];
                }
            }

            return CurrentGeneration;
            // Update grid GUI with info from CurrentGeneration.
        }

        private int CountNeighbours(int xCol, int yRow)
        {
            if (xCol < 0 || xCol > Rows - 1 || yRow < 0 || yRow > Rows - 1)
                return 0;

            if (CurrentGeneration[xCol, yRow] == true)
                return 1;
            else
                return 0;
        }
    }
}
