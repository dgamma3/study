using System;
using System.Collections.Generic;
using System.Linq;

namespace Dam_Design
{
   public class Program
    {
        //https://www.hackerrank.com/work/library/hackerrank?copyscrape=true&difficulties=Easy&question=569491&view=question
        static void Main(string[] args)
        {
        }
        
        public static int DamnDesign(int[] wallPositions , int[] wallHeights )
        {
            var maxHights = new List<int>();
            for (int i = 0; i < wallPositions.Length-1; i++)
            {
                maxHights.Add(maxMudHight(new []{wallPositions[i],wallPositions[i+1]}, new []{wallHeights[i], wallHeights[i+1]}));
            }

            return maxHights.Max();
        }

        private static int maxMudHight(int[] wallPositions, int[] wallHeights)
        {
            var spaceBetweenWalls = wallPositions[1] - wallPositions[0] - 1;
            var wallHeightDiff = wallHeights[1] - wallHeights[0];
            var fill = new int[spaceBetweenWalls];
            var start = wallHeights[0] + 1;
            var end = wallHeights[1];

            /*
            if (linearMudSegementsNeeded < 0)
            {
                return new int[]{wallHeights[0], wallHeights[1]}.Max();
            }*/
            if (wallHeightDiff > 0 && spaceBetweenWalls > wallHeightDiff)
            {
                for (int i = 0; i < wallHeightDiff; i++)
                {
                    fill[i] = (start++);
                }

                var remaingSpace = spaceBetweenWalls - wallHeightDiff;

                for (int i = 0, counter = 0; i < remaingSpace; i = i + 2)
                {
                    fill[wallHeightDiff + counter] = (start);
                    fill[fill.Length - 1 - counter] = start++;
                    counter++;
                }
            }
            else if(wallHeightDiff > 0 && spaceBetweenWalls == wallHeightDiff)
            {//increasing
                for (int i = 0; i < spaceBetweenWalls; i++)
                {
                    fill[i] = (start++);
                }
            }
            else if(wallHeightDiff < 0 && spaceBetweenWalls > wallHeightDiff)
            {//decreasing

                throw new NotImplementedException();
                for (int i = 0; i < spaceBetweenWalls; i++)
                {
                    fill[i] = (start++);
                }
            }

            return fill.Length == 0 ?0 : fill.Max();
        }
    }
}