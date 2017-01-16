using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOL.GameGrid
{
    public class GenLogics
    {
        public string MyVal
        {
            get { return MyVal;  }
            set { }
        }

        public bool[,] MyArray = new bool[10, 10];
        public Int32[,] GridPos = new int[10, 10];

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
            btnNeighbors(yPos, xPos, MyVal);
        }

        private void btnNeighbors(int yPos, int xPos, string myVal)
        {
            
            
            if(MyArray[yPos, xPos] == true)
            {
                myVal = "true";
                MyVal = myVal;
            }
            else
            {
                myVal = "false";
                MyVal = myVal;
            }


           // LivingCells.GetValue(liveCell_yPos, liveCell_xPos, livingCell);

//            GridPos.GetValue(yPos, xPos);

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
