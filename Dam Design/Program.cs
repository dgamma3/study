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
        
        public static void DamnDesign(int[] wallPositions , int[] wallHeights )
        {
            var mudwall = wallPositions[1] - wallPositions[0]-1;
            var wallheights = wallHeights[1] - wallHeights[0];
            var middleFromLeft = new int[mudwall];
            var middleFromRight = new int[mudwall];
            var finalMudWall = new int[mudwall];

            var start = wallHeights[0]+1;
            var end = wallHeights[1]+1;
            
            
            for (int i = 0; i < mudwall; i++)
            {
                middleFromLeft[i] = start++;
            }

            for (int j = mudwall - 1; j >= 0; j--)
            {
                middleFromRight[j] = end++;
            }

            var intersect = middleFromLeft.Intersect(middleFromRight);
            var except = middleFromLeft.Except(middleFromRight).ToArray();

            for (int i = 0; i < except.Count(); i++)
            {
                finalMudWall[i] = except[i];

            }

            var diff = finalMudWall.Length - except.Length;

            for (int i = except.Length-1; i < finalMudWall.Length; i++)
            {
                finalMudWall[i] =;

            }

        }
    }
}