using System;
using System.Collections.Generic;

namespace Bucket_Fill
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        
        public static void BucketFill(string[] args)
        {
            var height = args.Length;
            var width = args[0].Length;

            var picture = new List<List<Cell>>();
            InitalisePicture(picture,height, width);
            
            
            for (int heightCounter = 0; heightCounter < height; heightCounter++)
            {
             for (int widthCounter = 0; widthCounter < width; widthCounter++)
                {
                    Cell top, bottom,left, right = null;
                    if (heightCounter == 0)
                    {
                        top = null;
                        bottom = picture[heightCounter + 1][widthCounter];

                    }
                    else if(heightCounter == height-1)
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
                        right = picture[heightCounter][widthCounter+1];

                    }
                    else if(widthCounter == width-1)
                    {
                        left = picture[heightCounter ][widthCounter-1];
                        right = null;
                    }
                    else
                    {
                        left = picture[heightCounter ][widthCounter-1];
                        right = picture[heightCounter ][widthCounter+1];
                    }


                    var cell = picture[heightCounter][widthCounter];
                    cell.x = widthCounter;
                    cell.y = heightCounter;
                    cell.val =  args[heightCounter][widthCounter];
                    cell.top = top;
                    cell.left = left;
                    cell.right = right;
                    cell.bottom = bottom;
                    
                   
                }
            }

            FindConnected(picture[0][0], picture);

            var g = 3;

            /*for (int heightCounter = 0; heightCounter < height; heightCounter++)
            {
                var cellRow = new List<Cell>();
                picture.Add(cellRow);
                for (int widthCounter = 0; widthCounter < width; widthCounter++)
                {
                 
                }
            }*/

        }

        private static void InitalisePicture(List<List<Cell>> picture, int height, int width)
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

        private static Cell FindConnected(Cell cell, List<List<Cell>> picture)
        {
            
            if (cell.marked==true)
            {
                return cell;
            }
            cell.marked = true;
            
            if (cell.top != null&& cell.top.val == cell.val)
            {
                FindConnected(cell.top, picture);
            }
            
            if (cell.left != null&& cell.left.val == cell.val)
            {
                FindConnected(cell.left, picture);
            }
            if (cell.right != null&& cell.right.val == cell.val)
            {
                FindConnected(cell.right, picture);
            }
            if (cell.bottom != null&& cell.bottom.val == cell.val)
            {
                FindConnected(cell.bottom, picture);
            }

            return cell;

        }
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