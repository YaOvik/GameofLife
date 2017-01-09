﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOL.GameGrid
{
    /// <summary>
    /// Cell types are unique types of cell in grid of any size
    /// Every cell type has distinct reachable djacent cells which can be traversed
    /// </summary>
    public enum CellTypeEnum
    {
        TopLeftCorner,
        TopRightCorner,
        BottomLeftCorner,
        BottomRightCorner,
        TopSide,
        BottomSide,
        LeftSide,
        RightSide,
        Center,
        OuterTopSide,
        OuterRightSide,
        OuterBottomSide,
        OuterLeftSide,
        None
    }
}
