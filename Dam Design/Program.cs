using System;
using System.Collections.Generic;
using System.Linq;

namespace Dam_Design
{
   public class Program
    {
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
            var spaceBetweenHeights = wallHeightDiff - 1;
            var fill = new int[spaceBetweenWalls];
            var start = wallHeights[0] + 1;
            var end = wallHeights[1];

            /*
            if (linearMudSegementsNeeded < 0)
            {
                return new int[]{wallHeights[0], wallHeights[1]}.Max();
            }*/
            if (spaceBetweenHeights > 0 && spaceBetweenWalls > spaceBetweenHeights)
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
            else if(spaceBetweenHeights > 0 && spaceBetweenWalls == spaceBetweenHeights)
            {
                for (int i = 0; i < spaceBetweenWalls; i++)
                {
                    fill[i] = (start++);
                }
            }
            else if(spaceBetweenHeights < 0 && spaceBetweenWalls > spaceBetweenHeights)
            {
                var g = 3;
            }

            return fill.Length == 0 ?0 : fill.Max();
        }
    }
}