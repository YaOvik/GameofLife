using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOL.GameGrid
{
    public class GenLogics
    {
        public bool[,] LivingCells = new bool[10, 10];
        public Int32[,] GridPos = new int[10, 10];

        public void setPosition(int yPos , int xPos, bool living)
        {
            if(living == false)
            {
                LivingCells[yPos, xPos] = false;
            }
            else
            {
                LivingCells[yPos, xPos] = true;
            }
        }

        private void btnNeighbors(int yPos, int xPos, bool liveCell)
        {
            //LivingCells(yPos, xPos, liveCell);
            GridPos.GetValue(yPos, xPos);

            //LivingCells
            /*
            for (int i = 1; xPos <= yPos; i++)
            {






                for (int z = 0; i < 10; z++)
                {

                    if (LivingCells(yPos, xPos) == true)


                        if (z == 8)
                    {
                        break;
                    }
                }
                
                xPos++;
                if (xPos == 9)
                {
                    yPos = yPos + 1;
                    xPos = xPos - xPos;
                }
            }
            */
        }
    }
}
