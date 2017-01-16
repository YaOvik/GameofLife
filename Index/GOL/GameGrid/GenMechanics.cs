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
        int AmountOfNeighboring;

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
            int yPosNewLiveCell, xPosNewLiveCell, yPosCompare, xPosCompare;
            int nrOfNeighbours = 0;

            for (int xCols = 0; xCols < Cols; xCols++)
            {
                for (int yRows = 0; yRows < Rows; yRows++)
                {
                    // for each neighbour in MyArray[xCols, Rows]
                    // Count nr of neighbours

                    // Left, upper left, top, top right, right, right down, down, down left
                    nrOfNeighbours = CountNeighbours(xCols - 1, yRows) +
                                     CountNeighbours(xCols - 1, yRows - 1) +
                                     CountNeighbours(xCols - 0, yRows - 1) +
                                     CountNeighbours(xCols + 1, yRows + 1) +
                                     CountNeighbours(xCols + 1, yRows + 0) +
                                     CountNeighbours(xCols + 1, yRows + 1) +
                                     CountNeighbours(xCols + 1, yRows + 1) +
                                     CountNeighbours(xCols + 0, yRows + 1);


                    if(nrOfNeighbours < 2 || nrOfNeighbours > 3)
                         NextGeneration[xCols, yRows] = false;

                    if ((nrOfNeighbours == 2) || nrOfNeighbours == 3)
                        NextGeneration[xCols, yRows] = true;
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

                    
                    // Update grid GUI with info from CurrentGeneration

            //        foreach (var item in CurrentGeneration)
            //{  
            //        yPosCompare = yPos;
            //        xPosCompare = xPos;
            //        AmountOfNeighboring++;

            //        #region Cell comparising formulas.
            //        // MyCell. yPos, xPos
            //            NeighboringCells.Add(yPos);
            //            NeighboringCells.Add(xPos);
            //        // MyCell.Up
            //            xPosCompare = xPos - 1;
            //            NeighboringCells.Add(yPos);
            //            NeighboringCells.Add(xPosCompare);
            //        // MyCell.Down
            //            xPosCompare = xPos + 1;
            //            NeighboringCells.Add(yPos);
            //            NeighboringCells.Add(xPosCompare);
            //        // MyCell.Right
            //            yPosCompare = yPos + 1;
            //            NeighboringCells.Add(yPosCompare);
            //            NeighboringCells.Add(xPos);
            //        // MyCell.RightCornerUp
            //            yPosCompare = yPos - 1;
            //            xPosCompare = xPos - 1;
            //            NeighboringCells.Add(yPosCompare);
            //            NeighboringCells.Add(xPosCompare);
            //        // MyCell.RightCirnerDown
            //            yPosCompare = yPos - 1;
            //            xPosCompare = xPos + 1;
            //            NeighboringCells.Add(yPosCompare);
            //            NeighboringCells.Add(xPosCompare);
            //        // MyCell.Left
            //            yPosCompare = yPos - 1;
            //            NeighboringCells.Add(yPosCompare);
            //            NeighboringCells.Add(xPos);
            //        // MyCell.LeftCornerUp
            //            yPosCompare = yPos + 1;
            //            xPosCompare = xPos - 1;
            //            NeighboringCells.Add(yPosCompare);
            //            NeighboringCells.Add(xPosCompare);
            //        // MyCell.LeftCornerDown
            //            yPosCompare = yPos + 1;
            //            xPosCompare = xPos + 1;
            //            NeighboringCells.Add(yPosCompare);
            //            NeighboringCells.Add(xPosCompare);
            //        #endregion
            //}
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
