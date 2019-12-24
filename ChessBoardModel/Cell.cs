using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardModel
{
    public class Cell
    {
        public int RowNumber { get; set; }
        public int ColNumber { get; set; }
        public bool currentlyOccupied { get; set; }
        public bool legalNextMove { get; set; }

       public Cell(int x,int y)
        {
            this.ColNumber = x;
            this.RowNumber = y;
        }

    }
}
