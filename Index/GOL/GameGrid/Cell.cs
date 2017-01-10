using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOL.GameGrid
{
    class Cell
    {
        //A Cell can be alive or dead based on this property; - true = alive and false = dead
        public Boolean IsAlive { get; set; }

        /*
        public Rectangle Bounds { get; set; }
        
        public Cell(Pont position)
        {
            Position = position;
            Bounds = new Rectangle(position.X * GameGrid.CellSize, position.Y * GameGrid.CellSize, GameGrid.CellSize);

            IsAlive = false;
        }
        public void Update(MouseState mousestate)
        {
            if (Bounds.contains(new Point(mousestate.X, mousestate.Y)))
            {
                if (mousestate.LeftButton == ButtonState.Pressed)
                    IsAlive = true;
                else if (mousestate.RightButton == ButtonState.Pressed)
                    IsAlive = false;
            }
        }
        public void Draw
        */
    }
}
