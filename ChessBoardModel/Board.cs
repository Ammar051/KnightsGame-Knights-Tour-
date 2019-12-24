using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardModel
{
   public class Board
    {
        public int size { get; set; }
        public Cell[,] theGrid { get; set; }

        public int[] colPath = { 1, 2, 2, 1, -1, -2, -2, -1 };

        public int[] rowPath = { 2, 1, -1, -2, -2, -1, 1, 2 };
        public Board(int size)
        {
            this.size = size;
            theGrid = new Cell[size, size];

            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    theGrid[i, j] = new Cell(i, j);
                }
            }
        }
        public bool isSafe(int x, int y)
        {
            bool flag = false;
            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    if(x == i  && y == j)
                    {
                        flag = true;
                    }
                }
            }
            if (!flag)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void reset()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    theGrid[i, j].legalNextMove = false;
                    theGrid[i, j].currentlyOccupied = false;
                }
            }
        }
        public void markNextLegalMove(Cell currentCell)
        {
            for(int i = 0; i < size ; i++)
            {
                for(int j = 0; j < size ; j++)
                {
                    theGrid[i, j].legalNextMove = false;
                }
            }
            theGrid[currentCell.ColNumber, currentCell.RowNumber].currentlyOccupied = true;

           if(isSafe(currentCell.ColNumber + colPath[0], currentCell.RowNumber + rowPath[0]))
                theGrid[currentCell.ColNumber + colPath[0], currentCell.RowNumber + rowPath[0]].legalNextMove = true;
            if (isSafe(currentCell.ColNumber + colPath[1], currentCell.RowNumber - rowPath[1]))
                theGrid[currentCell.ColNumber + colPath[1], currentCell.RowNumber - rowPath[1]].legalNextMove = true;
            if (isSafe(currentCell.ColNumber - colPath[2], currentCell.RowNumber + rowPath[2]))
                theGrid[currentCell.ColNumber - colPath[2], currentCell.RowNumber + rowPath[2]].legalNextMove = true;
            if (isSafe(currentCell.ColNumber - colPath[3], currentCell.RowNumber - rowPath[3]))
                theGrid[currentCell.ColNumber - colPath[3], currentCell.RowNumber - rowPath[3]].legalNextMove = true;
            if (isSafe(currentCell.ColNumber + colPath[4], currentCell.RowNumber + rowPath[4]))
                theGrid[currentCell.ColNumber + colPath[4], currentCell.RowNumber + rowPath[4]].legalNextMove = true;
            if (isSafe(currentCell.ColNumber + colPath[5], currentCell.RowNumber - rowPath[5]))
                theGrid[currentCell.ColNumber + colPath[5], currentCell.RowNumber - rowPath[5]].legalNextMove = true;
            if (isSafe(currentCell.ColNumber - colPath[6], currentCell.RowNumber + rowPath[6]))
                theGrid[currentCell.ColNumber - colPath[6], currentCell.RowNumber + rowPath[6]].legalNextMove = true;
            if (isSafe(currentCell.ColNumber - colPath[7], currentCell.RowNumber - rowPath[7]))
                theGrid[currentCell.ColNumber - colPath[7], currentCell.RowNumber - rowPath[7]].legalNextMove = true;
          
            
        }
    }
}
