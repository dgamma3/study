using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic.CompilerServices;

namespace Bucket_Fill
{
    //https://www.hackerrank.com/work/library/hackerrank?copyscrape=true&difficulties=Easy&question=568819&view=question
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        
        public static int  StrokesRequired(string[] args)
        {
            var height = args.Length;
            var width = args[0].Length;

            var picture = new List<List<Cell>>();
            
            InitaliseCells(picture,height, width);
            
            RelateAdjacentCells(args, height, width, picture);


            var amountOfUniqueCellGroups = getAmountOfUniqueCellGroups(height, width, picture);

            return amountOfUniqueCellGroups.Count(x => x.amount > 0);
  

        }

        private static List<ResursiveAmount> getAmountOfUniqueCellGroups(int height, int width, List<List<Cell>> picture)
        {
            var recursiveAmounts = new List<ResursiveAmount>();
            ;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    var recursiveAmount = new ResursiveAmount();
                    findMatchingCells(picture[i][j], picture, recursiveAmount);
                    recursiveAmounts.Add(recursiveAmount);
                }
            }

            return recursiveAmounts;
        }

        private static void RelateAdjacentCells(string[] args, int height, int width, List<List<Cell>> picture)
        {
            for (int heightCounter = 0; heightCounter < height; heightCounter++)
            {
                for (int widthCounter = 0; widthCounter < width; widthCounter++)
                {
                    Cell top, bottom, left, right = null;
                    if (heightCounter == 0)
                    {
                        top = null;
                        bottom = picture[heightCounter + 1][widthCounter];
                    }
                    else if (heightCounter == height - 1)
                    {
                        top = picture[heightCounter - 1][widthCounter];
                        bottom = null;
                    }
                    else
                    {
                        top = picture[heightCounter - 1][widthCounter];
                        bottom = picture[heightCounter + 1][widthCounter];
                    }

                    if (widthCounter == 0)
                    {
                        left = null;
                        right = picture[heightCounter][widthCounter + 1];
                    }
                    else if (widthCounter == width - 1)
                    {
                        left = picture[heightCounter][widthCounter - 1];
                        right = null;
                    }
                    else
                    {
                        left = picture[heightCounter][widthCounter - 1];
                        right = picture[heightCounter][widthCounter + 1];
                    }


                    var cell = picture[heightCounter][widthCounter];
                    cell.x = widthCounter;
                    cell.y = heightCounter;
                    cell.val = args[heightCounter][widthCounter];
                    cell.top = top;
                    cell.left = left;
                    cell.right = right;
                    cell.bottom = bottom;
                }
            }
        }

        private static void InitaliseCells(List<List<Cell>> picture, int height, int width)
        {
            for (int i = 0; i < height; i++)
            {
                var cellRow = new List<Cell>();
                picture.Add(cellRow);
                for (int j = 0; j < width; j++)
                {
                    cellRow.Add(new Cell());
                }
            }
      
        }

        private static Cell findMatchingCells(Cell cell, List<List<Cell>> picture, ResursiveAmount maxRecursives)
        {
            
            if (cell.marked==true)
            {
                return cell;
            }

            maxRecursives.amount++;
            
            cell.marked = true;
            
            if (cell.top != null&& cell.top.val == cell.val)
            {
                findMatchingCells(cell.top, picture,maxRecursives);
            }
            
            if (cell.left != null&& cell.left.val == cell.val)
            {
                findMatchingCells(cell.left, picture,maxRecursives);
            }
            if (cell.right != null&& cell.right.val == cell.val)
            {
                findMatchingCells(cell.right, picture,maxRecursives);
            }
            if (cell.bottom != null&& cell.bottom.val == cell.val)
            {
                findMatchingCells(cell.bottom, picture,maxRecursives);
            }

            return cell;

        }
    }

    public class ResursiveAmount
    {
        public int amount=0;
    }

    public class Cell
    {
        public int x;
        public int y;
        public char val;
        public Cell top;
        public Cell bot;
        public Cell left;
        public Cell right;
        public Cell bottom { get; set; }
        public bool marked  { get; set; }
    }
}