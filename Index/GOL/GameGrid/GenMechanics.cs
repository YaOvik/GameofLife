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
        public Int32[,] GridPos = new int[10, 10];
        public bool[,] MyTempArray = new bool[10, 10];
        

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
            int yPosNew, xPosNew, yPosCompare, xPosCompare;

            
            foreach (var item in MyArray)
            {
                if (MyArray[yPos, xPos] == true)
                {
                    yPosCompare = yPos;
                    xPosCompare = xPos;

                    #region Cell comparising formulas.
                    //Compare Up - collumn
                    xPos = xPosCompare - 1;

                    //Compare Down - Collumn
                    xPos = xPosCompare + 1;

                    //Compare Right - Row
                    yPos = yPosCompare + 1;

                    //Compare Left - Row
                    yPos = yPosCompare - 1;

                    //Compare RightUp
                    yPos = yPosCompare - 1;
                    xPos = xPosCompare - 1;

                    //Compare RightDown
                    yPos = yPos - 1;
                    xPos = xPosCompare + 1;

                    //Compare LeftUp
                    yPos = yPosCompare + 1;
                    xPos = xPosCompare - 1;

                    //Comapre LeftDown
                    yPos = yPosCompare + 1;
                    xPos = xPosCompare + 1;
                    #endregion
                }
            }
        }
    }
}
