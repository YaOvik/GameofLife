using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOL.GameGrid
{
    public class GenLogics
    {
        
        public bool[,] MyArray = new bool[10, 10];
        public bool[,] MyTempArray = new bool[10, 10];
        public List<Int32> NeighboringCells = new List<int>();


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
                MyArray[yPos, xPos] = false;
            }
            else
            {
                MyArray[yPos, xPos] = true;
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

        private void btnNeighbors(int yPos, int xPos)
        {
            int yPosNewLiveCell, xPosNewLiveCell, yPosCompare, xPosCompare;

            foreach (var item in MyArray)
            {
                if (MyArray[yPos, xPos] == true)
                {
                    yPosCompare = yPos;
                    xPosCompare = xPos;

                    #region Cell comparising formulas.
                    // MyCell. yPos, xPos
                        NeighboringCells.Add(yPos);
                        NeighboringCells.Add(xPos);
                    // MyCell.Up
                        xPosCompare = xPos - 1;
                        NeighboringCells.Add(yPos);
                        NeighboringCells.Add(xPosCompare);
                    // MyCell.Down
                        xPosCompare = xPos + 1;
                        NeighboringCells.Add(yPos);
                        NeighboringCells.Add(xPosCompare);
                    // MyCell.Right
                        yPosCompare = yPos + 1;
                        NeighboringCells.Add(yPosCompare);
                        NeighboringCells.Add(xPos);
                    // MyCell.RightCornerUp
                        yPosCompare = yPos - 1;
                        xPosCompare = xPos - 1;
                        NeighboringCells.Add(yPosCompare);
                        NeighboringCells.Add(xPosCompare);
                    // MyCell.RightCirnerDown
                        yPosCompare = yPos - 1;
                        xPosCompare = xPos + 1;
                        NeighboringCells.Add(yPosCompare);
                        NeighboringCells.Add(xPosCompare);
                    // MyCell.Left
                        yPosCompare = yPos - 1;
                        NeighboringCells.Add(yPosCompare);
                        NeighboringCells.Add(xPos);
                    // MyCell.LeftCornerUp
                        yPosCompare = yPos + 1;
                        xPosCompare = xPos - 1;
                        NeighboringCells.Add(yPosCompare);
                        NeighboringCells.Add(xPosCompare);
                    // MyCell.LeftCornerDown
                        yPosCompare = yPos + 1;
                        xPosCompare = xPos + 1;
                        NeighboringCells.Add(yPosCompare);
                        NeighboringCells.Add(xPosCompare);
                    #endregion
                }
            }
        }
    }
}
